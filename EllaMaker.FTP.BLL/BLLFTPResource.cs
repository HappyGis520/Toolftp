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
    internal class BLLFTPResource
    {
        public List<FTPFileInfo> LoadFTPResource(String bookID,EnumFileInfoType resourceType,String directoryID,String SearchName)
        {
           var _result =  FTPAPIs.Instance.AllFileInfos(new FTPFileInfoListParam(bookID,directoryID,resourceType, SearchName));
            if (_result.Successful)
            {
                return _result.Data;
            }
            return null;
        }

        public List<FTPFileInfo> LoadFTPResourceInRoot(String bookID,EnumFileInfoType fileInfoType ,EnumFileResourceType resourceType,string searchName)
        {
            var _param  = new FileInfoListInRootByParam(bookID,resourceType,searchName,fileInfoType);
            var _result =  FTPAPIs.Instance.AllFileInfosInRoot(_param);
            if (_result.Successful)
                return _result.Data;
            return null;
        }
    }
}
