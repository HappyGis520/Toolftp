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
    /// SearchTextBox.xaml 的交互逻辑
    /// </summary>
    public  class SearchTextBox : TextBox
    {
        public SearchTextBox()
        {
            this.DefaultStyleKey = typeof(SearchTextBox);
        }
        
        #region 图标
        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached("Icon",
                                                typeof(object),
                                                typeof(SearchTextBox),
                                                new PropertyMetadata(null));
        /// <summary>
        /// 图标
        /// </summary>
        public object Icon
        {
            get { return GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        #endregion

        #region 图标停靠方向
        public static readonly DependencyProperty IconDockProperty = DependencyProperty.RegisterAttached("IconDock",
                                           typeof(Dock),
                                           typeof(SearchTextBox),
                                           new PropertyMetadata(Dock.Right));
        /// <summary>
        /// 图标停靠方向
        /// </summary>
        public Dock IconDock
        {
            get { return (Dock)GetValue(IconDockProperty); }
            set { SetValue(IconDockProperty, value); }
        }
        #endregion


        #region 文本框背景

        public static readonly DependencyProperty TextBackgroundProperty = DependencyProperty.RegisterAttached("TextBackground",
                                              typeof(string),
                                              typeof(SearchTextBox),
                                             new PropertyMetadata("White"));
        /// <summary>
        /// 文本框背景
        /// </summary>
        public string TextBackground
        {
            get { return (string)GetValue(TextBackgroundProperty); }
            set { SetValue(TextBackgroundProperty, value); }
        }
        #endregion

        #region 文本框宽度
        public static readonly DependencyProperty TextWidthProperty = DependencyProperty.RegisterAttached("TextWidth",
                                           typeof(double),
                                           typeof(SearchTextBox),
                                           new PropertyMetadata(double.NaN));
        /// <summary>
        /// 文本框宽度
        /// </summary>
        public double TextWidth
        {
            get { return (double)GetValue(TextWidthProperty); }
            set { SetValue(TextWidthProperty, value); }
        }
        #endregion

        #region 文本框水印
        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.RegisterAttached("Watermark",
                                                typeof(string),
                                                typeof(SearchTextBox),
                                                new PropertyMetadata(""));
        /// <summary>
        /// 文本框水印
        /// </summary>
        public string Watermark
        {
            get { return (string)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }
        #endregion

        #region 文本框水印透明度
        public static readonly DependencyProperty WatermarkOpcityProperty = DependencyProperty.RegisterAttached("WatermarkOpcity",
                                             typeof(double),
                                             typeof(SearchTextBox),
                                             new PropertyMetadata(0.3));
        /// <summary>
        /// 文本框水印透明度
        /// </summary>
        public double WatermarkOpcity
        {
            get { return (double)GetValue(WatermarkOpcityProperty); }
            set { SetValue(WatermarkOpcityProperty, value); }
        }
        #endregion
    }
}
