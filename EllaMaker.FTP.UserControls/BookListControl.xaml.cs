using System;
using EllaMaker.FTP.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using EllaMaker.FTP.Component;

namespace EllaMaker.FTP.UserControls
{


    /// <summary>
    /// BookListControl.xaml 的交互逻辑
    /// </summary>
    public partial class BookListControl : UserControl
    {
        private int _ColumnHeardHeight = 44;
        private BookListByPage _BindItems = null;
        private double _RowHeight = 20;
        private double _MaxRows = 0;
        #region 定义事件

        public static readonly RoutedEvent LoadFTPRootEvent;

        #endregion

        public BookListControl()
        {
            InitializeComponent();
        }

        #region 事件注册及初始化

        static BookListControl()
        {
            LoadFTPRootEvent =
                EventManager.RegisterRoutedEvent("LoadFTPRoot",
                    RoutingStrategy.Direct, typeof(RoutedEventHandler),
                    typeof(BookListControl));
        }

        #region 事件封装

        /// <summary>
        /// 加载FTP根目录事件
        /// </summary>
        public event RoutedEventHandler LoadFTPRoot
        {
            add { this.AddHandler(LoadFTPRootEvent, value); }
            remove { this.RemoveHandler(LoadFTPRootEvent, value); }
        }

        #endregion

        #endregion

        /// <summary>
        /// 加载图书列表
        /// </summary>
        /// <param name="Page"></param>
        public void LoadData(BookListByPage Page)
        {
            this.dgvList.ItemsSource = Page.Items;
            _BindItems = Page;
        }

        private void DgvList_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgvList.CurrentItem != null)
            {
                var item = dgvList.CurrentItem as BookItem;
                this.RaiseEvent(new LoadFTPRootArgs(LoadFTPRootEvent, dgvList, item.id));
            }
        }

        private void BookListControl_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var _OriginalObj = e.Source as FrameworkElement;
            
            var _TotalRowHeight = _OriginalObj.ActualHeight - _ColumnHeardHeight;
             _MaxRows = _TotalRowHeight%_RowHeight > 0 ? (_TotalRowHeight/ _RowHeight) + 1 : (_TotalRowHeight/ _RowHeight);
            
            if (_OriginalObj is DataGrid)
            {
                Debug.Print($"Grid控件原高度{e.PreviousSize.Height}，现高度{e.NewSize.Height},行数{_MaxRows}");
            }
        }

    }
}
