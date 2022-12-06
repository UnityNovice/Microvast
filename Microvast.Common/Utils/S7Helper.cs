using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Microvast.Common.Utils
{
    public class S7Helper
    {
        private static S7Helper _S7Helper = null;
        private static object S7Helper_Lock = new object();
        public Plc plc;
        public static S7Helper CreateInstance()
        {
            if (_S7Helper == null)//双if+lock
            {
                lock (S7Helper_Lock)
                {
                    if (_S7Helper == null)
                    {
                        _S7Helper = new S7Helper();
                        string plcip = AppConfigHelper.GetAppsetting("plcip");
                        _S7Helper.plc = new Plc(CpuType.S71200, plcip, 0, 1);
                        _S7Helper.plc.Open();
                    }
                }
            }
            return _S7Helper;
        }
        public S7Helper()
        {
            string plcip = AppConfigHelper.GetAppsetting("plcip");
            plc = new Plc(CpuType.S71200, plcip, 0, 1);
            plc.Open();
        }
        public static string ReadNode(string DataTag)
        {
            string returnData = "";
            try
            {
                S7Helper s7Helper = S7Helper.CreateInstance();
                if (DataTag.Contains("WSTRING"))
                {
                    //取到DB块号
                    int dbInt = dbInt = int.Parse(MidStrEx(DataTag, "DB", "."));
                    //取到偏移量地址
                    int strAdr = int.Parse(MidStrEx(DataTag, "WSTRING", "."));
                    byte S7StringCount = (byte)s7Helper.plc.Read(DataType.DataBlock, dbInt, strAdr + 2, VarType.Int, 1);
                    object finalStr = s7Helper.plc.Read(DataType.DataBlock, dbInt, strAdr, VarType.S7String, S7StringCount);
                    returnData = finalStr.ToString();
                }
                else if (DataTag.Contains(".STRING"))
                {
                    #region 旧读String
                    #endregion
                    //取到DB块号
                    int dbInt = dbInt = int.Parse(MidStrEx(DataTag, "DB", "."));
                    //取到偏移量地址
                    int strAdr = int.Parse(MidStrEx(DataTag, "STRING", "."));
                    byte S7StringCount = (byte)s7Helper.plc.Read(DataType.DataBlock, dbInt, strAdr + 1, VarType.Byte, 1);
                    object finalStr = s7Helper.plc.Read(DataType.DataBlock, dbInt, strAdr, VarType.S7String, S7StringCount);
                    returnData = finalStr.ToString();
                }
                else if (DataTag.Contains("DATETIME"))
                {
                    //取到DB块号
                    int dbInt = dbInt = int.Parse(MidStrEx(DataTag, "DB", "."));
                    var spit = DataTag.Split('.');
                    int strAdr = Convert.ToInt32(DataTag.Replace($"DB{dbInt}.DATETIME", ""));
                    //读取时在地址前加两位偏移
                    var hehe = s7Helper.plc.Read(DataType.DataBlock, dbInt, strAdr, VarType.DateTime, 1);
                    returnData = hehe.ToString();
                }
                else if (DataTag.Contains("DBW"))
                {
                    //读取整数型数据
                    ushort UpValue = (ushort)s7Helper.plc.Read(DataTag);
                    returnData = Convert.ToString(UpValue);
                }
                else if (DataTag.Contains(".B"))
                {
                    //取到DB块号
                    int dbInt = dbInt = int.Parse(MidStrEx(DataTag, "DB", "."));
                    //取到偏移量地址
                    int strAdr = int.Parse(Regex.Match(DataTag, @"\d+$").ToString());
                    //获取字符串长度
                    var reservedLength = (byte)s7Helper.plc.Read(DataType.DataBlock, dbInt, strAdr, VarType.Byte, 1);
                    //将读取数据转为字符串
                    returnData = Convert.ToString(reservedLength);
                }
                else if (DataTag.Contains("DBD"))
                {
                    //读取小数型数据
                    double UpValue = ((uint)s7Helper.plc.Read(DataTag)).ConvertToFloat();
                    if (Convert.ToString(UpValue).Trim() != "")
                    {
                        //截取保留小数位长度
                        returnData = Math.Round(UpValue, 3).ToString();
                    }
                }
                else if (DataTag.Contains("DBX"))
                {
                    //读取Bool值数据
                    var db1Bool1 = s7Helper.plc.Read(DataTag);
                    returnData = db1Bool1.ToString();
                }
            }
            catch (Exception ex)
            {
                //读取异常
                S7Helper._S7Helper = null;
                return "plc断电了";
            }
            return returnData;
        }
        public static bool WriteNode(string DataTag, object value)
        {
            try
            {
                //取到DB块号
                int dbInt = dbInt = int.Parse(MidStrEx(DataTag, "DB", "."));
                //取到偏移量地址
                int strAdr = int.Parse(MidStrEx(DataTag, "STRING", "."));
                S7Helper s7Helper = S7Helper.CreateInstance();
                if (DataTag.Contains("STRING"))
                {
                    s7Helper.plc.Write(DataType.DataBlock, dbInt, strAdr, GetPLCStringByteArray(value.ToString()));
                }
                return true;
            }
            catch (Exception)
            {
                //写入异常
                S7Helper._S7Helper = null;
                return false;
            }
        }
        /// <summary>
        /// 获取西门子PLC字符串数组--String
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static byte[] GetPLCStringByteArray(string str)
        {
            byte[] value = Encoding.Default.GetBytes(str);
            byte[] head = new byte[2];
            head[0] = Convert.ToByte(254);
            head[1] = Convert.ToByte(str.Length);
            value = head.Concat(value).ToArray();
            return value;
        }
        /// <summary>
        /// 获取西门子PLC字符串数组--WString
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static byte[] GetPLCWStringByteArray(string str)
        {
            byte[] value = Encoding.BigEndianUnicode.GetBytes(str);
            byte[] head = BitConverter.GetBytes((short)508);
            byte[] length = BitConverter.GetBytes((short)str.Length);
            Array.Reverse(head);
            Array.Reverse(length);
            head = head.Concat(length).ToArray();
            value = head.Concat(value).ToArray();
            return value;
        }
        /// <summary>
        /// 去指定字符串中间字符
        /// </summary>
        /// <param name="sourse">字符串</param>
        /// <param name="startstr">首字符</param>
        /// <param name="endstr">尾字符</param>
        /// <returns></returns>
        public static string MidStrEx(string sourse, string startstr, string endstr)
        {
            string result = string.Empty;
            int startindex, endindex;
            try
            {
                startindex = sourse.IndexOf(startstr);
                if (startindex == -1)
                {
                    return result;
                }
                string tmpstr = sourse.Substring(startindex + startstr.Length);
                endindex = tmpstr.IndexOf(endstr);
                if (endindex == -1)
                {
                    return result;
                }
                result = tmpstr.Remove(endindex);
            }
            catch (Exception)
            {
            }
            return result;
        }
    }
}
