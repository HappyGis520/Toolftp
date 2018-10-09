/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： FTPFileInfoListParam.cs
 * * 功   能：  获取文件或文件夹参数
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 13:41:01
 * * 修改记录： 
 * * 日期时间： 2018-09-25 13:41:01  修改人：王建军  创建
 * *******************************************************************/

using System;
using EllaMaker.FTP.Model.Enum;

namespace EllaMaker.FTP.Model.Request
{

    namespace ella.Messages
    {

        /// <summary>
        /// 获取文件或文件夹参数
        /// </summary>
        public class FTPFileInfoListParam
        {

            /// <summary>
            /// 
            /// </summary>
            /// <param name="resourceDirID"></param>
            /// <param name="fileInfoType"></param>
            /// <param name="fileName"></param>
            public FTPFileInfoListParam(String BookID, string resourceDirID,EnumFileInfoType fileInfoType,string fileName)
            {
                this.ResourceDirID = resourceDirID;
                this.FileInfoType = fileInfoType;
                this.FileName = fileName;
            }
            /// <summary>
            /// 名称关键字
            /// </summary>
            public virtual string FileName { get; set; }
            /// <summary>
            /// 类别
            /// </summary>
            public EnumFileInfoType FileInfoType { get; set; }
            /// <summary>
            /// 资源文件夹编号
            /// </summary>
            public string ResourceDirID
            {
                get; set; }

        }

    }

}
