using System;
using System.Collections.Generic;
using SqlSugar;
namespace Microvast.Model
{
	public class 报废报表
	{
		public 报废报表()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        ///<summary>
        ///
        ///</summary>
        public int ID { get; set; }
		
		///<summary>
		///报废时间
		///</summary>
		public DateTime? 时间 { get; set; }
		
		///<summary>
		///报废批次
		///</summary>
		public string 报废批次号 { get; set; }
		
		///<summary>
		///报废前数量
		///</summary>
		public string 报废前数量 { get; set; }
		
		///<summary>
		///报废后数量
		///</summary>
		public string 报废后数量 { get; set; }
		
		///<summary>
		///报废数量
		///</summary>
		public string 报废数量 { get; set; }
        public string 工序 { get; set; }
    }
}
