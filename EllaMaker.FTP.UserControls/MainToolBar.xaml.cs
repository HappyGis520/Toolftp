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
        #region 路由事件
        /// <summary>
        /// 主工具栏点击事件
        /// </summary>
        public static readonly RoutedEvent MailToolClickEvent =
            EventManager.RegisterRoutedEvent("MailToolClickClick", RoutingStrategy.Direct, typeof(EventHandler<MainToolBarClickArgs>),
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
            switch (_btn.Tag.ToString())
            {
                case "1":
                    this.RaiseEvent(new MainToolBarClickArgs(MailToolClickEvent,this,EnumMainToolButton.LOADBOOK));
                    break;
                case "2":
                    this.RaiseEvent(new MainToolBarClickArgs(MailToolClickEvent, this, EnumMainToolButton.LOADEBOOK));
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "0":
                    break;




            }

        }

        private void ExcutMainToolClick(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CanExcutMainToolClick(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
