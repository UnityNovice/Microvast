using System;
using System.Collections.Generic;
using SqlSugar;		
namespace Microvast.Model
{
	public class DataRefence
	{
		public DataRefence()
		{
		}
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        ///<summary>
        ///
        ///</summary>
        public int id { get; set; }
		
		///<summary>
		///符号名
		///</summary>
		public string PLC地址 { get; set; }
		
		///<summary>
		///工序号
		///</summary>
		public string 工序 { get; set; }
		
		///<summary>
		///检测数据号
		///</summary>
		public string 数据号 { get; set; }
		
		///<summary>
		///检测数据名称
		///</summary>
		public string 数据名称 { get; set; }
		
		///<summary>
		///检测数据类型（1：OK/NG类型；2：数值类型；3：字符类型）
		///</summary>
		public int? 数据类型 { get; set; }
		
		///<summary>
		///备注
		///</summary>
		public string 数据备注 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 精确度 { get; set; }
		
		///<summary>
		///
		///</summary>
		public int? 数据收集 { get; set; }
		
		///<summary>
		///
		///</summary>
		public int? 要求数据类型 { get; set; }
		
		///<summary>
		///
		///</summary>
		public int? 功能码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public int? 检查类型 { get; set; }

		public string 采集项编码 { get; set; }
	}
}
