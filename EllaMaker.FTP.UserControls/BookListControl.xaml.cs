using EllaMaker.FTP.Model;
using System.Collections.Generic;
using System.Windows.Controls;

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// BookListControl.xaml 的交互逻辑
    /// </summary>
    public partial class BookListControl : UserControl
    {
        public BookListControl()
        {
            InitializeComponent();
        }
        public void LoadData(List<BookListItem> items)
        {
            this.dgvList.ItemsSource = items;
        }

        #region 控件事件处理
        private void LoadPage(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        #endregion

        private void Pager_FirstPage()
        {

        }
    }
}
