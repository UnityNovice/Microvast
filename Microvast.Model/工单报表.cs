using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 工单报表
	{
		public 工单报表()
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
		public string 工单号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 日期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 计划产量 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 实际产量 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 计划开始 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 计划结束 { get; set; }
		
	}
}
