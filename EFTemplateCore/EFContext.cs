using EFTemplateCore.EFDbConnection;
using EFTemplateCore.EFDbConnection.JsonDbConnection;
using EFTemplateCore.EFLogging;
using EFTemplateCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Data.Common;

namespace EFTemplateCore
{
    public abstract class EFContext : DbContext, IEFContext, IDisposable
    {
        DbConnection dbConnection;
        string connectionString;
        public EFContext()
        {
            this.connectionString = EFDbConnectionFactory.CreateDefaultInstance().GetConnectionString();
        }

        public static readonly LoggerFactory LoggerFactory = new LoggerFactory(new[]
        {
            new EFLogProvider(
                s => Console.WriteLine(string.Concat(@"---------------------------------------------------------
",s)),
                (c, l) => l == LogLevel.None || c == DbLoggerCategory.Query.Name)
        });

        public EFContext(DbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public EFContext(string connectionName)
        {
            this.connectionString = EFDbConnectionFactory.CreateDefaultInstance(connectionName).GetConnectionString();
         }

        public EFContext(IEFDbConnectionProvider connectionProvider)
        {
            connectionString = connectionProvider.GetConnectionString();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                if (dbConnection != null) {
                    optionsBuilder.UseSqlServer(dbConnection);
                }
                else if (!string.IsNullOrWhiteSpace(connectionString)) {
                    optionsBuilder.UseSqlServer(connectionString);
                }
                else/////SafeUtilities
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
            }

            base.OnConfiguring(optionsBuilder);
            if (LoggerFactory != null) {
                optionsBuilder.UseLoggerFactory(LoggerFactory);
            }
        }
    }
}