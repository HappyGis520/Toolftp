using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.Model
{
    public class MResourceItem
    {
        public string Name { get; set; }
        public string Pic { get; set; }
        public DateTime UpdateTime { get; }
        public String UpLoadUserName { get; }
        public double FileSize { get; }
        public String Creater { get; }
        public MResourceItem(String Name,string PicURI,DateTime UpdateTime,String Creater,double FileSize)
        {
            this.Name = Name;
            this.Pic = PicURI;
            this.UpdateTime = UpdateTime;
            this.Creater = Creater;
        }

    }

}