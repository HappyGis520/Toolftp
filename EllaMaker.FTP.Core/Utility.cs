/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： Utility.cs
 * * 功   能：  
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-08-31 14:26:00
 * * 修改记录： 
 * * 日期时间： 2018-08-31 14:26:00  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Collections;
using System.Web;

namespace EllaMaker.FTP.Core
{
    public static class Utility
    {

        public static string URL = string.Empty;

        /// <summary>
        /// 枚举转字符
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EnumToString(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                   (DescriptionAttribute[])fi.GetCustomAttributes(
                  typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        /// <summary>
        /// 此类必须标注可序列化属性[Serializable]
        /// </summary>
        public static class DeepCopy
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public static object DeepCopyObject(object obj)
            {
                //浅复制
                //this.MemberwiseClone();

                var ms = new MemoryStream();
                var bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                ms.Seek(0, 0);
                var value = bf.Deserialize(ms);
                ms.Close();
                return value;
            }
            public static T DeepCopyObject<T>(T obj)
            {
                using (var ms = new MemoryStream())
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(ms, obj);
                    ms.Position = 0;
                    return (T)formatter.Deserialize(ms);
                }
            }

        }

        public static int TimespaneMinutes(DateTime StartTime, DateTime EndTime)
        {
            return (int)Math.Round(((EndTime - StartTime).TotalMinutes), MidpointRounding.AwayFromZero);
        }

        #region json

        /// <summary>
        /// 将对象序列化为JSON格式
        /// </summary>
        /// <param name="o">对象</param>
        /// <returns>json字符串</returns>
        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;
        }

        /// <summary>
        /// 解析JSON字符串生成对象实体
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json字符串(eg.{"ID":"112","Name":"石子儿"})</param>
        /// <returns>对象实体</returns>
        public static T DeserializeJsonToObject<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
            T t = o as T;
            return t;
        }

        /// <summary>
        /// 解析JSON数组生成对象实体集合
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
        /// <returns>对象实体集合</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }

        /// <summary>
        /// 反序列化JSON到给定的匿名对象.
        /// </summary>
        /// <typeparam name="T">匿名对象类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <param name="anonymousTypeObject">匿名对象</param>
        /// <returns>匿名对象</returns>
        public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
        {
            T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject);
            return t;
        }

        #endregion


        public static string ReplaceInviadCharInFileName(string newname)
        {
            foreach (char invalidChar in Path.GetInvalidFileNameChars())
            {
                newname.Replace(invalidChar.ToString(), string.Empty);
            }
            return newname;
        }
    }
}