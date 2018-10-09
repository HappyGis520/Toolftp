using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.Model
{
    public class ChangeStatusWinPara
    {
        public bool IsFromTopBar { get; set; }
        public EnumDocStatusType newStatus { get; set; }
        public StatusList shareList { get; set; } = new StatusList();
        public StatusList syncList { get; set; } = new StatusList();
    }
}
