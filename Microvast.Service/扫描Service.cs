using Microvast.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Service
{
    public class 扫描Service
    {
        public static 扫描解析 GetScan(string str)
        {
            扫描解析 扫描解析 = new 扫描解析();
            var scanList=str.Split('|');
            if (scanList.Length == 8)
            {
                扫描解析.供应商ID = scanList[0];
                扫描解析.物料ID = scanList[1];
                扫描解析.单位ID = scanList[2];
                扫描解析.辅助状态标识 = scanList[3];
                扫描解析.批次号 = scanList[4];
                扫描解析.数量 = scanList[5];
                扫描解析.生产日期 = scanList[6];
                扫描解析.保质期 = scanList[7];
            }
            return 扫描解析;
        }
    }
}
