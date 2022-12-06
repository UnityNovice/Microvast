using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Model
{
    public class 批次管理
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string 批次编号 { get; set; }
        public string 工单编号 { get; set; }
        public string 批次计划产量 { get; set; }
        public string 批次实际产量 { get; set; }
        public string 单位 { get; set; }
        public string 优先级 { get; set; }
        public string 批次创建时间 { get; set; }
        public string 批次完工时间 { get; set; }
        public string 设备编号 { get; set; }
        public string 批次状态 { get; set; }
        public string 批次创建用户 { get; set; }
        public string 系统时间 { get; set; }
        public string 备注说明 { get; set; }
    }
}
