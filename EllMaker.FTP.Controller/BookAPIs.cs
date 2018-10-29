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
    internal class BookAPIs:APIBase
    {

        #region 路由常量
        public const string BOOK = "Book";
        public const string BOOK_AllBook = "AllBooksByPage";

        public BookAPIs(String ServiceIP,int ServicePort):base(ServiceIP,ServicePort)
        {
        }
        #endregion  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public ResponseModelBase<BookListByPage> AllBookListByPage( BookListByPageParam param)
        {

                WebApiUtil.Url = $"{_ServiceIP}:{_ServicePort}/{BOOK}";
                var obj = WebApiUtil.PostAPI<ResponseModelBase<BookListByPage>>(BOOK_AllBook, param);
                return obj;

        }




    }
}
