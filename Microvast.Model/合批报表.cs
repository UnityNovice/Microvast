using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 合批报表
	{
		public 合批报表()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        ///<summary>
        ///
        ///</summary>
        public int ID { get; set; }
		
		///<summary>
		///合批时间
		///</summary>
		public DateTime? 时间 { get; set; }
		
		///<summary>
		///合批前批次1批次号
		///</summary>
		public string 合批前批次1 { get; set; }
		
		///<summary>
		///合批前批次1重量
		///</summary>
		public string 合批前批次1重量 { get; set; }
		
		///<summary>
		///合批前批次2批次号
		///</summary>
		public string 合批前批次2 { get; set; }
		
		///<summary>
		///合批前批次2重量
		///</summary>
		public string 合批前批次2重量 { get; set; }
		
		///<summary>
		///合批后批次
		///</summary>
		public string 合批后批次 { get; set; }
		
		///<summary>
		///合批后批次重量
		///</summary>
		public string 合批后批次重量 { get; set; }
		
		///<summary>
		///合批操作者
		///</summary>
		public string 合批操作者 { get; set; }
        public string 工序 { get; set; }
    }
}
