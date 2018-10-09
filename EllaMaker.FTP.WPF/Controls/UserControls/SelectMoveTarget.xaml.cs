using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using UserControl = System.Windows.Controls.UserControl;

namespace EllaMaker.FTP.Controls.UserControls
{
    /// <summary>
    /// SelectMoveTarget.xaml 的交互逻辑
    /// </summary>
    public partial class SelectMoveTarget : UserControl
    {
        public SelectMoveTarget()
        {
            InitializeComponent();
        }



        public ObservableCollection<Api.Response.DocumentTreeNodelApiModel> TreeSource
        {
            get { return (ObservableCollection<Api.Response.DocumentTreeNodelApiModel>)GetValue(TreeSourceProperty); }
            set { SetValue(TreeSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TreeSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TreeSourceProperty =
            DependencyProperty.Register("TreeSource", typeof(ObservableCollection<Api.Response.DocumentTreeNodelApiModel>), typeof(SelectMoveTarget));



        public string TargetCatalogId
        {
            get { return (string)GetValue(TargetCatalogIdProperty); }
            set { SetValue(TargetCatalogIdProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TargetCatalogId.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetCatalogIdProperty =
            DependencyProperty.Register("TargetCatalogId", typeof(string), typeof(SelectMoveTarget));



        public string TargetPath
        {
            get { return (string)GetValue(TargetPathProperty); }
            set { SetValue(TargetPathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TargetPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetPathProperty =
            DependencyProperty.Register("TargetPath", typeof(string), typeof(SelectMoveTarget));

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            List<Api.Response.DocumentTreeNodelApiModel> res = new List<Api.Response.DocumentTreeNodelApiModel>();
            if (e.NewValue == null) return;
            var temp = (Api.Response.DocumentTreeNodelApiModel)e.NewValue;
            TargetCatalogId = temp.DocId;
            foreach (var tn in TreeSource)
            {
                var ret = DiGui(tn, temp);
                if (ret.Count>0)
                {
                    TargetPath = string.Join<string>("/", ret.Select(p=>p.Name).Reverse());
                    tipPath.Content ="移动到："+TargetPath;
                }
            }
        }

        private List<Api.Response.DocumentTreeNodelApiModel> DiGui(Api.Response.DocumentTreeNodelApiModel tn, Api.Response.DocumentTreeNodelApiModel temp)
        {
            List<Api.Response.DocumentTreeNodelApiModel> res = new List<Api.Response.DocumentTreeNodelApiModel>();
            if (tn == temp)
            {
                res.Add(tn);
                return res;
            }
            foreach (var tnSub in tn.Childrens)
            {
                var tp = DiGui(tnSub, temp);
                if (tp.Count > 0)
                {
                    res=tp;
                    res.Add(tn);
                }
            }
            return res;
        }
    }
}
