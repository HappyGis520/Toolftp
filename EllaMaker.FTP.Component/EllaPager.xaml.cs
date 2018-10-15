using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System;

namespace EllaMaker.FTP.Component
{
    /// <summary>
    /// Interaction logic for Pager.xaml
    /// </summary>
    public partial class EllaPager : UserControl
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
        public EllaPager()
        {
            InitializeComponent();
        }
        static EllaPager()
        {
            FirstPageEvent = EventManager.RegisterRoutedEvent("FirstPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPager));
            PreviousPageEvent = EventManager.RegisterRoutedEvent("PreviousPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPager));
            NextPageEvent = EventManager.RegisterRoutedEvent("NextPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPager));
            LastPageEvent = EventManager.RegisterRoutedEvent("LastPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPager));

            CurrentPageProperty = DependencyProperty.Register("CurrentPage", typeof(string), typeof(EllaPager), new PropertyMetadata(string.Empty,new PropertyChangedCallback(OnCurrentPageChanged)));
            TotalPageProperty = DependencyProperty.Register("TotalPage", typeof(string), typeof(EllaPager), new PropertyMetadata(string.Empty,new PropertyChangedCallback(OnTotalPageChanged)));
        }
        /// <summary>
        /// 第一页
        /// </summary>
        public event RoutedEventHandler FirstPage
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
            EllaPager p = d as EllaPager;

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
            EllaPager p = d as EllaPager;

            if(p != null)
            {
                Run rCurrrent = (Run)p.FindName("rCurrent");

                rCurrrent.Text = (string)e.NewValue;
            }
        }

        private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        {

            RaiseEvent(new RoutedEventArgs(FirstPageEvent, this));
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
