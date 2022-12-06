using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 工艺配方信息
	{
		public 工艺配方信息()
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
		public string 配方名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工步 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 投料或搅拌标识 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料或参数代码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
	}
}
