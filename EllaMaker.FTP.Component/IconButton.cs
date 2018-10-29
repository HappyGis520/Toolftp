using EllaMaker.FTP.Component.Converter;
using EllaMaker.FTP.Component.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// 支持图像与路径的按钮
    /// </summary>
    public  class IconButton : Button
    {
        public IconButton()
        {
            base.DefaultStyleKey = typeof(IconButton);
        }

        #region 图标类型
        public static readonly DependencyProperty SourceTypeProperty = DependencyProperty.RegisterAttached("SourceType",
                                                   typeof(ImageSourceType),
                                                   typeof(IconButton),
                                                   new PropertyMetadata(ImageSourceType.Image));
        /// <summary>
        /// 图标类型
        /// </summary>
        public ImageSourceType SourceType
        {
            get { return (ImageSourceType)GetValue(SourceTypeProperty); }
            set { SetValue(SourceTypeProperty, value); }
        }
        #endregion

        #region 按钮圆角

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius",
                                                     typeof(CornerRadius),
                                                     typeof(IconButton),
                                                     new PropertyMetadata(new CornerRadius(2.0)));
        /// <summary>
        /// 按钮圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        #endregion

        #region 显示图标
        public static readonly DependencyProperty SourceProperty = DependencyProperty.RegisterAttached("Source",
                                             typeof(string),
                                             typeof(IconButton),
                                             new PropertyMetadata(string.Empty, OnSourceValueChanged));

        private static void OnSourceValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            string result = e.NewValue?.ToString();
            if (!string.IsNullOrEmpty(result))
            {
                bool IsPath = result.First() == 'M' && result.Last() == 'z';
                ((IconButton)d).SourceType = IsPath ? ImageSourceType.Path : ImageSourceType.Image;
            }

        }
        /// <summary>
        /// 显示图标 支持路径与图像
        /// </summary>
        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        #endregion

        #region Content停靠方向
        public static readonly DependencyProperty ContentDockProperty = DependencyProperty.RegisterAttached("ContentDock",
                                             typeof(Dock),
                                             typeof(IconButton),
                                             new PropertyMetadata(Dock.Right));
        /// <summary>
        /// 保留的按钮Content停靠方向
        /// </summary>
        public Dock ContentDock
        {
            get { return (Dock)GetValue(ContentDockProperty); }
            set { SetValue(ContentDockProperty, value); }
        }
        #endregion

        #region 图标旋转角度

        public static readonly DependencyProperty
            AngleProperty = DependencyProperty.RegisterAttached("Angle",
                                                   typeof(double),
                                                   typeof(IconButton),
                                                   new PropertyMetadata(0.0));
        /// <summary>
        /// 图标旋转角度
        /// </summary>
        public double Angle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        #endregion
    }
}
