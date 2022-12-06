using System;
using SqlSugar;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 物料配置
	{
		public 物料配置()
		{
		}
		
		///<summary>
		///
		///</summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料描述Cn { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料类型 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料版本标识 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 旧物料号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料描述En { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位编码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 规格型号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 毛重 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 净重 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 重量单位 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 保质期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料组 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 替代料标识 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 替代日期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 采购类型 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 供应商组 { get; set; }

		///<summary>
		///
		///</summary>
		public string 替代后物料组 { get; set; }
		
	
		
		///<summary>
		///
		///</summary>
		public string TransactionID { get; set; }
		
	}
}
