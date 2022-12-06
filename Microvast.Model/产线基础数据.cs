using System;
using System.Collections.Generic;
using SqlSugar;
namespace Microvast.Model
{
	public class 产线基础数据
	{
		public 产线基础数据()
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
		public string 产线编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产线描述 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 用户编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 系统时间 { get; set; }
		
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
