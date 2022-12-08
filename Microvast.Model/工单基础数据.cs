using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace TestClass
{
	public class 工单基础数据
	{
		public 工单基础数据()
		{
		}

		///<summary>
		///
		///</summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
		
		public string 产线编号 { get; set; }
		public string 产线名称 { get; set; }
		public string 工单 { get; set; }
		public string 订单编号 { get; set; }
		public string 工单类型 { get; set; }
		public string BOM编码 { get; set; }
		public string BOM名称 { get; set; }
		public string BOM版本 { get; set; }
		public string 产品编码 { get; set; }
		public string 产品名称 { get; set; }
		public string 产品类型 { get; set; }
		public string 工艺路线编号 { get; set; }
		public string 工艺路线名称 { get; set; }
		public string 工艺路线版本 { get; set; }
		public string 销售订单号 { get; set; }
		public string 销售订单行项目 { get; set; }
		public string 客户名称 { get; set; }
		public DateTime? 计划开始时间 { get; set; }
		public DateTime? 计划结束时间 { get; set; }
        public int 计划数量 { get; set; }
        public int 超产上限 { get; set; }
        public string MRP控制员 { get; set; }
        public string 生产主管 { get; set; }
        public string 工单当前状态 { get; set; }
        public DateTime? 状态变更时间 { get; set; }
        public string TransactionID { get; set; }
        public string 优先级 { get; set; }


    }
}
