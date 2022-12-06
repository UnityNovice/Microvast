using MiniExcelLibs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Common.Utils
{
    public class ExcelHelper
    {
        public static void SaveExcel<T>(List<T> values) where T : class, new()
        {
            string isInsertOrCreate = "create";
            string fileName = DateTime.Now.ToString("yyyyMMdd");
            var path = Path.Combine(Environment.CurrentDirectory, $@"\{fileName}.xlsx");
            if (File.Exists(path))
            {
                isInsertOrCreate = "insert";
            }
            if (isInsertOrCreate == "create")
            {
                MiniExcel.SaveAs(path, values);
            }
            else
            {
                var beforeVal = MiniExcel.Query<T>(path).ToList();
                beforeVal.AddRange(values);
                File.Delete(path);
                MiniExcel.SaveAs(path, beforeVal);
            }
        }
        public static void SaveExcel(DataTable dt)
        {
            string fileName = DateTime.Now.ToString("yyyyMMdd");
            var path = Path.Combine(Environment.CurrentDirectory, $@"\{fileName}.xlsx");
            MiniExcel.SaveAs(path, dt);
        }
        public static void SaveExcel(List<Dictionary<string, object>> dic)
        {
            CheckDirectory();
            string isInsertOrCreate = "create";
            string fileName = DateTime.Now.ToString("yyyyMMdd");
            CheckCreateDirectory(fileName);
            var path = Path.Combine(Environment.CurrentDirectory, $@"\不要动这个文件夹\{fileName}.xlsx");
            var copyPath = Path.Combine(Environment.CurrentDirectory, $@"\中间表记录目录\{fileName}\{DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒")}.xlsx");
            if (File.Exists(path))
            {
                isInsertOrCreate = "insert";
            }
            if (isInsertOrCreate == "create")
            {
                MiniExcel.SaveAs(path, dic);
            }
            else
            {
                var beforeVal = MiniExcel.Query(path, useHeaderRow: true).ToList();
                //beforeVal.RemoveAt(0);
                var hehe = JsonConvert.SerializeObject(beforeVal);
                var xixi = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(hehe);
                xixi.AddRange(dic);
                //beforeVal.AddRange(dic);
                File.Delete(path);
                MiniExcel.SaveAs(path, xixi);
            }
            File.Copy(path, copyPath, true);
        }
        public static void CheckDirectory()
        {
            var dontMoveDirectory = Path.Combine(Environment.CurrentDirectory, $@"\不要动这个文件夹");
            var copyToDirectory = Path.Combine(Environment.CurrentDirectory, $@"\中间表记录目录");
            if (!Directory.Exists(dontMoveDirectory))
            {
                Directory.CreateDirectory(dontMoveDirectory);
            }
            if (!Directory.Exists(copyToDirectory))
            {
                Directory.CreateDirectory(copyToDirectory);
            }
        }
        public static void CheckCreateDirectory(string path)
        {
            var copyToDirectory = Path.Combine(Environment.CurrentDirectory, $@"\中间表记录目录\{path}");
            if (!Directory.Exists(copyToDirectory))
            {
                Directory.CreateDirectory(copyToDirectory);
            }
        }
    }
}
