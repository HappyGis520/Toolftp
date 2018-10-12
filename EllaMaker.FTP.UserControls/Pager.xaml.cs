using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using EllaMaker.FTP.ViewModel;
using System;

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// Interaction logic for Pager.xaml
    /// </summary>
    public partial class Pager : UserControl
    {
        public static RoutedEvent FirstPageEvent;
        public static RoutedEvent PreviousPageEvent;
        public static RoutedEvent NextPageEvent;
        public static RoutedEvent LastPageEvent;
        public static readonly DependencyProperty PageSizeProperty;

        /// <summary>
        /// 当前页
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty;
        /// <summary>
        /// 总页数
        /// </summary>
        public static readonly DependencyProperty TotalPageProperty;
        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize
        {
            get { return (int)GetValue(PageSizeProperty); }
            set { SetValue(PageSizeProperty, value); }
        }
        /// <summary>
        /// 当前页码
        /// </summary>
        public string CurrentPage
        {
            get { return (string)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }
        /// <summary>
        /// 总页数
        /// </summary>
        public string TotalPage
        {
            get { return (string)GetValue(TotalPageProperty); }
            set { SetValue(TotalPageProperty, value); }
        }
        public Pager()
        {
            InitializeComponent();
        }
        static Pager()
        {
            FirstPageEvent = EventManager.RegisterRoutedEvent("FirstPage", RoutingStrategy.Direct, typeof(EventHandler<PageNavigateArgs>), typeof(Pager));
            PreviousPageEvent = EventManager.RegisterRoutedEvent("PreviousPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(Pager));
            NextPageEvent = EventManager.RegisterRoutedEvent("NextPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(Pager));
            LastPageEvent = EventManager.RegisterRoutedEvent("LastPage", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(Pager));

            CurrentPageProperty = DependencyProperty.Register("CurrentPage", typeof(string), typeof(Pager), new PropertyMetadata(string.Empty,new PropertyChangedCallback(OnCurrentPageChanged)));
            TotalPageProperty = DependencyProperty.Register("TotalPage", typeof(string), typeof(Pager), new PropertyMetadata(string.Empty,new PropertyChangedCallback(OnTotalPageChanged)));
        }
        /// <summary>
        /// 第一页
        /// </summary>
        public event EventHandler<PageNavigateArgs> FirstPage
        {
            add { AddHandler(FirstPageEvent, value); }
            remove { RemoveHandler(FirstPageEvent, value); }
        }
        /// <summary>
        /// 上一页
        /// </summary>
        public event RoutedEventHandler PreviousPage
        {
            add { AddHandler(PreviousPageEvent, value); }
            remove { RemoveHandler(PreviousPageEvent, value); }
        }
        /// <summary>
        /// 下一页
        /// </summary>
        public event RoutedEventHandler NextPage
        {
            add { AddHandler(NextPageEvent, value); }
            remove { RemoveHandler(NextPageEvent, value); }
        }
        /// <summary>
        /// 最后一页
        /// </summary>
        public event RoutedEventHandler LastPage
        {
            add { AddHandler(LastPageEvent, value); }
            remove { RemoveHandler(LastPageEvent, value); }
        }
        /// <summary>
        /// 总页数改变
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public static void OnTotalPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Pager p = d as Pager;

            if(p != null)
            {
                Run rTotal = (Run)p.FindName("rTotal");

                rTotal.Text = (string)e.NewValue;
            }
        }
        /// <summary>
        /// 当前页改变
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnCurrentPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Pager p = d as Pager;

            if(p != null)
            {
                Run rCurrrent = (Run)p.FindName("rCurrent");

                rCurrrent.Text = (string)e.NewValue;
            }
        }

        private void FirstPageButton_Click(object sender, EventHandler<PageNavigateArgs> e)
        {
            Model.ListByPageParam = new Model.ListByPageParam()
            {
                PageIndex = 
            }
            RaiseEvent(new PageNavigateArgs(FirstPageEvent, this,new Model.ListByPageParam());
        }

        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(PreviousPageEvent, this));
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(NextPageEvent, this));
        }

        private void LastPageButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(LastPageEvent, this));
        }
    }
}
