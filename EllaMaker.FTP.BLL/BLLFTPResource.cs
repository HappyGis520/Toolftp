using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllaMaker.FTP.Model;
using EllaMaker.FTP.Services;
using EllaMaker.FTP.Model.Enum;
using EllaMaker.FTP.Model.Request.ella.Messages;

namespace EllaMaker.FTP.BLL
{
    internal class BLLFTPResource:BLLBase
    {


        FTPAPIs _Api = null;

        public BLLFTPResource()
        {
            _Api = new FTPAPIs(this.ServicHostIP, this.ServicePort);
        }
        /// <summary>
        /// 获取指定图书或动画书资源根目录信息
        /// </summary>
        /// <param name="BookID"></param>
        /// <returns></returns>
        public List<FTPFileInfo> RootDir(string BookID)
        {
            return null;
        }


        public List<FTPFileInfo> LoadFTPResource(String bookID,EnumFileInfoType resourceType,String directoryID,String SearchName)
        {
           var _result = _Api.AllFileInfos(new FTPFileInfoListParam(bookID,directoryID,resourceType, SearchName));
            if (_result.Successful)
            {
                return _result.Data;
            }
            return null;
        }

        public List<FTPFileInfo> LoadFTPResourceInRoot(String bookID,EnumFileInfoType fileInfoType ,EnumFileResourceType resourceType,string searchName)
        {
            var _param  = new FileInfoListInRootByParam(bookID,resourceType,searchName,fileInfoType);
            var _result =  _Api.AllFileInfosInRoot(_param);
            if (_result.Successful)
                return _result.Data;
            return null;
        }
    }
}
