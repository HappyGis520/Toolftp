using System;

namespace EllaMaker.FTP.Services
{
    internal  abstract class APIBase
    {
        protected String _ServiceIP;
        protected int _ServicePort;

        public APIBase(string Ip,int Port)
        {
            this._ServiceIP = Ip;
            this._ServicePort = Port;
        }
        
    }
}
