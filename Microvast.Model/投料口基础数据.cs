using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 投料口基础数据
	{
		public 投料口基础数据()
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
		public string 投料口代码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料代码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 创建用户 { get; set; }
		
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
