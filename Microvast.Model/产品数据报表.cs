using System;
using System.Collections.Generic;
using SqlSugar;
namespace Microvast.Model
{
	public class 产品数据报表
	{
		public 产品数据报表()
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
		public string 状态码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 生产结果 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 用户 { get; set; }
		
	}
}
