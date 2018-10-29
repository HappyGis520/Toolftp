using EllaMaker.FTP.Component.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EllaMaker.FTP.Component.Command;

namespace EllaMaker.FTP.Component
{
    /// <summary>
    /// PathColorCheckBox.xaml 的交互逻辑
    /// </summary>
    public  class PathColorCheckBox : ToggleButton
    {
        public PathColorCheckBox()
        {
            base.DefaultStyleKey = typeof(PathColorCheckBox);
            this.root_PreviewMouseLeftButtonUpCmd = new ActionCommand<MouseButtonEventArgs>(root_PreviewMouseLeftButtonUp);
            this.root_PreviewMouseLeftButtonDownCmd = new ActionCommand<MouseButtonEventArgs>(root_PreviewMouseLeftButtonDown);
            this.root_PreviewMouseMoveCmd = new ActionCommand<MouseEventArgs>(root_PreviewMouseMove);
        }

        public ActionCommand<MouseButtonEventArgs> root_PreviewMouseLeftButtonUpCmd { get; private set; }
        public ActionCommand<MouseButtonEventArgs> root_PreviewMouseLeftButtonDownCmd { get; private set; }
        public ActionCommand<MouseEventArgs> root_PreviewMouseMoveCmd { get; private set; }

        #region 按钮圆角

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius",
                                                     typeof(CornerRadius),
                                                     typeof(PathColorCheckBox),
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
                                             typeof(PathColorCheckBox),
                                             new PropertyMetadata("M23.100006,9.5000782L25.299988,12.100105 13.399994,22.500186 6.7000122,14.700118 9.3000183,12.500103 13.800018,17.700143z M3.2000122,1.6000195C2.3000183,1.6000192,1.6000061,2.3000219,1.6000061,3.2000232L1.6000061,28.800241C1.6000061,29.700242,2.3000183,30.40026,3.2000122,30.40026L28.799988,30.40026C29.700012,30.40026,30.400024,29.700242,30.400024,28.800241L30.400024,3.2000232C30.400024,2.3000219,29.700012,1.6000192,28.799988,1.6000195z M3.2000122,0L28.700012,0C30.5,-1.5262231E-08,32,1.5000123,32,3.2000232L32,28.700233C32,30.500251,30.5,31.900271,28.799988,31.900271L3.2000122,31.900271C1.5,32.000262,0,30.500251,0,28.800241L0,3.2000232C0,1.5000123,1.5,-1.5262231E-08,3.2000122,0z"));

      
        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        #endregion

        #region 选中改变颜色类别
        public static readonly DependencyProperty ChangeColorTypeProperty = DependencyProperty.RegisterAttached("ChangeColorType",
                                         typeof(ChangeColorType),
                                         typeof(PathColorCheckBox),
                                         new PropertyMetadata(ChangeColorType.Background));
        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public ChangeColorType ChangeColorType
        {
            get { return (ChangeColorType)GetValue(ChangeColorTypeProperty); }
            set { SetValue(ChangeColorTypeProperty, value); }
        }

        #endregion
        #region 选中Color
        public static readonly DependencyProperty CheckColorProperty = DependencyProperty.RegisterAttached("CheckColor",
                                           typeof(Brush),
                                           typeof(PathColorCheckBox),
                                           new PropertyMetadata(Brushes.Red));


        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public Brush CheckColor
        {
            get { return (Brush)GetValue(CheckColorProperty); }
            set { SetValue(CheckColorProperty, value); }
        }
        #endregion

        #region 未选中Color
        public static readonly DependencyProperty UnCheckColorProperty = DependencyProperty.RegisterAttached("UnCheckColor",
                                          typeof(Brush),
                                          typeof(PathColorCheckBox),
                                          new PropertyMetadata(Brushes.Gray));


        /// <summary>
        /// 选中显示图标 支持路径与图像
        /// </summary>
        public Brush UnCheckColor
        {
            get { return (Brush)GetValue(UnCheckColorProperty); }
            set { SetValue(UnCheckColorProperty, value); }
        }
        #endregion

        #region 选中ToolTip
        public static readonly DependencyProperty CheckToolTipProperty = DependencyProperty.RegisterAttached("CheckToolTip",
                                           typeof(string),
                                           typeof(PathColorCheckBox),
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
                                          typeof(PathColorCheckBox),
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


        #region 图标旋转角度

        public static readonly DependencyProperty
            AngleProperty = DependencyProperty.RegisterAttached("Angle",
                                                   typeof(double),
                                                   typeof(PathColorCheckBox),
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

        #region 组名
        public static readonly DependencyProperty GroupNameProperty = DependencyProperty.RegisterAttached("GroupName",
                                                    typeof(string),
                                                    typeof(PathColorCheckBox),
                                                    new PropertyMetadata("none"));
        /// <summary>
        /// 组名
        /// </summary>
        public string GroupName
        {
            get { return (string)GetValue(GroupNameProperty); }
            set { SetValue(GroupNameProperty, value); }
        }
        #endregion

        public static PathColorCheckBox MoveCheckElement = null;
        private void root_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MoveCheckElement = null;
            e.Handled = true;
        }

        private void root_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            base.IsChecked = !base.IsChecked;
            MoveCheckElement = this;
            e.Handled = true;
        }

        private void root_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (MoveCheckElement == null) return;
            if (MoveCheckElement == this) return;
            if (GroupName != MoveCheckElement.GroupName) return;

            if (e.LeftButton == MouseButtonState.Released)
            {
                MoveCheckElement = null;
                return;
            }

            if (MoveCheckElement.IsChecked != base.IsChecked)
            {
                base.IsChecked = MoveCheckElement.IsChecked;
            }
            e.Handled = true;
        }
    }
}
