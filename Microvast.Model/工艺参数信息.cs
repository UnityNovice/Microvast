using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 工艺参数信息
	{
		public 工艺参数信息()
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
		public string 参数代码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 参数名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 上限 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 下限 { get; set; }
		
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
