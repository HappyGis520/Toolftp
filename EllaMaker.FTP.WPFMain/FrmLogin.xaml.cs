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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EllaMaker.FTP.View
{
    /// <summary>
    /// WNDLogin.xaml 的交互逻辑
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
       


        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
              Application.Current.Shutdown();
        }

        private void BtnOk_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}
