using System;
using System.Collections.Generic;
using SqlSugar;
namespace Microvast.Model
{
	public class BOM
	{
		public BOM()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]

        ///<summary>
        ///
        ///</summary>
        public int ID { get; set; }
		
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
		public string 产品编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产品名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 产品版本 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string BOM编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string BOM名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string BOM版本号 { get; set; }
		
		///<summary>
		///
		///</summary>
		
		///<summary>
		///
		///</summary>
		public string 工序代码 { get; set; }
		
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
		public string 物料编号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 物料版本号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public float 数量 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位编码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 单位名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 投料口 { get; set; }
		
		///<summary>
		///
		///</summary>
        public string TransactionID { get; set; }

    }
}
