﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace EllaMaker.FTP.Converter
{
    public class FilenameToTypeIconConverter:IValueConverter
    {
        /// <summary>
        /// 将SVG矢量图转换为可用资源
        /// 用法<Image Source="{Binding ConverterParameter=pc_Button_search.svg, Converter={StaticResource SvgToXamlConverter}, Mode=OneWay}" />
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var para = value.ToString();
            string extension = para.Substring(para.LastIndexOf('.')+1);
            if (para.LastIndexOf('.') == -1)
                extension = "folder";
            DrawingImage svg_image = XConverter.SvgToXamlConverter.SvgToPic(extension);
            return svg_image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
