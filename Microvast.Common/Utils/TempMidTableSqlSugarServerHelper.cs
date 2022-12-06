using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Common.Utils
{
    /// <summary>
    /// 中间表专用
    /// </summary>
    public class TempMidTableSqlSugarServerHelper
    {
        public SqlSugarClient db;
        private static readonly string _connectionstring = AppConfigHelper.GetConnectionString("sqlserver");
        public TempMidTableSqlSugarServerHelper()
        {
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = _connectionstring,
                DbType = SqlSugar.DbType.SqlServer,//数据库类型
                IsAutoCloseConnection = true,//自动释放数据库，如果存在事务，在事务结束之后释放。
            });
        }
    }
}
