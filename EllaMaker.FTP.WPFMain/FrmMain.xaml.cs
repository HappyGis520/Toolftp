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
using System.Windows.Shapes;
using EllaMaker.FTP.Messages;
using EllaMaker.FTP.UserControls;

namespace EllaMaker.FTP.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        private BookListControl _BookListView = null;
        private EBookListControl _EBookListView = null;
        private  EnumMainToolButton _CurFormType= EnumMainToolButton.UNKNOW;
        public FrmMain()
        {
            InitializeComponent();
            ShowBookView();
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
            }
            this.contextPanel.Children.Clear();
            this.contextPanel.Children.Add(_BookListView);
            _CurFormType = EnumMainToolButton.LOADBOOK;
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

        #region 翻页事件处理
        private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        {

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
                case EnumMainToolButton.LOADBOOK:
                    ShowBookView();
                   
                    break;
               case EnumMainToolButton.LOADEBOOK:
                    ShowEBookView();
                    break;
                default:
                    break;
            }
            
        }


    }
}
