using System.Collections.Generic;
using System.Data.SqlClient;


namespace EFTemplateCore
{
    public class SqlParameters : List<SqlParameter> {
        public SqlParameters() :base() {
        }
        public SqlParameters Add(string field, object value) {
            Add(new SqlParameter(field, value));
            return this;
        }
        public SqlParameter[] Array {
            get {
                return this.ToArray();
            }
        }
    }
}
