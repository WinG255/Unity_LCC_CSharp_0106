using UnityEngine;

namespace WinG.Tools
{
    /// <summary>
    /// 輸出訊息工具
    /// </summary>
    public class LogSystem
    {
        /// <summary>
        /// 輸出訊息並指定顏色
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string LogWithColor(string message,string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log (result );    
            return result ;
        }

        public static string LogWithColor(object message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }
    }
}

