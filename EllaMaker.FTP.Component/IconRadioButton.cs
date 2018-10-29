using EllaMaker.FTP.Component.Enum;
using System;
using System.Collections.Generic;
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
    /// IconRadioButton.xaml 的交互逻辑
    /// </summary>
    public  class IconRadioButton : RadioButton
    {
        public IconRadioButton()
        {
            base.DefaultStyleKey = typeof(IconRadioButton);
        }
        #region 选中图标类型
        public static readonly DependencyProperty CheckSourceTypeProperty = DependencyProperty.RegisterAttached("CheckSourceType",
                                                   typeof(ImageSourceType),
                                                   typeof(IconRadioButton),
                                                   new PropertyMetadata(ImageSourceType.Path));
        /// <summary>
        /// 图标类型
        /// </summary>
        public ImageSourceType CheckSourceType
        {
            get { return (ImageSourceType)GetValue(CheckSourceTypeProperty); }
            set { SetValue(CheckSourceTypeProperty, value); }
        }
        #endregion
        #region 未选中图标类型
        public static readonly DependencyProperty UnCheckSourceTypeProperty = DependencyProperty.RegisterAttached("UnCheckSourceType",
                                                   typeof(ImageSourceType),
                                                   typeof(IconRadioButton),
                                                   new PropertyMetadata(ImageSourceType.Path));
        /// <summary>
        /// 图标类型
        /// </summary>
        public ImageSourceType UnCheckSourceType
        {
            get { return (ImageSourceType)GetValue(UnCheckSourceTypeProperty); }
            set { SetValue(UnCheckSourceTypeProperty, value); }
        }
        #endregion
        #region 按钮圆角

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius",
                                                     typeof(CornerRadius),
                                                     typeof(IconRadioButton),
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


        #region 选中显示图标
        public static readonly DependencyProperty CheckSourceProperty = DependencyProperty.RegisterAttached("CheckSource",
                                             typeof(string),
                                             typeof(IconRadioButton),
                                             new PropertyMetadata("M23.100006,9.5000782L25.299988,12.100105 13.399994,22.500186 6.7000122,14.700118 9.3000183,12.500103 13.800018,17.700143z M3.2000122,1.6000195C2.3000183,1.6000192,1.6000061,2.3000219,1.6000061,3.2000232L1.6000061,28.800241C1.6000061,29.700242,2.3000183,30.40026,3.2000122,30.40026L28.799988,30.40026C29.700012,30.40026,30.400024,29.700242,30.400024,28.800241L30.400024,3.2000232C30.400024,2.3000219,29.700012,1.6000192,28.799988,1.6000195z M3.2000122,0L28.700012,0C30.5,-1.5262231E-08,32,1.5000123,32,3.2000232L32,28.700233C32,30.500251,30.5,31.900271,28.799988,31.900271L3.2000122,31.900271C1.5,32.000262,0,30.500251,0,28.800241L0,3.2000232C0,1.5000123,1.5,-1.5262231E-08,3.2000122,0z", OnCheckSourceValueChanged));

        private static void OnCheckSourceValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            string result = e.NewValue?.ToString();
            if (!string.IsNullOrEmpty(result))
            {
                bool IsPath = result.First() == 'M' && result.Last() == 'z';
                ((IconRadioButton)d).CheckSourceType = IsPath ? ImageSourceType.Path : ImageSourceType.Image;
            }

        }
        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public string CheckSource
        {
            get { return (string)GetValue(CheckSourceProperty); }
            set { SetValue(CheckSourceProperty, value); }
        }
        #endregion

        #region 未选中显示图标

        public static readonly DependencyProperty UnCheckSourceProperty = DependencyProperty.RegisterAttached("UnCheckSource",
                                          typeof(string),
                                          typeof(IconRadioButton),
                                          new PropertyMetadata("M3.2000122,1.6000124C2.2999878,1.6000124,1.5999756,2.3000191,1.5999756,3.2000285L1.5999756,28.800246C1.5999756,29.700255,2.2999878,30.400258,3.2000122,30.400258L28.799988,30.400258C29.700012,30.400258,30.400024,29.700255,30.400024,28.800246L30.400024,3.2000285C30.400024,2.3000191,29.700012,1.6000124,28.799988,1.6000124z M3.2000122,0L28.700012,0C30.5,1.800563E-07,32,1.5000131,32,3.2000285L32,28.700248C32,30.500258,30.5,31.900271,28.799988,31.900271L3.2000122,31.900271C1.5,32.00027,0,30.500258,0,28.800246L0,3.2000285C0,1.5000131,1.5,1.800563E-07,3.2000122,0z", OnUnCheckSourceValueChanged));

        private static void OnUnCheckSourceValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            string result = e.NewValue?.ToString();
            if (!string.IsNullOrEmpty(result))
            {
                bool IsPath = result.First() == 'M' && result.Last() == 'z';
                IconRadioButton element = (IconRadioButton)d;
                element.UnCheckSourceType = IsPath ? ImageSourceType.Path : ImageSourceType.Image;
            }

        }
        /// <summary>
        /// 未选中显示图标 支持路径与图像
        /// </summary>
        public string UnCheckSource
        {
            get { return (string)GetValue(UnCheckSourceProperty); }
            set { SetValue(UnCheckSourceProperty, value); }
        }


        #endregion

        #region 选中ToolTip
        public static readonly DependencyProperty CheckToolTipProperty = DependencyProperty.RegisterAttached("CheckToolTip",
                                           typeof(string),
                                           typeof(IconRadioButton),
                                           new PropertyMetadata(string.Empty));


        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public string CheckToolTip
        {
            get { return (string)GetValue(CheckToolTipProperty); }
            set { SetValue(CheckToolTipProperty, value); }
        }
        #endregion

        #region 未选中ToolTip
        public static readonly DependencyProperty UnCheckToolTipProperty = DependencyProperty.RegisterAttached("UnCheckToolTip",
                                          typeof(string),
                                          typeof(IconRadioButton),
                                          new PropertyMetadata(string.Empty));


        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public string UnCheckToolTip
        {
            get { return (string)GetValue(UnCheckToolTipProperty); }
            set { SetValue(UnCheckToolTipProperty, value); }
        }
        #endregion


        #region Content停靠方向
        public static readonly DependencyProperty ContentDockProperty = DependencyProperty.RegisterAttached("ContentDock",
                                             typeof(Dock),
                                             typeof(IconRadioButton),
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
                                                   typeof(IconRadioButton),
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
