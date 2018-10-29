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
    /// BoolToVisibilityReverseConverter 的摘要说明
    /// 创建人：张天奇
    /// 创建时间：2018/8/1 星期三 上午 11:18:16
    /// </summary>
    /// <summary>
    /// 布尔转换为Visibility 反向
    /// </summary>
    public class BoolToVisibilityReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value ? Visibility.Visible : Visibility.Collapsed;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Visibility)value == Visibility.Visible ? false : true;
        }
    }
}
