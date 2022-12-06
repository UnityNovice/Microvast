using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 班次基础数据
	{
		public 班次基础数据()
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
		public string 班次编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 班次名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 开始时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 结束时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 系统时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 状态 { get; set; }
		
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
