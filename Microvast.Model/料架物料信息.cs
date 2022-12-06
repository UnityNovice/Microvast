using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 料架物料信息
	{
		public 料架物料信息()
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
		public string 料架编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 料架位置 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料批次 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料数量 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 计量单位 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 状态 { get; set; }
		
		///<summary>
		///
		///</summary>
		public DateTime? 上架时间 { get; set; }
		
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
