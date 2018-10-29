using EllaMaker.FTP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllaMaker.FTP.Core;
using EllaMaker.FTP.Services;

namespace EllaMaker.FTP.BLL
{
    internal class BLLBook:BLLBase
    {
        BookAPIs _Api = null;
        
        public BLLBook()
        {
            _Api = new BookAPIs(this.ServicHostIP, ServicePort);


        }
        
        /// <summary>
        /// 加载图书列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public  BookListByPage LoadBookList(int pageIndex,int pageSize)
        {
            BookListByPageParam param = new BookListByPageParam();
            param.PageSize = pageSize;
            param.PageIndex = pageIndex;
            var obj = _Api.AllBookListByPage(param);
            if (obj.Successful)
                return obj.Data;
            return null;

        }


    }
}
