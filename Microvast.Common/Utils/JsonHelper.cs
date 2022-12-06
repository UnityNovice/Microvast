namespace Microvast.Common.Utils
{
    using System;
    using Newtonsoft.Json;
    /// <summary>
    /// Json处理工具类
    /// </summary>
    public class JsonHelper
    {
        /// <summary>
        /// json反序列化
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="input">输入</param>
        /// <returns>输出</returns>
        public static object JsonDes<T>(string input)
        {
            object result = new object();
            try
            {
                result = JsonConvert.DeserializeObject<T>(input);
            }
            catch (Exception ex)
            {
                //LogHelper.CreateLogger(typeof(JsonHelper)).Error(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// json序列化
        /// </summary>
        /// <param name="obj">输入</param>
        /// <returns>输出</returns>
        public static string Json(object obj)
        {
            string result = string.Empty;
            try
            {
                result = JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                //LogHelper.CreateLogger(typeof(JsonHelper)).Error(ex.Message);
            }
            return result;
        }
    }
}