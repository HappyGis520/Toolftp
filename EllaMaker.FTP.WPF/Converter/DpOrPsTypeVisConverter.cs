﻿using EllaMaker.FTP.Model;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace EllaMaker.FTP.Converter
{
    public class DpOrPsTypeVisConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility deFaultVis = Visibility.Collapsed;
            Visibility otherVis = Visibility.Visible;
            if (parameter != null)
            {
                deFaultVis = Visibility.Visible;
                otherVis = Visibility.Collapsed;
            }

            PsAndDeptItemtype val = (PsAndDeptItemtype) value;
            switch (val)
            {
                case PsAndDeptItemtype.Dept:
                    return deFaultVis;
                default:
                    return otherVis;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
