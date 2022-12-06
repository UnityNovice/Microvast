using System;
using System.Collections.Generic;
using SqlSugar;

namespace Microvast.Model
{
	public class 工艺路线
	{
		public 工艺路线()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]

        ///<summary>
        ///
        ///</summary>
        public int id { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产线编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产线名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工艺路线编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工艺路线名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工艺路线版本 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序编码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序版本 { get; set; }
		
		///<summary>
		///
		///</summary>
		public bool 是否需要记录进站 { get; set; }
		
		///<summary>
		///
		///</summary>
		public int 顺序编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 良品判断 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 流程判断 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 入站标识 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 出站标识 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string TransactionID { get; set; }
		
	}
}
