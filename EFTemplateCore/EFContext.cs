using EFTemplateCore.EFDbConnection;
using EFTemplateCore.EFDbConnection.JsonDbConnection;
using EFTemplateCore.EFLogging;
using EFTemplateCore.Interfaces;
using EFTemplateCore.Logging;
using EFTemplateCore.ServiceLocator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Data.Common;

namespace EFTemplateCore
{
    public abstract class EFContext : DbContext, IEFContext, IDisposable
    {
        DbConnection dbConnection;
        string connectionString;
        string connectionName;
        ConnectionType connectionType = ConnectionType.DatabaseConnection;
        
        public EFContext()
        {
            this.connectionString = EFDbConnectionFactory.CreateDefaultInstance().GetConnectionString();
        }

        public static readonly LoggerFactory LoggerFactory = new LoggerFactory(new[]
        {
            new EFLogProvider(
                s => Services.Create<ILog>().LogFormat(s,LogLevel.Debug), (c, l) => l == LogLevel.None || c == DbLoggerCategory.Query.Name)

        });

        public EFContext(DbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public EFContext(string connectionName)
        {
            this.connectionName = connectionName;
            this.connectionString = EFDbConnectionFactory.CreateDefaultInstance(connectionName).GetConnectionString();
        }

        public EFContext(ConnectionType connectionType, string connectionName)
        {
            this.connectionType = connectionType;
            this.connectionName = connectionName;
            if (connectionType == ConnectionType.DatabaseConnection)
            {
                this.connectionString = EFDbConnectionFactory.CreateDefaultInstance(connectionName).GetConnectionString();
            }
        }

        public EFContext(IEFDbConnectionProvider connectionProvider)
        {
            connectionString = connectionProvider.GetConnectionString();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (connectionType == ConnectionType.InMemoryDatabaseConnection)
            {
                optionsBuilder
                .UseInMemoryDatabase(databaseName: connectionName)
                .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            }
            else if (connectionType == ConnectionType.DatabaseConnection)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    if (dbConnection != null)
                    {
                        optionsBuilder.UseSqlServer(dbConnection);
                    }
                    else if (!string.IsNullOrWhiteSpace(connectionString))
                    {
                        optionsBuilder.UseSqlServer(connectionString);
                    }
                    else//todo:safeutilities?
                    {
                        optionsBuilder.UseSqlServer(connectionString);
                    }
                }

                base.OnConfiguring(optionsBuilder);
                if (LoggerFactory != null)
                {
                    optionsBuilder.UseLoggerFactory(LoggerFactory);
                }
            }
        }
    }
}