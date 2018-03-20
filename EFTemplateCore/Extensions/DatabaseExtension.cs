using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFTemplateCore.Extensions
{
    /// <summary>
    /// Db extension class for executing custom queries(Complex queries with many joins, operations etc.).
    /// </summary>
    public static class DatabaseExtension
    {
        public static IEnumerable<T> GetCustomQuery<T>(this DatabaseFacade database, string sql, List<SqlParameter> parameters)
            where T : new()
        {
            return RunCustomCommand<T>(database, sql, CommandType.Text, parameters.ToArray());
        }
        public static IEnumerable<T> GetCustomQuery<T>(this DatabaseFacade database, string sql, SqlParameters parameters)
            where T : new()
        {
            return RunCustomCommand<T>(database, sql, CommandType.Text, parameters.Array);
        }
        public static IEnumerable<T> GetCustomQuery<T>(this DatabaseFacade database, string sql, params SqlParameter[] parameters)
            where T : new()
        {
            return RunCustomCommand<T>(database, sql, CommandType.Text, parameters);
        }
        public static IEnumerable<T> CallSp<T>(this DatabaseFacade database, string spName, List<SqlParameter> parameters)
            where T : new()
        {
            return RunCustomCommand<T>(database, spName, CommandType.StoredProcedure, parameters.ToArray());
        }
        public static IEnumerable<T> CallSp<T>(this DatabaseFacade database, string spName, SqlParameters parameters)
            where T : new()
        {
            return RunCustomCommand<T>(database, spName, CommandType.StoredProcedure, parameters.Array);
        }
        public static IEnumerable<T> CallSp<T>(this DatabaseFacade database, string spName, params SqlParameter[] parameters)
            where T : new()
        {
            return RunCustomCommand<T>(database, spName, CommandType.StoredProcedure, parameters);
        }
        public static IEnumerable<T> RunCustomCommand<T>(this DatabaseFacade database, string commandText, CommandType commandType, params SqlParameter[] parameters)
            where T : new()
        {
            using (var cmd = database.GetDbConnection().CreateCommand())
            {
                cmd.CommandType = commandType;
                cmd.CommandText = commandText;
                if (cmd.Connection.State != ConnectionState.Open) { cmd.Connection.Open(); }

                foreach (SqlParameter p in parameters)
                {
                    cmd.Parameters.Add(p);
                }

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        T row = new T();
                        for (var fieldCount = 0; fieldCount < dataReader.FieldCount; fieldCount++)
                        {
                            if (dataReader != null && dataReader[fieldCount] != null && dataReader[fieldCount] != System.DBNull.Value)
                            {
                                string itemName = dataReader.GetName(fieldCount);
                                PropertyInfo prop = typeof(T).GetProperty(itemName.Replace("_", ""), BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.SetField | BindingFlags.Instance);
                                if (prop != null && !prop.PropertyType.IsByRef)
                                {
                                    prop.SetValue(row, dataReader[fieldCount], null);
                                }
                                else
                                {
                                    FieldInfo field = typeof(T).GetField(itemName.Replace("_", ""), BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.SetField | BindingFlags.Instance);
                                    if (field != null && !field.FieldType.IsByRef)
                                    {
                                        field.SetValue(row, dataReader[fieldCount]);
                                    }
                                }
                            }
                        }
                        yield return row;
                    }
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
            }
        }
    }
}
