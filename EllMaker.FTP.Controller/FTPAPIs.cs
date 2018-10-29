using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllaMaker.FTP.Core;
using EllaMaker.FTP.Model;
using EllaMaker.FTP.Model.Request.ella.Messages;

namespace EllaMaker.FTP.Services
{
    internal   class FTPAPIs:APIBase
    {

        #region 路由常量
        public const string FTP = "FTP";
        public const string FTP_LIST = "List";
        public const string FTP_LISTROOT = "ListRoot";
        #endregion
        public FTPAPIs(string ip,int Port ):base(ip,Port)
        {

        }



        /// <summary>
        /// 获取所有文件/文件夹信息
        /// </summary>
        /// <param name="FileInfoType">文件，文件夹,所有</param>
        /// <param name="DirectID">如果为非资源根目录，请指定目录唯一编号</param>
        /// <param name="SearchStr">搜索关键字</param>
        /// <returns></returns>
        public ResponseModelBase<List<FTPFileInfo>> AllFileInfos(FTPFileInfoListParam param)
        {

            WebApiUtil.Url = $"{_ServiceIP}:{_ServicePort}/{FTP}";
            var obj = WebApiUtil.PostAPI<ResponseModelBase<List<FTPFileInfo>>>(FTP_LIST, param);
            return obj;
        }
        /// <summary>
        /// 获取资源根目录文件/文件夹信息
        /// /FTP/ListRoot
        /// </summary>
        /// <param name="FileInfoType">文件，文件夹,所有</param>
        /// <param name="DirectID">如果为非资源根目录，请指定目录唯一编号</param>
        /// <param name="SearchStr">搜索关键字</param>
        /// <returns></returns>
        public ResponseModelBase<List<FTPFileInfo>> AllFileInfosInRoot(FileInfoListInRootByParam param)
        {

            WebApiUtil.Url = $"{_ServiceIP}:{_ServicePort}/{FTP}";
            var obj = WebApiUtil.PostAPI<ResponseModelBase<List<FTPFileInfo>>>(FTP_LISTROOT, param);
            return obj;
        }
    }
}
