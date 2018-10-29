using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EllaMaker.FTP.Component
{
    /// <summary>
    /// WatermarkTextBox.xaml 的交互逻辑
    /// </summary>
    public class WatermarkTextBox : TextBox
    {
        public WatermarkTextBox()
        {
            base.DefaultStyleKey = typeof(WatermarkTextBox);
        }
        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.RegisterAttached("Watermark",
                                                 typeof(string),
                                                 typeof(WatermarkTextBox),
                                                 new PropertyMetadata(""));
        public string Watermark
        {
            get { return (string)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

    
        public static readonly DependencyProperty WatermarkOpcityProperty = DependencyProperty.RegisterAttached("WatermarkOpcity",
                                             typeof(double),
                                             typeof(WatermarkTextBox),
                                             new PropertyMetadata(0.3));
        public double WatermarkOpcity
        {
            get { return (double)GetValue(WatermarkOpcityProperty); }
            set { SetValue(WatermarkOpcityProperty, value); }
        }
    }
}
