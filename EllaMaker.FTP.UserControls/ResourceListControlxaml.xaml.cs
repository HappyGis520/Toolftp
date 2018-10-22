using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using EllaMaker.FTP.Model;
namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// ResourceListControlxaml.xaml 的交互逻辑
    /// </summary>
    public partial class ResourceListControlxaml : UserControl
    {
        ObservableCollection<MResourceItem> _Items = new ObservableCollection<MResourceItem>();

        public void BindFileManager()
        {
            lstFileManager.ItemsSource = _Items;
        }
        public ResourceListControlxaml()
        {
            InitializeComponent();
        }
    }
}
