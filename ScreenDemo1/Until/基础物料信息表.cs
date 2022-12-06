using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test
{
    public class 基础物料信息表
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string 物料ID { get; set; }
        public string 物料代码 { get; set; }
        public string 材料名称 { get; set; }
        public string 中文全称 { get; set; }
        public string 版本 { get; set; }
        public string 单位 { get; set; }
        public string 规格 { get; set; }
        public string 保质期 { get; set; }
        public string 投料口A { get; set; }
        public string 投料口B { get; set; }
        public string 投料口C { get; set; }
    }
}
