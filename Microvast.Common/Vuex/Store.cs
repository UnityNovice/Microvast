using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Common.Vuex
{
    public static class Store
    {
        public delegate void CommonRefresh(string name);
        public static CommonRefresh CommonRefreshDel = null;
        public static string 工号 = "";
        public static string 角色 = "";
        public static string 名称 = "";
    }
}
