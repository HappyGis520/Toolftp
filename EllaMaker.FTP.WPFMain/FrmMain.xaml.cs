﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EllaMaker.FTP.Messages;

namespace EllaMaker.FTP.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_OnClick(object sender,  RoutedEventArgs e)
        {
            var ee = e as MainToolBarClickArgs;
            var obj = sender as FrameworkElement;
            MessageBox.Show(obj.GetType().ToString());
        }


    }
}
