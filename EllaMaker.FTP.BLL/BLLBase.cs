using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllaMaker.FTP.BLL
{
    public class BLLBase
    {
        /// <summary>
        /// 服务端IP地址
        /// </summary>
        protected string    ServicHostIP
        {
            get { return "192.168.1.114"; }
        }
        /// <summary>
        /// 服务端端口
        /// </summary>
        protected int ServicePort
        {
            get { return 8111; }
        }
    }
}
