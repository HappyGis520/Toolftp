using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EllaMaker.FTP.Model;

namespace Ellamaker.FTP.Controls
{
    public delegate void LoadResourceHandle(string BookID);

    public partial class UcBookList : UserControl
    {
        

        BindingSource _bindSource = new BindingSource();
        List<BookItem> _items = null;


        #region 加载资源事件

        protected event LoadResourceHandle OnLoadResourceHandle;

        protected void SubDoLoadResource(string bookID)
        {
            RaiseLoadResourceEvent(bookID);
        }

        protected void RaiseLoadResourceEvent(string BookID)
        {
            if (OnLoadResourceHandle != null)
            {
                OnLoadResourceHandle.BeginInvoke(BookID,null,null);
            }

        }

        public void RegistLoadResourceEvent(LoadResourceHandle handle)
        {
            DeRegistLoadResourceEvent(handle);
            OnLoadResourceHandle += handle;


        }

        public void DeRegistLoadResourceEvent(LoadResourceHandle handle)
        {
            OnLoadResourceHandle -= handle;

        }

        #endregion



        public UcBookList()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = _bindSource;
            this.dataGridView1.AutoGenerateColumns = false;
        }

        public  void BindingData(List<BookItem> Books)
        {
            
            if (_items != null)
                _items.Clear();
            _items = Books;
            _bindSource.DataSource = _items;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              if(dataGridView1.Columns[e.ColumnIndex].Name.Equals("Name"))
            {
                var _item = _items[e.RowIndex];
                var id = _item.id;
                RaiseLoadResourceEvent(id);
            }
        }
    }
}
