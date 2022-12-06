using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microvast.Model
{
    public class 新增修改通用表
    {
        public int id { get; set; }
        public string 表名 { get; set; }
        public string 字段名 { get; set; }
        public string 输入类型 { get; set; }
        public string 默认值 { get; set; }
        public int 字符长度限制 { get; set; }
        public int 内容限制 { get; set; }
    }
}
