using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EllaMaker.FTP.Model;

namespace EllaMaker.FTP.ViewModel
{
    public class PageNavigateArgs: RoutedEventArgs
    {
        public PageNavigateArgs(RoutedEvent routedEvent, Object source,ListByPageParam param) : base(routedEvent, source)
        {
            _PageParam = param;
        }
        public ListByPageParam _PageParam;
        public ListByPageParam PageParam
        {
            get
            {
                return _PageParam;
            }
        }
    }
}
