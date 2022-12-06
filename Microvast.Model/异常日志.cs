using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 异常日志
	{
		public 异常日志()
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
		public string 用户账号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 用户名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 类名 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 方法名 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 异常名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 异常信息 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 异常源 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 堆栈信息 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 参数对象 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 异常时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
	}
}
