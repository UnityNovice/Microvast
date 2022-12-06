using System;
using System.Collections.Generic;
using SqlSugar;
namespace Microvast.Model
{
	public class 操作日志
	{
		public 操作日志()
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
		public string 操作事项 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 模块名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 写入时间 { get; set; }
		
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
		public string IP地址 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 返回内容 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string URL { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 新内容 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 旧内容 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
	}
}
