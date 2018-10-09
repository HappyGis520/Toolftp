using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EllaMaker.FTP.Model;
using EllaMaker.FTP.Model.Enum;

namespace Ellamaker.FTP.Controls
{
    /// <summary>
    /// 创建文件夹委托
    /// </summary>
    /// <param name="ParentID"></param>
    /// <param name="DirectoryName"></param>
    public delegate void CreateDirectoryHandle(string ParentID, string DirectoryName);
    /// <summary>
    /// 删除文件夹委托
    /// </summary>
    /// <param name="Objs"></param>
    public delegate void DeleteDirectoryHandle(List<string> Objs);
    /// <summary>
    /// 打开文件夹委托
    /// </summary>
    /// <param name="DirectoryID"></param>
    public delegate void OpenDirectoryHandle(string bookID,EnumFileInfoType fileInfoType, string directoryID,string searchName);
   
    public partial class UcBookResource : UserControl
    {
        private string _BookID;
        private EnumFileInfoType _FilInfoType= EnumFileInfoType.ALL;
        private EnumFileResourceType _ResourceType = EnumFileResourceType.HDRESOURCE;
        //private EnumFileResourceType 
        List<ListViewItem> _ViewItems = new List<ListViewItem>();
        List<FTPFileInfo>  _DataSource = new List<FTPFileInfo>();
        private String _SearchName = String.Empty;

        #region 创建文件夹事件

        protected event CreateDirectoryHandle CreateDirectoryEvent;

        protected void SubDoCreateDirectory(string ParentID, string DirectoryName)
        {
            RaiseCreateDirectoryEvent( ParentID,  DirectoryName);
        }

        protected void RaiseCreateDirectoryEvent(string ParentID, string DirectoryName)
        {
            if (CreateDirectoryEvent != null)
            {
                CreateDirectoryEvent.BeginInvoke( ParentID,  DirectoryName,null, null);
            }

        }

        public void RegistCreateDirectoryEvent(CreateDirectoryHandle handle)
        {
            DeRegistCreateDirectoryEvent(handle);
            CreateDirectoryEvent += handle;


        }

        public void DeRegistCreateDirectoryEvent(CreateDirectoryHandle handle)
        {
            CreateDirectoryEvent -= handle;

        }

        #endregion

        #region 打开文件夹事年

        protected event OpenDirectoryHandle OpenDirectoryEvent;

        protected void SubDoOpenDirectory(string bookID, EnumFileInfoType resourceType, string directoryID, string searchName)
        {
            RaiseOpenDirectoryEvent( bookID,  resourceType,  directoryID, searchName);
        }

        protected void RaiseOpenDirectoryEvent(string bookID, EnumFileInfoType resourceType, string directoryID, string searchName)
        {
            if (OpenDirectoryEvent != null)
            {
                OpenDirectoryEvent.BeginInvoke( bookID,  resourceType,  directoryID, searchName, null, null);
            }

        }

        public void RegistOpenDirectoryEvent(OpenDirectoryHandle handle)
        {
            DeRegistOpenDirectoryEvent(handle);
            OpenDirectoryEvent += handle;


        }

        public void DeRegistOpenDirectoryEvent(OpenDirectoryHandle handle)
        {
            OpenDirectoryEvent -= handle;

        }

        #endregion

        #region 下载文件事件

        protected event Action<string> OnDownLoadFileEvent;

        protected void SubDoOnDownLoadFile(String FilePath)
        {
            RaiseOnDownLoadFileEvent(FilePath);
        }

        protected void RaiseOnDownLoadFileEvent(String FilePath)
        {
            if (OnDownLoadFileEvent != null)
            {
                OnDownLoadFileEvent.BeginInvoke(FilePath, null, null);
            }

        }

        public void RegistOnDownLoadFileEvent(Action<string> handle)
        {
            DeRegistOnDownLoadFileEvent(handle);
            OnDownLoadFileEvent += handle;


        }

        public void DeRegistOnDownLoadFileEvent(Action<string> handle)
        {
            OnDownLoadFileEvent -= handle;

        }

        #endregion

        public UcBookResource()
        {
            InitializeComponent();

        }
        public UcBookResource(string BookID) : this()
        {

            this._BookID = BookID;
            Inition();

        }
        private void Inition()
        {
            lstHD.Columns.Add("名称", -2, HorizontalAlignment.Left);
            lstHD.Columns.Add("扩展名", -2, HorizontalAlignment.Left);
            //
            lstLower.Columns.Add("名称", -2, HorizontalAlignment.Left);
            lstLower.Columns.Add("扩展名", -2, HorizontalAlignment.Left);
            //

            lstHD.View = View.LargeIcon;
            lstLower.View = View.LargeIcon;
            lstHD.LargeImageList = LargImages;
            lstLower.LargeImageList = LargImages;
            lstHD.SmallImageList = SmallImages;
            lstLower.SmallImageList = SmallImages;
                        tabBookResource.SelectTab(0);
            _FilInfoType = EnumFileInfoType.ALL;
            _ResourceType = EnumFileResourceType.HDRESOURCE;
            this.TabIndexChanged += tabBookResource_SelectedIndexChanged;
        }


        public void SetBookID(string BookID)
        {
            if (!this._BookID.Equals(BookID))
            {
                this._BookID = this._BookID;
            }
        }

        private void tabBookResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ResourceType = tabBookResource.SelectedIndex == 0
                ? EnumFileResourceType.HDRESOURCE
                : EnumFileResourceType.LOWRESOURCE;

        }
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="items"></param>
        public void LoadData(List<FTPFileInfo> items,EnumFileInfoType resourceType )
        {
            _DataSource = items;
            _FilInfoType = resourceType;
            ListView _viewHandle = null;
            if (_FilInfoType == EnumFileInfoType.ALL)
            {
                _viewHandle = lstHD;
            }
            else
            {
                _viewHandle = lstLower;
            }
            _viewHandle.Items.Clear();
            if (_DataSource != null && _DataSource.Count > 0)
            {
                foreach (var item in _DataSource)
                {
                    var item1 = new ListViewItem(item.FileName, 0);
                    if (item.IsFile)
                    {
                        item1.SubItems.Add(Path.GetExtension(item.FileName));
                    }
                    else
                    {
                        item1.SubItems.Add("");
                    }
                    _viewHandle.Items.Add(item.FileID, item.FileName, 0);
                }
                _viewHandle.Refresh();
            }
        }

        public void LoadData()
        {
            RaiseOpenDirectoryEvent(_BookID,_FilInfoType,"",_SearchName);
        }
        private void lstHD_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button== MouseButtons.Right)
                Menu.Show(PointToScreen(e.Location));
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == menuItemCreateDir)
            {
                return;
            }
            if (e.ClickedItem == menuItemDownload)
            {
                return;
            }
            if (e.ClickedItem == menuItemOpen)
            {
                return;
            }


        }
    }
}
