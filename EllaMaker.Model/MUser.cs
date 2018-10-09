using GalaSoft.MvvmLight;

namespace EllaMaker.FTP.Messages
{
    public  class MUser
     {
         private string _Name;
        private string _Password;
        public  string Name
        {
            get
            {
                return _Name; 
            }
            set
            {
                _Name = value;  
                //RaisePropertyChanged(()=>Name);
            }
        }
         public string Password
         {
             get { return _Password; }
             set
             {
                 _Password = value;
                 //RaisePropertyChanged(() => Password);

             }
         }
     }
}
