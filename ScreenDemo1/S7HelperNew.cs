using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microvast.Common.Vuex;
using Microvast.Model;
using Microvast.Service;
using Microvast.ViewModel;
using Microvast.Common.Utils;
using Sunny.UI;
using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System.Data;
using System.IO;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Reflection;
using Sunny.UI.Win32;
//*****************
// ScreenDemo1;
namespace ScreenDemo1
{
    public class S7HelperNew
    {
        SiemensS7Net PLC;
        public string PLCIP = string.Empty;
        public int PLCPort = 0;
        public List<DataValue> Datavalue = new List<DataValue>();
        public static Dictionary<int, OpcConnect> opcItems = new Dictionary<int, OpcConnect>();
        Thread thread;
        public bool PLCCon(string IP)
        {
            for (var i = 0; i < Form1.mainForm.dataRefenceList.Count; i++)
            {
                OpcConnect opcConnect = new OpcConnect();//建立OPC连接
                opcConnect.clientHandle = i;
                opcConnect.itemId = Form1.mainForm.dataRefenceList[i].PLC地址;//将itemid设置成表中的DB地址
                opcConnect.requestedDataType = short.Parse(Convert.ToString(Form1.mainForm.dataRefenceList[i].要求数据类型));
                opcConnect.signType = Convert.ToInt32(Form1.mainForm.dataRefenceList[i].功能码);
                opcConnect.noCheckType = Convert.ToInt32(Form1.mainForm.dataRefenceList[i].检查类型);
                opcItems.Add(i, opcConnect);//插入一个OPC连接
                DataValue datavalue = new DataValue();
                datavalue.p_trig = new P_TRIG();
                datavalue.signtype = Convert.ToInt32(Form1.mainForm.dataRefenceList[i].功能码);
                datavalue.datatype = short.Parse(Convert.ToString(Form1.mainForm.dataRefenceList[i].要求数据类型));
                datavalue.value = "";
                Datavalue.Add(datavalue);
            }
            if (Datavalue.Count > 0)
            {
                if (Form1.mainForm.PLC类型 == "1500")
                {
                    PLC = new SiemensS7Net(SiemensPLCS.S1500, IP);
                }
                else if (Form1.mainForm.PLC类型 == "1200")
                {
                    PLC = new SiemensS7Net(SiemensPLCS.S1200, IP);
                }
                OperateResult con = PLC.ConnectServer();
                if (con.IsSuccess)
                {
                    thread = new Thread(new ThreadStart(DataUpdata));
                    thread.IsBackground = true;
                    thread.Start();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        void DataUpdata()
        {
            while (true)
            {
                try
                {
                    for (int a = 0; a < opcItems.Count; a++)
                    {
                        if (opcItems[a].requestedDataType == 11)
                        {
                            bool result = PLC.ReadBool(opcItems[a].itemId).Content;
                            Datavalue[a].p_trig.CLK = result.ToString();
                            Datavalue[a].value = result.ToString();
                            if (result && Datavalue[a].p_trig.Q)
                            {
                                for (int i = 0; i < opcItems.Count; i++)
                                {
                                    if (opcItems[i].requestedDataType == 5)
                                    {
                                        // PLC.re
                                        float result1 = PLC.ReadFloat(opcItems[i].itemId).Content;
                                        Datavalue[i].p_trig.CLK = result1.ToString();
                                        Datavalue[i].value = result1.ToString();
                                    }
                                    if (opcItems[i].requestedDataType == 3)
                                    {
                                        short result2 = PLC.ReadInt16(opcItems[i].itemId).Content;
                                        Datavalue[i].p_trig.CLK = result2.ToString();
                                        Datavalue[i].value = result2.ToString();
                                    }
                                    if (opcItems[i].requestedDataType == 8)
                                    {
                                        string result3 = PLC.ReadString(opcItems[i].itemId).Content;
                                        Datavalue[i].p_trig.CLK = result3.ToString();
                                        Datavalue[i].value = result3.ToString();
                                    }
                                    if (opcItems[a].requestedDataType == 8196)
                                    {
                                        string[] adress = opcItems[a].itemId.Split('L');
                                        if (adress.Length == 2)
                                        {
                                            // float result1 = PLC.ReadFloat(adress[0]).Content;
                                            OperateResult<float[]> value1 = PLC.ReadFloat(adress[0], ushort.Parse(adress[1]));
                                            string str = string.Empty;
                                            for (int j = 0; j < value1.Content.Length; j++)
                                            {
                                                //数值只保留小数点后三位
                                                string val = decimal.Round(decimal.Parse(value1.Content[j].ToString(), System.Globalization.NumberStyles.Float), 3).ToString("f3");
                                                str += string.Format("{0},", val);//将数值加到字符串的最后
                                            }
                                            Datavalue[a].value = str != string.Empty ? str.Substring(0, str.Length - 1) : str;
                                        }
                                    }
                                }
                                ToSingTypeName(opcItems[a].signType);
                                HandleReadSignType(opcItems[a].signType);
                            }
                        }
                        if (opcItems[a].requestedDataType == 5)
                        {
                            float result = PLC.ReadFloat(opcItems[a].itemId).Content;
                            Datavalue[a].p_trig.CLK = result.ToString();
                            Datavalue[a].value = result.ToString();
                        }
                        if (opcItems[a].requestedDataType == 3)
                        {
                            short result = PLC.ReadInt16(opcItems[a].itemId).Content;
                            Datavalue[a].p_trig.CLK = result.ToString();
                            Datavalue[a].value = result.ToString();
                            if (Datavalue[a].p_trig.Q)
                            {
                                ToSingTypeName(opcItems[a].signType);
                                HandleReadSignType(opcItems[a].signType);
                            }
                        }
                        if (opcItems[a].requestedDataType == 8196)
                        {
                            string[] adress = opcItems[a].itemId.Split('L');
                            if (adress.Length == 2)
                            {
                                float result1 = PLC.ReadFloat(adress[0]).Content;
                                OperateResult<float[]> value1 = PLC.ReadFloat(adress[0], ushort.Parse(adress[1]));
                                string str = string.Empty;
                                for (int i = 0; i < value1.Content.Length; i++)
                                {
                                    //数值只保留小数点后三位
                                    string val = decimal.Round(decimal.Parse(value1.Content[i].ToString(), System.Globalization.NumberStyles.Float), 3).ToString("f3");
                                    str += string.Format("{0},", val);//将数值加到字符串的最后
                                }
                                Datavalue[a].value = str != string.Empty ? str.Substring(0, str.Length - 1) : str;
                            }
                        }
                        if (opcItems[a].requestedDataType == 8)
                        {
                            string result = PLC.ReadString(opcItems[a].itemId).Content;
                            Datavalue[a].p_trig.CLK = result.ToString();
                            Datavalue[a].value = result.ToString();
                        }
                        Thread.Sleep(100);
                    }
                }
                catch (Exception ex)
                {
                    string info = string.Format(ex.Message);
                    // addLogs(info, 2);
                    //log.Info(info);
                }
                Thread.Sleep(100);
            }
        }
        public string ToSingTypeName(int singType)
        {
            string singTypeName = "";
            switch (singType)
            {
                case 1:
                    singTypeName = "进入数据查询信号";
                    break;
                case 2:
                    singTypeName = "离开数据传输信号1";
                    break;
                case 3:
                    singTypeName = "NG数据传输信号";
                    break;
                case 4:
                    singTypeName = "激光打印信号";
                    break;
                case 5:
                    singTypeName = "返工模式信号";
                    break;
                case 7:
                    singTypeName = "离开数据传输信号2";
                    break;
                case 90:
                    singTypeName = "产品绑定条码开始";
                    break;
                case 96:
                case 97:
                    singTypeName = "抽检数据上传信号";
                    break;
                case 98:
                    singTypeName = "切换设备状态信号";
                    break;
                case 99:
                    singTypeName = "打印机信号";
                    break;
                case 10:
                    singTypeName = "读取电机1";
                    break;
                case 0:
                    break;
                case 95:
                    singTypeName = "离站数据查询！";
                    break;
                default:
                    if (singType >= 10 && singType <= 20)
                        singTypeName = "点检数据上传信号";
                    else if (singType > 20 && singType <= 30)
                        singTypeName = "抽检数据上传信号";
                    else
                        singTypeName = "signType:" + singType.ToString() + ":第三方设备信号";
                    break;
            }
            return singTypeName;
        }
        public void HandleReadSignType(int signType)
        {
            string str = string.Empty;
            foreach (DataValue item in Datavalue)
            {
                str += item == null ? string.Empty + "," : item.value + ",";
            }
            // log.Info("opc接收到的值数组:" + str.Substring(0, str.Length - 1));
            // 接收PLC请求的交互标志型号
            // 不在0 - 100 的范围， 不在则不处理 
            if (signType > 100 || signType < 0) return;
            // 日志记录PLC发送到OPC中的数据
            string datamsg = "";
            for (int a = 0; a < Datavalue.Count; a++)
            {
                datamsg = datamsg + Datavalue[a].value + ",";
            }
            // Info(signType, datamsg.Substring(0, datamsg.Length - 1));
            // 获取对应信号（0 - 100）的数据，处理数据
            // 1进入数据查询信号(检测上一站信息)  
            // 2离开数据传输信号   
            // 3NG数据传输  
            // 4激光打印信号  
            // 5返工模式   
            // 7右侧工位离开数据上传
            // 9右侧工位前道工序查询
            // 96抽检数据上传信号
            // 97抽检数据上传信号
            // 98设备状态切换
            // 99打印模式  
            // 6以后第三方
            // 8PLC报警信息
            var returnList = GetResultRead(signType);
            switch (signType)
            {
                case 2:
                    InsertSQL(returnList);
                    break;
                default:
                    if (signType >= 60 && signType < 90)
                    {
                        // new ProcessCurve().UploadThirdEquipmentPath(returnList, signType);
                    }
                    break;
            }
        }
        public Dictionary<string, OpcConnect> GetResultRead(int signType)
        {
            Dictionary<string, OpcConnect> readList = new Dictionary<string, OpcConnect>();
            try
            {
                //筛选数据，刷选的signType是信号的值加上100
                int checkSignType = signType + 100;
                for (var i = 0; i < Datavalue.Count; i++)//遍历序号数组
                {
                    var num = i;//获取序号
                    //当前值为浮点数组时
                    if (Datavalue[i].datatype == 8196)
                    {
                        string str = string.Empty;
                        foreach (var item in Datavalue[i].value)//遍历浮点数组中的每一个数值
                        {
                            //数值只保留小数点后三位
                            string val = decimal.Round(decimal.Parse(item.ToString(), System.Globalization.NumberStyles.Float), 3).ToString("f3");
                            str += string.Format("{0},", val);//将数值加到字符串的最后
                        }
                        //OPC通讯项接收到的消息不为空，则处理数据，否则即为空
                        opcItems[num].receiveMsg = str != string.Empty ? str.Substring(0, str.Length - 1) : str;
                    }
                    else//当数据不为浮点数组时，直接将通讯项消息赋值为当前结果值
                    {
                        opcItems[num].receiveMsg = Convert.ToString(Datavalue[i].value);
                    }
                    //当OPC信号类型=当前信息类型，或者两者都为98时
                    if (opcItems[num].signType == checkSignType ||
                        (opcItems[num].signType == 98 && signType == 98) ||
                        (opcItems[num].signType == 8 && signType == 8))
                    {
                        OpcConnect opcConnect = opcItems[num];
                        readList.Add(opcConnect.itemId, opcConnect);//将数据添加到结果值中
                    }
                }
                return readList;
            }
            catch (System.Exception ex)
            {
                //log.Error(ex.Message, ex);
                return readList;
            }
        }
        //TODO:
        private void InsertSQL(Dictionary<string, OpcConnect> opcConnect)
        {
            string OkFlag = "";
            string ngMsg = string.Empty;
            string barNo = string.Empty;
            string trayNo = string.Empty;
            string ngFlag = string.Empty;
            string plcFlag = string.Empty;
            string ngReason = string.Empty;
            int flag = 0;
            Dictionary<string, string> opcDict = new Dictionary<string, string>(); // 检测项数据
            Dictionary<string, string> checkDict = new Dictionary<string, string>();
            SecondCheckData ngDataList = new SecondCheckData();
            List<string> allCheckList = new List<string>();
            List<string> ngNoList = new List<string>();
            List<string> okNoList = new List<string>();
            Dictionary<string, LimitData> limitData = Form1.mainForm.limitDatas; // 查询防错表
            foreach (string key in opcConnect.Keys)
            {
                switch (opcConnect[key].noCheckType)
                {
                    case 1002://检查二维码是否有错误
                        barNo = IsBarNoError(opcConnect[key].receiveMsg);
                        break;
                    case 1007://获取工位结果值
                        if (opcConnect[key].receiveMsg == "1")//结果为1时，工件OK
                        {
                            OkFlag = "OK";
                            ngFlag = "OK";
                            plcFlag = "OK";
                            // plcFlag = "OK";
                        }
                        else if (opcConnect[key].receiveMsg == "2")//结果为2时，工件NG
                        {
                            OkFlag = "NG";
                            ngFlag = "NG";
                            plcFlag = "NG";
                            // plcFlag = "NG";
                        }
                        else//其他情况，工件为OPC返回结果值
                        {
                            OkFlag = opcConnect[key].receiveMsg;
                        }
                        break;
                    //case 1008://获取NG原因号
                    //    int reason = Convert.ToInt16(opcConnect[key].receiveMsg); // 从配置xml读取ng原因
                    //    ngReason = XmlHelper.ReadNGXML(true, reason).reason;
                    //    break;
                    case 1100://获取相关检测项数据
                        opcDict[opcConnect[key].itemId] = opcConnect[key].receiveMsg;
                        //  if(opcConnect[key].requestedDataType)
                        break;
                    default:
                        break;
                }
            }
            checkDict = this.ChangeSignToDataNo(Form1.mainForm.limitDatas, opcDict);
            // 获取综合判定，OK时进行二次检测
            if (ngFlag == "OK")
            {
                foreach (string a in checkDict.Values)
                {
                    if (a == "NG")
                    {
                        string info = "PLC数据前后矛盾！";
                        // Global.addLogs(info, 2);
                        // log.Info(info);
                        // TODO:Log文件
                        return;
                    }
                }
                ngDataList = this.CheckSecond(limitData, checkDict); // 二次检测获取 NG项相关数据
                flag = ngDataList.flag;
                ngMsg = ngDataList.ngMsg;
                List<string> itemList = ngDataList.ngDataList;
                // 存在检测项漏传或NG则更新综合判定为NG
                if (itemList.Count > 0)
                {
                    ngFlag = "NG";
                }
                // 所有检测结果项
                foreach (string key in limitData.Keys)
                {
                    if (limitData[key].qualified_item != null)
                    {
                        allCheckList.Add(limitData[key].qualified_item);
                    }
                }
                // 根据检测项data_no获取对应的结果项的data_no
                foreach (string key in limitData.Keys)
                {
                    foreach (string data_no in itemList)
                    {
                        // limiteSetup表存在对应的结果项关系
                        if (data_no == key && limitData[key].qualified_item != null)
                        {
                            ngNoList.Add(limitData[key].qualified_item);
                        }
                    }
                }
                okNoList = allCheckList.Except(ngNoList).ToList(); // 合格检测项
            }
            else
            {
                bool OKDO = false;
                foreach (string a in checkDict.Values)
                {
                    if (a == "NG")
                    {
                        OKDO = true;
                    }
                }
                if (!OKDO)
                {
                    string info = "PLC数据前后矛盾！";
                    // Global.addLogs(info, 2);
                    // log.Info(info);
                    return;
                }
                // PLC传入的综合判定为NG时，也要记录NG原因
                ngDataList = this.CheckSecond(limitData, checkDict, 1); // 二次检测获取 NG项相关数据
                flag = ngDataList.flag;
                ngMsg = ngDataList.ngMsg;
                List<string> itemList = ngDataList.ngDataList; // ng结果项
                // 存在检测项漏传或NG则更新综合判定为NG
                if (itemList.Count > 0)
                {
                    ngFlag = "NG";
                }
                // 所有检测结果项
                foreach (string key in limitData.Keys)
                {
                    if (limitData[key].qualified_item != null)
                    {
                        allCheckList.Add(limitData[key].qualified_item);
                    }
                }
            }
            MicroVastProcessProperty microVastProcessProperty = new MicroVastProcessProperty();
            Type t = microVastProcessProperty.GetType();
            PropertyInfo[] propertyList = t.GetProperties(); // 反射获取实体类字段
            microVastProcessProperty.bar_no = barNo;
            microVastProcessProperty.ok_flag = ngFlag;
            microVastProcessProperty.ng_msg = ngMsg;
            microVastProcessProperty.process_no = Form1.mainForm.当前工序;
            microVastProcessProperty.flag = 0;
            microVastProcessProperty.item_no = null;
            //   microVastProcessProperty.vou_no = Form1.mainForm.;
            microVastProcessProperty.eqpt_loc_id = null;
            microVastProcessProperty.major_state = null;
            microVastProcessProperty.second_state = null;
            microVastProcessProperty.aux_state = null;
            microVastProcessProperty.do_time = DateTime.Now;
            microVastProcessProperty.user_id = Form1.mainForm.工号;
            foreach (PropertyInfo item in propertyList)
            {
                string name = item.Name;
                foreach (string key in checkDict.Keys)
                {
                    if (name == key) item.SetValue(microVastProcessProperty, checkDict[key]);
                }
            }
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            int res = sqlSugarServerHelper.db.Insertable(microVastProcessProperty).ExecuteCommand();
            if (res == 1)
            {

                write(2, false);
            }
            else
            {
            }
        }
        public static string IsBarNoError(string barNo)
        {
            if (barNo.ToUpper().Equals("ERROR") || barNo.ToUpper().Equals("\"ERROR\""))
            {
                barNo = string.Format("ERROR_{0}", DateTime.Now.ToString("yyyyMMddHHmmssms"));
            }
            return barNo;
        }
        /// <summary>
        /// opc解析的检测项.PLC地址转为data_no,并根据数据类型转换结果项
        /// </summary>
        /// <param name="limitData">防错表相关信息</param>
        /// <param name="opcDict">opc解析的检测项</param>
        /// <returns></returns>
        public Dictionary<string, string> ChangeSignToDataNo(Dictionary<string, LimitData> limitData, Dictionary<string, string> opcDict)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (string key in limitData.Keys)
            {
                foreach (string check in opcDict.Keys)
                {
                    if (check == limitData[key].PLC地址)
                    //      if (check == Global.limitData[key].PLC地址)
                    {
                        string dataNo = limitData[key].data_no; // 检测项data_no
                        int dataType = limitData[key].data_type; // 数据类型 1：OK/NG类型；2：数值类型；3：字符类型 4：正/反类型 5：有/无类型
                        string val = opcDict[check]; // 检测项的值
                                                     //  log.Info(check + ":" + val);
                                                     // 检测结果项类型为1 (1、OK;2、NG)
                        if (dataType == 1 && val == "1")
                        {
                            val = "OK";
                        }
                        else if (dataType == 1 && val == "2")
                        {
                            val = "NG";
                        }
                        // 检测结果项类型为4 (1、正;2、反)
                        if (dataType == 4 && val == "1")
                        {
                            val = "正";
                        }
                        else if (dataType == 4 && val == "2")
                        {
                            val = "反";
                        }
                        // 检测结果项类型为5 (1、有;2、无)
                        if (dataType == 5 && val == "1")
                        {
                            val = "有";
                        }
                        else if (dataType == 5 && val == "2")
                        {
                            val = "无";
                        }
                        //检测结果项类型为2（数值类型）
                        if (dataType == 2 && !string.IsNullOrWhiteSpace(limitData[key].data_unit))
                        {
                            int decimalType = limitData[key].data_unit.Count(item => item == '0');
                            string str = decimalType == 0 ? string.Empty : string.Format("f{0}", decimalType.ToString());
                            try
                            {
                                val = decimal.Round(decimal.Parse(val, System.Globalization.NumberStyles.Float), decimalType).ToString(str);
                            }
                            catch
                            {
                                //log.Warn("检测数据非数值，无法保留小数位数");
                            }
                        }
                        else if (dataType == 2 && string.IsNullOrWhiteSpace(limitData[key].data_unit) && limitData[key].length_check == "否")
                        {
                            // 检测类型为2，length_check为否，且没有设置data_unit的默认保留两位小数
                            try
                            {
                                val = decimal.Round(decimal.Parse(val, System.Globalization.NumberStyles.Float), 2).ToString("f2");
                            }
                            catch
                            {
                                // log.Warn("检测数据非数值，无法保留小数位数");
                            }
                        }
                        result[dataNo] = val;
                        break;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 数据漏传和传错(二次防错)
        /// </summary>
        /// <param name="checkList">上位机解析的plc检测项数据</param>
        /// <returns>NG的检测项序号和NG原因</returns>
        public SecondCheckData CheckSecond(Dictionary<string, LimitData> limitData, Dictionary<string, string> checkList, int status = 0)
        {
            SecondCheckData secondCheckData = new SecondCheckData();
            List<string> ngNoList = new List<string>();
            string ngMsg = string.Empty;
            string reasonMsg = status == 1 ? "_PLC;" : "_上位机;";
            // 1.数据漏传检测
            foreach (string key in limitData.Keys)
            {
                int existFlag = 0; // 存在标识 0、不存在 1、存在
                foreach (string dataNo in checkList.Keys)
                {
                    // 检测项的值为null或为空,则数据漏传
                    if (key == dataNo)
                    {
                        existFlag = 1;
                        // 检测项为空或null
                        if (checkList[dataNo] == null || checkList[dataNo] == string.Empty)
                        {
                            ngNoList.Add(key); // 添加NG检测项
                            ngMsg += limitData[key].data_name + reasonMsg; // 添加NG原因信息
                        }
                    }
                }
                // 检测项缺失漏传
                if (existFlag == 0)
                {
                    ngNoList.Add(key); // 添加NG检测项
                    ngMsg += limitData[key].data_name + reasonMsg; // 添加NG原因信息
                }
            }
            // 如果数据存在漏传，则直接返回漏传的检测项和NG原因
            if (ngNoList.Count > 0 && status == 0)
            {
                secondCheckData.flag = 1;
                secondCheckData.ngMsg = ngMsg == string.Empty ? ngMsg : ngMsg.Substring(0, ngMsg.Length - 1);
                secondCheckData.ngDataList = ngNoList;
                return secondCheckData;
            }
            if (status == 0) // 只有plc传来的综合判定为OK时才做检测项校验
            {
                // 2.如果没有漏传,判定是否需要检测字符串长度
                foreach (string key in checkList.Keys)
                {
                    // 需要检测长度
                    if (limitData[key].length_check == "是")
                    {
                        // 防错表需要检测长度不等于plc解析数据的长度
                        if (limitData[key].lower_limit != checkList[key].Length)
                        {
                            ngNoList.Add(key); // 添加NG检测项
                            ngMsg += limitData[key].data_name + reasonMsg; // 添加NG原因信息
                        }
                    }
                    else if (limitData[key].length_check == "否")
                    { // 需要检测值的范围
                        try
                        {
                            double val = Convert.ToDouble(checkList[key]);
                            if (val < limitData[key].lower_limit || val > limitData[key].upper_limit)
                            {
                                ngNoList.Add(key); // 添加NG检测项
                                ngMsg += limitData[key].data_name + reasonMsg; // 添加NG原因信息
                            }
                        }
                        catch (Exception ex)
                        {
                            //log.Error("检测值类型转换失败:" + ex.Message, ex);
                        }
                    }
                }
            }
            else
            {
                foreach (string key in checkList.Keys)
                {
                    // plc传来的检测项NG记录NG原因
                    if (checkList[key] == "NG")
                    {
                        ngNoList.Add(key); // 添加NG结果项
                        ngMsg += limitData[key].data_name + reasonMsg; // 添加NG原因信息
                    }
                }
            }
            secondCheckData.flag = 2;
            secondCheckData.ngMsg = ngMsg == string.Empty ? ngMsg : ngMsg.Substring(0, ngMsg.Length - 1);
            secondCheckData.ngDataList = ngNoList;
            return secondCheckData;
        }
        public void PLC_write(string adress, short datatype, object val)
        {
            if (datatype == 11)
                PLC.Write(adress, bool.Parse(val.ToString()));
            else if (datatype == 3)
                PLC.Write(adress, short.Parse(val.ToString()));
            else if (datatype == 5)
                PLC.Write(adress, float.Parse(val.ToString()));
            else if (datatype == 8)
                PLC.Write(adress, val.ToString());
            else if (datatype == 8196)
                PLC.Write(adress, val.ToString());
            else
            {
            }
        }
        public void write(int signType, object val, string noCheckType = "")
        {
            if (opcItems != null && opcItems.Count != 0)
            {
                foreach (int i in opcItems.Keys)
                {
                    // 没有检测类型，则只要检测信号类型相同
                    if (opcItems[i].signType == signType && noCheckType == string.Empty)
                    {
                        PLC_write(opcItems[i].itemId, opcItems[i].requestedDataType, val);
                        break;
                    }
                    // 信号类型相同，且检测类型不为空,则需要noCheckType为1002
                    if (opcItems[i].signType == signType && noCheckType != string.Empty && opcItems[i].noCheckType.ToString() == noCheckType)
                    {
                        PLC_write(opcItems[i].itemId, opcItems[i].requestedDataType, val);
                        break;
                    }
                    if (opcItems[i].signType == signType && noCheckType != string.Empty && opcItems[i].noCheckType.ToString() == noCheckType)
                    {
                        PLC_write(opcItems[i].itemId, opcItems[i].requestedDataType, val);
                        break;
                    }
                }
            }
        }
    }
    public class LimitData
    {
        public int id { get; set; }
        public string process_no { get; set; }
        public string data_no { get; set; }
        public double? upper_limit { get; set; }
        public double? lower_limit { get; set; }
        public string qualified_item { get; set; }
        public string length_check { get; set; }
        public string PLC地址 { get; set; }
        public string data_name { get; set; }
        public int data_type { get; set; }
        public string data_desc { get; set; }
        public string data_value { get; set; }
        public string data_unit { get; set; }
    }
    public class DataValue
    {
        public string value { set; get; }
        public int datatype { set; get; }
        public int signtype { set; get; }
        public P_TRIG p_trig { set; get; }
    }
    public class OpcConnect
    {
        /// <summary>
        /// OPC中的itemId.PLC地址)
        /// </summary>
        public string itemId { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int clientHandle { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public short requestedDataType { get; set; }
        /// <summary>
        /// 信号类型
        /// </summary>
        public int signType { get; set; }
        /// <summary>
        /// 接收到的信息
        /// </summary>
        public string receiveMsg { get; set; }
        /// <summary>
        /// 非检测项标识
        /// </summary>
        public int noCheckType { get; set; }
    }
    public class SecondCheckData
    {
        public int flag { get; set; } // 1、数据漏传NG 2、数据校验NG
        public string ngMsg { get; set; }
        public List<string> ngDataList { get; set; }
    }
}
