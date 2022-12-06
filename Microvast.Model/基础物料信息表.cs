using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 基础物料信息表
	{
		public 基础物料信息表()
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
		public string 物料ID { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料代码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 材料名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 中文全称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 版本 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 规格 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 保质期 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 投料口A { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 投料口B { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 投料口C { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
	}
}
