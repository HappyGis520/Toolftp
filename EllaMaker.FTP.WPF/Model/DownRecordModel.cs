using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.Model
{
    public class DownRecordModel
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public string SessionId { get; set; }
    }
}
