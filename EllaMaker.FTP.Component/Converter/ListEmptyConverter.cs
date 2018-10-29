using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace EllaMaker.FTP.Component.Converter
{
    /// <summary>
    /// ListNotEmptyConverter 的摘要说明
    /// 创建人：张天奇
    /// 创建时间：2018/8/9 星期四 下午 3:44:56
    /// </summary>
 

    public class ListNotEmptyVisiableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && double.Parse(value.ToString())>0? Visibility.Visible:Visibility.Collapsed;

        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
    public class ListEmptyVisiableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null || double.Parse(value.ToString()) == 0 ? Visibility.Visible:Visibility.Collapsed;

        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
