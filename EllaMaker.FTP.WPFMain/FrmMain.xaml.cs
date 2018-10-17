using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using System.Windows.Forms;
using EllaMaker.FTP.Messages;
using EllaMaker.FTP.UserControls;
using EllaMaker.FTP.BLL;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;

namespace EllaMaker.FTP.View
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        private BLLBook _BLLBook = null;
        private BookListControl _BookListView = null;
        private EBookListControl _EBookListView = null;
        private EnumMainToolButton _CurFormType= EnumMainToolButton.UNKNOW;
        private bool _ShowIconInTaskBar =true;
        private bool ShowIconInTaskBar
        {
            set
            {
                _ShowIconInTaskBar = value;
                this.ShowInTaskbar = _ShowIconInTaskBar;
                this.notifyIcon.Visible = true;
            }
            get { return _ShowIconInTaskBar; }

        }
        public FrmMain()
        {
            InitializeComponent();
            ShowBookView();
            InitialTray();
        }


        private void MainToolBar_Click(Object sender, RoutedEventArgs e)
        {
            var arg = e as MainToolBarClickArgs;
            switch (arg.ButtonType)
            {
                case EnumMainToolButton.LOADBOOK:
                    break;
                default:
                    break;
            }
        }

        private void ShowBookView()
        {
            if (_BookListView == null)
            {
                _BookListView = new BookListControl();
                _BLLBook = new BLLBook();
            }
            this.contextPanel.Children.Clear();
            this.contextPanel.Children.Add(_BookListView);
            _CurFormType = EnumMainToolButton.LOADBOOK;
            var _item = _BLLBook.LoadBookList(0, 10);
          _BookListView.LoadData(_item);


        }
        private void ShowEBookView()
        {
            if (_EBookListView == null)
            {
                _EBookListView = new EBookListControl();
            }
            this.contextPanel.Children.Clear();
            this.contextPanel.Children.Add(_EBookListView);
            _CurFormType = EnumMainToolButton.LOADEBOOK;
        }

        private void AppExist()
        {
            var _resut = MessageBox.Show(this, "确认退出程序？", "咿啦资源工具", MessageBoxButton.YesNoCancel);
            if (_resut == MessageBoxResult.Yes)
            {
                Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
                Application.Current.Shutdown();
            }
            else if(_resut == MessageBoxResult.No)
            {
                this.ShowIconInTaskBar = false;
                WindowState = WindowState.Minimized;
                
            }
        }

        #region 翻页事件处理
        private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (_CurFormType == EnumMainToolButton.LOADBOOK)
            {
              //var _item = _BLLBook.LoadBookList(0,_BookListView)
                
            }
            else
            {
                
            }

        }

        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LastPageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion
        /// <summary>
        /// 工具栏事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainToolBar_OnMailToolClick(object sender, RoutedEventArgs e)
        {
            MainToolBarClickArgs args = e as MainToolBarClickArgs;
            switch (args.ButtonType)
            {
                case  EnumMainToolButton.MINWINDOW:
                    WindowState = WindowState.Minimized;
                    this.ShowIconInTaskBar = true;
                   break;
                case EnumMainToolButton.MAXWINDOW:
                    if (WindowState == WindowState.Maximized)
                    {
                        WindowState = WindowState.Normal;
                    }
                    else
                    {
                        WindowState = WindowState.Maximized;
                    }
                    break;
                case EnumMainToolButton.LOADBOOK:
                    ShowBookView();
                    break;
               case EnumMainToolButton.LOADEBOOK:
                    ShowEBookView();
                    break;
                case EnumMainToolButton.EXISIT:
                    AppExist();
                    break;
                default:
                    break;
            }
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void FrmMain_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private NotifyIcon notifyIcon = null;
        private void InitialTray()
        {

            //设置托盘的各个属性
            notifyIcon = new System.Windows.Forms.NotifyIcon();
            notifyIcon.BalloonTipText = "程序开始运行";
            notifyIcon.Text = "托盘图标";
            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            notifyIcon.Visible = !ShowIconInTaskBar;
            notifyIcon.ShowBalloonTip(2000);
            notifyIcon.MouseClick += NotifyIcon_Click;

            //设置菜单项
            //System.Windows.Forms.MenuItem menu1 = new System.Windows.Forms.MenuItem(\"菜单项1\");
            //System.Windows.Forms.MenuItem menu2 = new System.Windows.Forms.MenuItem(\"菜单项2\");
            //System.Windows.Forms.MenuItem menu = new System.Windows.Forms.MenuItem(\"菜单\", new System.Windows.Forms.MenuItem[] { menu1 , menu2 });

            ////退出菜单项
            //System.Windows.Forms.MenuItem exit = new System.Windows.Forms.MenuItem(\"exit\");
            //exit.Click += new EventHandler(exit_Click);

            //关联托盘控件
            //System.Windows.Forms.MenuItem[] childen = new System.Windows.Forms.MenuItem[] { menu, exit };
            //notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(childen);

            //窗体状态改变时候触发
            //this.StateChanged += new EventHandler(SysTray_StateChanged);
        }

        private void NotifyIcon_Click(object sender,System.Windows.Forms.MouseEventArgs e)
        {

                WindowState = WindowState.Maximized;
            this.ShowIconInTaskBar = true;


        }
    }
}
