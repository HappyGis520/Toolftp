using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EllaMaker.FTP.Core;
using EllaMaker.FTP.Model;
using Ellamaker.FTP.Controls;
using EllaMaker.FTP.Services;
using EllaMaker.FTP.BLL;
using EllaMaker.FTP.Model.Enum;

namespace EllaMaker.FTP.MainWindow
{
    public partial class Form1 : Form
    {
        UcBookList _UcBookList = null;
        private UcBookResource _UcBookResource = null;

       private BLLFTPResource _BLLFTPResource = new BLLFTPResource();
       private BLLBook _BLLBook = new BLLBook();
       public Form1()
        {
            InitializeComponent();
            Utility.URL = "http://192.168.1.150:8111";
        }
       private void LoadBookListControl()
        {
            if (_UcBookList == null)
            {
                _UcBookList = new UcBookList();
                _UcBookList.RegistLoadResourceEvent(LoadBookResourceControl);
            }
            if (!this.pnlControlContainer.Controls.Contains(_UcBookList))
                this.pnlControlContainer.Controls.Add(_UcBookList);
            //_UcBookList = new UcBookList();
            //_UcBookList.RegistLoadResourceEvent(LoadBookResourceControl);
        }
       private void LoadBookResourceControl(string BookID)
        {
            if (this.InvokeRequired)
            {
                object[] Params = new object[] { BookID };
                this.Invoke(new Action<string>(this.LoadBookResourceControl), Params);
                return;

            }

            if (!String.IsNullOrEmpty(BookID))
            {
                this.pnlControlContainer.Controls.Clear();
                if (_UcBookResource == null)
                {
                    _UcBookResource = new UcBookResource(BookID);
                    _UcBookResource.RegistOpenDirectoryEvent(OnOpenDirectory);
                }
                else
                {
                    _UcBookResource.SetBookID(BookID);
                }
                if (!this.pnlControlContainer.Controls.Contains(_UcBookResource))
                    this.pnlControlContainer.Controls.Add(_UcBookResource);
                _UcBookResource.Dock = DockStyle.Fill;
                _UcBookResource.LoadData();
                
            }
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
           BookListByPageParam param = new BookListByPageParam();
            param.PageSize = 100;
            param.PageIndex = 0;
            var _item = _BLLBook.LoadBookList(0, 100);
            LoadBookListControl();
            _UcBookList.BindingData(_item);
        }



       private void OnOpenDirectory(String bookID,EnumFileInfoType resourceType,String directoryID,string searchName)
        {
           var _result =  _BLLFTPResource.LoadFTPResource(bookID, resourceType, directoryID,searchName);
            _UcBookResource.LoadData(_result,resourceType);


        }

        
    }
}
