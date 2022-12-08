using Microvast.Common.Utils;
using Microvast.Model;
using Microvast.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Service
{
    public static class 搅拌Service
    {
        #region 方法
        public static List<WorkOrder> 正极加载工单()
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            //状态变更最早而且叫做"生产中"的工单
            var 生产工单s = sqlSugarServerHelper.db.Queryable<工单基础数据>().Where(a => a.工单类型.Contains("WorkOrder") && a.工单当前状态.Contains("生产中")).ToList();
            List<WorkOrder> workOrders = new List<WorkOrder>();
            for (int i = 0; i < 生产工单s.Count; i++)
            {
                WorkOrder workOrder = new WorkOrder();
                workOrder.workordernum = 生产工单s[i].产品编码;//"MV32022092900" + i.ToString();
                workOrder.Status = 生产工单s[i].工单当前状态;//"未生产";
                workOrder.Priority = 生产工单s[i].优先级;//"一般";
                //if (i == 3)
                //{
                //    workOrder.Priority = "紧急";
                //}
                workOrders.Add(workOrder);
            }
            return workOrders;
        }
        public static List<WorkOrder> 负极加载工单()
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
                //if (i == 3)
                //{
                //    workOrder.Priority = "紧急";
                //}
                workOrders.Add(workOrder);
            }
            return workOrders;
        }
        #endregion
    }
}
