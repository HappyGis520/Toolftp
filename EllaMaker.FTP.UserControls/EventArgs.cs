
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// 加载FTP根目录参数
    /// </summary>
    public class LoadFTPRootArgs : RoutedEventArgs
    {
        private string _BookID;

        public string BookID
        {
            get { return _BookID; }
        }

        public LoadFTPRootArgs(RoutedEvent routedEvent, Object source, string bookID) : base(routedEvent, source)
        {
            _BookID = bookID;

        }
    }
    /// <summary>
    /// 页索引改变事件参数
    /// </summary>
    public class PageIndexChangedArgs : RoutedEventArgs
    {
        private int _curPageIndex;
        private int _newPageIndex;
        private int _pageSize;
        public PageIndexChangedArgs(RoutedEvent routedEvent,Object source,int curPageIndex,int newPageindwx,int pagesize) : base(routedEvent,source)
        {
            _curPageIndex = curPageIndex;
            _newPageIndex = newPageindwx;
            _pageSize = pagesize;
        }
        /// <summary>
        /// 当前页索引
        /// </summary>
        public int CurPageIndex { get => _curPageIndex; }
        /// <summary>
        /// 新页索引
        /// </summary>
        public int NewPageIndex { get => _newPageIndex; }
        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize { get => _pageSize;  }
    }
}