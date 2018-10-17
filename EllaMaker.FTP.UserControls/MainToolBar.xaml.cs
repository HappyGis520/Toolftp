using EllaMaker.FTP.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class MainToolBar : UserControl
    {
        //#region 应用程序最小化事件

        //public static readonly RoutedEvent AppWinMinEvent = EventManager.RegisterRoutedEvent("AppWinMin",
        //    RoutingStrategy.Bubble, typeof( RoutedEventHandler),typeof(MainToolBar));
        //public event RoutedEventHandler AppWinMin
        //{
        //    add { this.AddHandler(AppWinMinEvent, value);  }
        //    remove { this.RemoveHandler(AppWinMinEvent, value);}
        //}
        //#endregion
        //#region 窗体最大化事件

        //public static readonly RoutedEvent AppWinMaxEvent = EventManager.RegisterRoutedEvent("AppWinMax",
        //    RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MainToolBar));
        //public event RoutedEventHandler AppWinMax
        //{
        //    add { this.AddHandler(AppWinMaxEvent, value); }
        //    remove { this.RemoveHandler(AppWinMaxEvent, value); }
        //}
        //#endregion
        //#region 关闭应用程序

        //public static readonly RoutedEvent AppWinCloseEvent = EventManager.RegisterRoutedEvent("AppWinClose",
        //    RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MainToolBar));
        //public event RoutedEventHandler AppWinClose
        //{
        //    add { this.AddHandler(AppWinCloseEvent, value); }
        //    remove { this.RemoveHandler(AppWinCloseEvent, value); }
        //}
        //#endregion
        #region 主工具栏点击事件
        /// <summary>
        /// 主工具栏点击事件
        /// </summary>
        public static readonly RoutedEvent MailToolClickEvent =
            EventManager.RegisterRoutedEvent("MailToolClick", RoutingStrategy.Direct, typeof(EventHandler<MainToolBarClickArgs>),
                typeof(MainToolBar));
        public event RoutedEventHandler MailToolClick
        {
            add { this.AddHandler(MailToolClickEvent, value); }
            remove { this.RemoveHandler(MailToolClickEvent, value); }
        }
        #endregion
        public MainToolBar()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var _btn = sender as Button;
            var _Type = (EnumMainToolButton)Enum.Parse(typeof(EnumMainToolButton), _btn.Tag.ToString());
            this.RaiseEvent(new MainToolBarClickArgs(MailToolClickEvent, this, _Type));
           
        }

        private void MainToolBar_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.RaiseEvent(new MainToolBarClickArgs(MailToolClickEvent, this, EnumMainToolButton.MAXWINDOW));
        }
    }
}
