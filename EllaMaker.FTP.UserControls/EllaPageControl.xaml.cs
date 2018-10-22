using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System;

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// Interaction logic for Pager.xaml
    /// </summary>
    public partial class EllaPageControl : UserControl
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
        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        } 
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage
        {
            get { return (int)GetValue(TotalPageProperty); }
            set { SetValue(TotalPageProperty, value); }
        }
        public EllaPageControl()
        {
            InitializeComponent();
        }
        static EllaPageControl()
        {
            FirstPageEvent = EventManager.RegisterRoutedEvent("FirstPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPageControl));
            PreviousPageEvent = EventManager.RegisterRoutedEvent("PreviousPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPageControl));
            NextPageEvent = EventManager.RegisterRoutedEvent("NextPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPageControl));
            LastPageEvent = EventManager.RegisterRoutedEvent("LastPage", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EllaPageControl));
            CurrentPageProperty = DependencyProperty.Register("CurrentPage", typeof(int), typeof(EllaPageControl), new PropertyMetadata(0,new PropertyChangedCallback(OnCurrentPageChanged)));
            TotalPageProperty = DependencyProperty.Register("TotalPage", typeof(int), typeof(EllaPageControl), new PropertyMetadata(1,new PropertyChangedCallback(OnTotalPageChanged)));
            PageSizeProperty = DependencyProperty.Register("PageSize", typeof(int), typeof(EllaPageControl), new PropertyMetadata(10,new PropertyChangedCallback(OnTotalPageChanged)));
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
            EllaPageControl p = d as EllaPageControl;

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
            EllaPageControl p = d as EllaPageControl;

            if(p != null)
            {
                Run rCurrrent = (Run)p.FindName("rCurrent");

                rCurrrent.Text = (string)e.NewValue;
            }
        }

        private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        {
            //if (curpage != 0)
            //{

                RaiseEvent(new PageIndexChangedArgs(FirstPageEvent, this, CurrentPage, 0,
                PageSize));
            //}
        }

        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            var newPage = Convert.ToInt16(CurrentPage) - 1 >= 0 ? Convert.ToInt16(CurrentPage) - 1 : 0;
            RaiseEvent(new PageIndexChangedArgs(PreviousPageEvent, this, Convert.ToInt16(CurrentPage), newPage, PageSize));
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            var newPage = Convert.ToInt16(CurrentPage) + 1 <= Convert.ToInt16(TotalPage) ? Convert.ToInt16(CurrentPage) + 1 : Convert.ToInt16(TotalPage);
            RaiseEvent(new PageIndexChangedArgs(NextPageEvent, this, Convert.ToInt16(CurrentPage), newPage, PageSize));
        }

        private void LastPageButton_Click(object sender, RoutedEventArgs e)
        {
            if ((int)Convert.ToInt16(CurrentPage) != Convert.ToInt16(TotalPage) - 1)
            {
                var newPage = Convert.ToInt16(TotalPage) - 1;
                RaiseEvent(new PageIndexChangedArgs(LastPageEvent, this, Convert.ToInt16(CurrentPage), newPage,
                    PageSize));
            }
        }
    }
}
