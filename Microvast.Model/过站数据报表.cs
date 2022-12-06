using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 过站数据报表
	{
		public 过站数据报表()
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
		public DateTime? 系统时间 { get; set; }
		
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
		
		///<summary>
		///
		///</summary>
		public string 工单号 { get; set; }
		
	}
}
