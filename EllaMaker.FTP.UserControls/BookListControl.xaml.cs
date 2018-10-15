using EllaMaker.FTP.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using EllaMaker.FTP.Component;

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// BookListControl.xaml 的交互逻辑
    /// </summary>
    public partial class BookListControl : UserControl
    {
        #region 定义翻页事件
        //public static RoutedEvent FirstPageEvent;
        //public static RoutedEvent PreviousPageEvent;
        //public static RoutedEvent NextPageEvent;
        //public static RoutedEvent LastPageEvent;
        #endregion

        public BookListControl()
        {
            InitializeComponent();
        }

        #region 事件注册及初始化
        //static BookListControl()
        //{
        //    //FirstPageEvent = EventManager.RegisterRoutedEvent("FirstPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BookListControl));
        //    //PreviousPageEvent = EventManager.RegisterRoutedEvent("PreviousPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BookListControl));
        //    //NextPageEvent = EventManager.RegisterRoutedEvent("NextPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BookListControl));
        //    //LastPageEvent = EventManager.RegisterRoutedEvent("LastPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(BookListControl));

        //    //CurrentPageProperty = DependencyProperty.Register("CurrentPage", typeof(string), typeof(EllaPager), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnCurrentPageChanged)));
        //    //TotalPageProperty = DependencyProperty.Register("TotalPage", typeof(string), typeof(EllaPager), new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnTotalPageChanged)));
        //}

        #region 翻页事件
        ///// <summary>
        ///// 第一页
        ///// </summary>
        //public event RoutedEventHandler FirstPage
        //{
        //    add { AddHandler(FirstPageEvent, value); }
        //    remove { RemoveHandler(FirstPageEvent, value); }
        //}
        ///// <summary>
        ///// 上一页
        ///// </summary>
        //public event RoutedEventHandler PreviousPage
        //{
        //    add { AddHandler(PreviousPageEvent, value); }
        //    remove { RemoveHandler(PreviousPageEvent, value); }
        //}
        ///// <summary>
        ///// 下一页
        ///// </summary>
        //public event RoutedEventHandler NextPage
        //{
        //    add { AddHandler(NextPageEvent, value); }
        //    remove { RemoveHandler(NextPageEvent, value); }
        //}
        ///// <summary>
        ///// 最后一页
        ///// </summary>
        //public event RoutedEventHandler LastPage
        //{
        //    add { AddHandler(LastPageEvent, value); }
        //    remove { RemoveHandler(LastPageEvent, value); }
        //}
        #endregion

        #region 翻页事件处理
        //private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        //{
        //   this.RaiseEvent(new RoutedEventArgs(EllaPager.FirstPageEvent,this));
        //}

        //private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.RaiseEvent(new RoutedEventArgs(EllaPager.PreviousPageEvent, this));

        //}

        //private void NextPageButton_Click(object sender, RoutedEventArgs e)
        //{
        //  RaiseEvent(new RoutedEventArgs(EllaPager.NextPageEvent,this));
        //}

        //private void LastPageButton_Click(object sender, RoutedEventArgs e)
        //{
        //    RaiseEvent(new RoutedEventArgs(EllaPager.LastPageEvent, this));
        //}

        #endregion

        #endregion
        public void LoadData(List<BookListItem> items)
        {
            this.dgvList.ItemsSource = items;
        }

    }
}
