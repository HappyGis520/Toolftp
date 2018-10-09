using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using EllaMaker.FTP.Model;

namespace EllaMaker.FTP.ViewModel
{
    public  class LoginViewModel:ViewModelBase
    {
        private MUser _MUser;

        public string UserName
        {
            get { return _MUser.Name; }
            set
            {
                _MUser.Name = value;
                RaisePropertyChanged(()=>UserName);
            }
        }
        public LoginViewModel()
        {
            _MUser = new MUser();
            _MUser.Name = "wangjj";
        }
    }
}
