using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 产品型号
	{
		public 产品型号()
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
		public string 产品编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产品名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 版本号 { get; set; }
		
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
