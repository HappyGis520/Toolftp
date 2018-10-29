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
    /// ContainsVisiableConverter 的摘要说明
    /// 创建人：张天奇
    /// 创建时间：2018/8/9 星期四 下午 6:11:38
    /// </summary>
    public class ContainsVisiableConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values == null || values.Length != 2) return Visibility.Collapsed;

            return values[0].ToString().Contains(values[1].ToString().Trim())?Visibility.Visible:Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
          return  null;
        }
        

       
    }
}
