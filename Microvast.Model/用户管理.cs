using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 用户管理
	{
		public 用户管理()
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
		public string 工号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 账号 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 密码 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 姓名 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 性别 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 角色 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 部门 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 岗位 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工作中心 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工厂 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 状态 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 创建时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 更新时间 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 创建者Id { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 创建者名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 修改者Id { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 修改者名称 { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 工序 { get; set; }
		
	}
}
