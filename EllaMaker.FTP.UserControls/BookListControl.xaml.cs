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
        private BookListByPage _BindItems = null;
        private double _RowHeight = 0;
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
            //_SelectRow = null;
        }

        private void DgvList_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition(dgvList);
            var obj = dgvList.InputHitTest(pos);
            var tagObj = obj as DependencyObject;
            if (tagObj is DataGridRow)
            {
                var row = tagObj as DataGridRow;
                this.RaiseEvent(new LoadFTPRootArgs(LoadFTPRootEvent,dgvList,_BindItems.Items[row.GetIndex()].id));
            }

        }

        private void BookListControl_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var _columnHeardHeight = dgvList.ColumnHeaderHeight;
            var _ViewHeight = _GridHeight - _columnHeardHeight;
            var _Rows = _ViewHeight % _RowHeight > 0 ? _ViewHeight / _RowHeight + 1:
             _ViewHeight / _RowHeight ;
            Debug.Print($"Grid控件高度{_GridHeight}，列头调度{_columnHeardHeight}，行高度{_RowHeight}，行数{_Rows},  {   dgvList.Items.Count}");
        }

        private void DgvList_OnLoadingRow(object sender, DataGridRowEventArgs e)
        {
                
                //_RowHeight = e.Row.Height;
            
           
            

        }

        private void DgvList_OnLayoutUpdated(object sender, EventArgs e)
        {
            
        }
    }
}
