using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace MyProject_Home.Common
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// 转化整数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ObjToInt32(this object obj)
        {
            int result = 0;
            if (obj != null)
            {
                int.TryParse(obj.ToString(), out result);
            }
            return result;
        }

        /// <summary>
        /// 将字符串转换为浮点型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static float ToFloat(this string str)
        {
            float result = 0;
            if (!string.IsNullOrEmpty(str))
            {
                float.TryParse(str, out result);
            }
            return result;
        }

        /// <summary>
        /// 将小数值舍入到最接近的整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this float value, int decimals = 0)
        {
            return decimal.Round((decimal)value, decimals);
        }


        /// <summary>
        /// 小数上取整
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToDecimalCell(this object value)
        {
            var r = Math.Ceiling(Convert.ToDecimal(value));
            return r;
        }

        /// <summary>
        /// 小数上取整
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ToDoubleCell(this object value)
        {
            var r = Math.Ceiling(Convert.ToDouble(value));
            return r;
        }


        /// <summary>
        /// 将小数值舍入到最接近的整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this object value, int decimals = 0)
        {
            return decimal.Round(Convert.ToDecimal(value), decimals, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 将字符串转换为日期类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string str)
        {
            DateTime dt = DateTime.MinValue;
            if (!string.IsNullOrEmpty(str))
            {
                DateTime.TryParse(str, out dt);
            }
            return dt;
        }

        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            HashSet<TKey> hashSet = new HashSet<TKey>();
            foreach (T element in source)
            {
                if (hashSet.Add(keySelector(element)))
                {
                    yield return element;
                }
            }

        }

        public static T TryParse<T>(this object str)
        {
            var type = typeof(T);
            T value = default(T);
            var parseMethod = type.GetMethod("TryParse",
                BindingFlags.Public | BindingFlags.GetField | BindingFlags.InvokeMethod | BindingFlags.Static, Type.DefaultBinder,
                new Type[] { typeof(string), type.MakeByRefType() },
                new ParameterModifier[] { new ParameterModifier(2) });
            if (parseMethod != null)
            {
                var parameters = new object[] { str, Activator.CreateInstance(type) };
                parseMethod.Invoke(null, parameters);
                value = (T)parameters[1];
            }
            return value;
        }

        /// <summary>
        /// 转化整数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static long ObjToLong(this object obj)
        {
            long result = 0;
            if (obj != null)
            {
                long.TryParse(obj.ToString(), out result);
            }
            return result;
        }


        /// <summary>
        /// 转化整数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static float ObjToFloat(this object obj)
        {
            float result = 0;
            if (obj != null)
            {
                float.TryParse(obj.ToString(), out result);
            }
            return result;
        }
        
        public static IEnumerable<T> Clone<T>(this IEnumerable<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        /// <summary>
        /// 格式时间
        /// </summary>
        /// <param name="dt">转换的时间,时间格式</param>
        /// <param name="format">例如 yyyy-MM-dd  HH:mm:ss</param>
        /// <returns></returns>
        public static string FormatDateToString(this DateTime dt, string format = "yyyy-MM-dd  HH:mm:ss")
        {
            try
            {
                if (dt == null)
                {
                    return string.Empty;
                }
                return dt.ToString(format, DateTimeFormatInfo.InvariantInfo);
            }
            catch (Exception)
            {
                return Convert.ToString(dt);
            }

        }
        /// <summary>
        /// 格式时间
        /// </summary>
        /// <param name="dt">转换的时间,时间格式</param>
        /// <param name="format">例如 yyyy-MM-dd  HH:mm:ss</param>
        /// <returns></returns>
        public static string FormatDateToString(this string dt, string format = "yyyy-MM-dd  HH:mm:ss")
        {
            try
            {
                if (dt == null)
                {
                    return string.Empty;
                }
                return Convert.ToDateTime(dt).ToString(format, DateTimeFormatInfo.InvariantInfo);
            }
            catch (Exception)
            {
                return Convert.ToString(dt);
            }

        }
        /// <summary>
        /// <para>将 URL 中的参数名称/值编码为合法的格式。</para>
        /// <para>可以解决类似这样的问题：假设参数名为 tvshow, 参数值为 Tom&Jerry，如果不编码，可能得到的网址： http://a.com/?tvshow=Tom&Jerry&year=1965 编码后则为：http://a.com/?tvshow=Tom%26Jerry&year=1965 </para>
        /// <para>实践中经常导致问题的字符有：'&', '?', '=' 等</para>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string AsUrlData(this string data)
        {
            return Uri.EscapeDataString(data);
        }
    }
}
