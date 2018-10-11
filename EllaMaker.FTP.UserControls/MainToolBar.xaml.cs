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
        public static readonly RoutedEvent ButtonClickEvent =
            EventManager.RegisterRoutedEvent("ButtonClick", RoutingStrategy.Tunnel, typeof(EventHandler<MainToolBarClickArgs>),
                typeof(MainToolBar));
        public event RoutedEventHandler ButtonClick
        {
            add { this.AddHandler(ButtonClickEvent, value); }
            remove { this.RemoveHandler(ButtonClickEvent, value); }
        }
        #endregion
        #region
        private RoutedCommand MainToolClick = new RoutedCommand("MainToolClick", typeof(MainToolBar));
        private CommandBinding cb = null;
        #endregion
        public MainToolBar()
        {
            InitializeComponent();
            cb = new CommandBinding(MainToolClick, ExcutMainToolClick, CanExcutMainToolClick);
            this.grdBound.CommandBindings.Add(cb);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
            MainToolBarClickArgs args = new MainToolBarClickArgs(ButtonClickEvent,e.Source);
            args.Data = "wjj";
           this.RaiseEvent(args);
        }

        private void ExcutMainToolClick(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CanExcutMainToolClick(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }
}
