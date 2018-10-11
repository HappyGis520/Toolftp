
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace EllaMaker.FTP.ViewModel
{
     public class MainToolBarClickArgs:RoutedEventArgs
    {
        public MainToolBarClickArgs(RoutedEvent routedEvent, Object source) : base(routedEvent, source)
        {
        }

        public string Data = "fdsfsafsafsaf";
    }
}