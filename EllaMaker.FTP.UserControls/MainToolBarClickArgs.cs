
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace EllaMaker.FTP.UserControls
{
     public class MainToolBarClickArgs:RoutedEventArgs
     {


        private EnumMainToolButton _ButtonType = EnumMainToolButton.SHOWMENU;
        public MainToolBarClickArgs(RoutedEvent routedEvent, Object source,EnumMainToolButton buttonType) : base(routedEvent, source)
        {
            _ButtonType = buttonType;
        }
    
        public EnumMainToolButton ButtonType
        {
            get { return _ButtonType; }
        } 
    }
}