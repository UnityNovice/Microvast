using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 单位基础数据
	{
		public 单位基础数据()
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
		public string 数据项 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 默认单位 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位转换倍率 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 转换后单位 { get; set; }
		
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
