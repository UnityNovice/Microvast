using Microvast.Common.Utils;
using Microvast.Common.Vuex;
using Microvast.Model;
using Microvast.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Service
{
    public class 通用Service
    {
        #region 方法:记录生产报工
        public static void 记录生产报工(string txt, string 工序)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            生产报工报表 生产报工 = new 生产报工报表();
            生产报工.工号 = Store.工号;
            生产报工.角色 = Store.角色;
            生产报工.名称 = Store.名称;
            生产报工.日期 = DateTime.Now;
            生产报工.工序 = 工序;
            生产报工.详情 = txt;
            sqlSugarServerHelper.db.Insertable(生产报工).ExecuteCommand();
        }
        #endregion
        public static List<WorkOrder> 加载工单(string aa)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            var 生产工单s = sqlSugarServerHelper.db.Queryable<工单基础数据>().Where(a => a.工单类型.Contains("WorkOrder") && a.工单当前状态.Contains("生产中")).ToList();
            List<WorkOrder> workOrders = new List<WorkOrder>();
            for (int i = 0; i < 生产工单s.Count; i++)
            {
                WorkOrder workOrder = new WorkOrder();
                workOrder.workordernum = 生产工单s[i].产品编码;//"MV32022092900" + i.ToString();
                workOrder.Status = 生产工单s[i].工单当前状态;//"未生产";
                workOrder.Priority = 生产工单s[i].优先级;//"一般";
                workOrders.Add(workOrder);
            }
            return workOrders;
        }

        public static 基础物料信息表 切换投料口(string dogHouse)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            var 投料口基础数据 = sqlSugarServerHelper.db.Queryable<基础物料信息表>()
                .LeftJoin<投料口基础数据>((c, t) => c.物料代码 == t.物料代码)
                .Where((c, t) => t.投料口代码 == dogHouse)
                .Select((c, t) => c)
                .First();
            ;
            return 投料口基础数据;
        }

        #region 记录运行和异常日志
        public static void 记录运行日志(string txt)
        {
            string now_date = DateTime.Now.ToString("yyyyMMdd");
            string path = Path.Combine(Environment.CurrentDirectory, now_date);
            if (!Directory.Exists(path))
            {
                //创建文件夹
                Directory.CreateDirectory(path);
            }
            Write2(txt, path);
        }


        public static void 记录异常日志(string txt)
        {
            string now_date = DateTime.Now.ToString("yyyyMMdd");
            string path = Path.Combine(Environment.CurrentDirectory, now_date);
            if (!Directory.Exists(path))
            {
                //创建文件夹
                string activeDir = Environment.CurrentDirectory;
                string newPath = Path.Combine(activeDir, now_date);
                Directory.CreateDirectory(newPath);
                //在文件夹中创建.txt文件，并写值
                Write2(txt, newPath, "异常日志");
            }
        }

        public static void Write2(string Logstring, string newPath, string type = "运行日志")
        {
            string 工号 = Store.工号;
            string 角色 = Store.角色;
            string 名称 = Store.名称;
            string 日期 = DateTime.Now.ToString("F");
            Logstring = $"日期:{日期} 工号:{工号} 角色:{角色} 名称:{名称} " + Logstring;
            string path = newPath + "\\" + type + ".txt";
            if (!File.Exists(path))
            {
                //创建.txt文件
                FileStream stream = File.Create(path);
                stream.Close();
                stream.Dispose();
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                //写入文件
                writer.WriteLine(Logstring+"\r\n");
                writer.Close();
            }
        } 
        #endregion

        public static string 读取运行日志()
        {
            string now_date = DateTime.Now.ToString("yyyyMMdd");
            string path = Path.Combine(Environment.CurrentDirectory, now_date);
            path= Path.Combine(path, "运行日志.txt");
            List<string> vs = new List<string>();
            StringBuilder sb = new StringBuilder();
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fileStream);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                    vs.Add(line);
                }
            }
            return sb.ToString();
        }
    }
}
