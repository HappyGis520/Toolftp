using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EllaMaker.FTP.Core;
using EllaMaker.FTP.Model;
using EllaMaker.FTP.Model.Request.ella.Messages;

namespace EllaMaker.FTP.Services
{
    internal class BookAPIs:Singleton<BookAPIs>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public ResponseModelBase<BookListByPage> AllBookListByPage(BookListByPageParam param)
        {

                WebApiUtil.Url = $"{Utility.URL}/{ControllerNames.Instance.BOOK}";
                var obj = WebApiUtil.PostAPI<ResponseModelBase<BookListByPage>>(ControllerNames.Instance.BOOK_AllBook, param);
                return obj;

        }




    }
}
