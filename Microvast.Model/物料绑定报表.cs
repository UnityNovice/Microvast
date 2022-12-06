using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 物料绑定报表
	{
		public 物料绑定报表()
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
		public string 批次号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 日期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工单号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料批次 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 状态 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 数量 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 用户 { get; set; }
		
	}
}
