using System;
using GalaSoft.MvvmLight;

namespace EllaMaker.FTP.View
{
    public class User:ObservableObject
    {
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

        private String _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                RaisePropertyChanged(() => Password);
            }
        }

    }

}
