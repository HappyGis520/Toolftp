using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace EllaMaker.FTP.Component.Converter
{
    /// <summary>
    /// EnumToVisiableConverter 的摘要说明
    /// 创建人：张天奇
    /// 创建时间：2018/7/30 星期一 下午 5:33:36
    /// </summary>
    /// <summary>
    ///  Value枚举是否和参数枚举相同
    /// </summary>
    public class EnumToVisiableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //  int data = value;
            string datastr = parameter.ToString();
            return value.ToString() == datastr ? Visibility.Visible : Visibility.Collapsed;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
