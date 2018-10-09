using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.Helper
{
    public static class CollectHelper
    {
        public static ObservableCollection<Model.SelectItemModel> GetSelecItems(List<Model.PsAndDeptTreeNodeItem> list)
        {
            var res = new ObservableCollection<Model.SelectItemModel>();
            foreach (var item in list)
            {
                if (item.IsChecked)
                    res.Add(new Model.SelectItemModel()
                    {
                        ItemId=item.ItemId,
                        Itemtype=item.ItemType,
                        Name=item.Name
                    });
                GetSelecItems(item.Childrens).ToList().ForEach(p => { res.Add(p); });
            }

            return res;
        }
    }
}
