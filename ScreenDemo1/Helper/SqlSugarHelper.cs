using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test
{
    public class SqlSugarHelper
    {
        public SqlSugarClient db;
        private static readonly string _connectionstring = "Database=Sqlserver20221010;Data Source=ZZH-BJB;User Id=sa;Password=Zzh330501;";
        //   private static readonly string _connectionstring = AppConfigHelper.GetConnectionString("mysql");
        public SqlSugarHelper()
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
