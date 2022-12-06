using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 设备台账
	{
		public 设备台账()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        ///<summary>
        ///
        ///</summary>
        public int Id { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 设备编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 设备描述 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产线ID { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 设备类型 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 规格参数 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 层次结构 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 保修期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 购入安装日期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 供应商 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产地 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 设备状态 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 系统时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 用户编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 备注说明 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
	}
}
