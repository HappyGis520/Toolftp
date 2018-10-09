/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： FTPItem.cs
 * * 功   能：  FTP上传/下载项
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 09:22:29
 * * 修改记录： 
 * * 日期时间： 2018-09-25 09:22:29  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.Core.Entity
{
    // <summary>
    /// 正在上传列表
    /// </summary>
    public class FTPItem
    {
        /// <summary>
        /// true：上传 false：下载
        /// </summary>
        public bool IsUpload = true;
        /// <summary>
        /// SessionID
        /// </summary>
        public string SessionID { get; set; }

        /// <summary>
        /// 服务器文件路径
        /// </summary>
        public string ServerFilePath { get; set; }

        /// <summary>
        /// 客户端文件路径
        /// </summary>
        public string LocFilePath { get; set; }

        /// <summary>
        /// 是否续传
        /// </summary>
        public bool IsContinue { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        public FTPRunState RunState = FTPRunState.None;

        /// <summary>
        /// 是否已取消
        /// </summary>
        public bool CloseState { get; set; }
    }
}
