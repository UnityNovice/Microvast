using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 载具基础数据
	{
		public 载具基础数据()
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
		public string 载具编码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 载具类型 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 载具规格 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 载具状态 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 维护人员 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 更新时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 使用位置 { get; set; }
		
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
