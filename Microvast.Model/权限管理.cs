using SqlSugar;
using System;
using System.Collections.Generic;
		
namespace Microvast.Model
{
	public class 权限管理
	{
		public 权限管理()
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
		public string 角色ID { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 菜单项ID { get; set; }
		
		///<summary>
		///
		///</summary>
		public string 备注说明 { get; set; }
		
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
		
	}
}
