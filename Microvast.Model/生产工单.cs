using SqlSugar;
using System;
using System.Collections.Generic;

namespace Microvast.Model
{
    public class 工单基础数据
    {
        public 工单基础数据()
        {
        }
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        ///<summary>
        ///
        ///</summary>
        public int ID { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 产线编号 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 产线名称 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 工单 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 订单编号 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 工单类型 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string BOM编码 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string BOM名称 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string BOM版本 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 产品编码 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 产品名称 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 产品版本 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 产品类型 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 工艺路线编号 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 工艺路线名称 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 工艺路线版本 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 销售订单号 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 销售订单行项目 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 客户名称 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime? 计划开始时间 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime? 计划结束时间 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? 计划数量 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? 超产上限 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string MRP控制员 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 生产主管 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 工单当前状态 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime? 状态变更时间 { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string TransactionID { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string 优先级 { get; set; }

    }
}
