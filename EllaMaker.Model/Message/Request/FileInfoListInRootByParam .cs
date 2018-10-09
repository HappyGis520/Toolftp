/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： FileInfoListInRootByParam .cs
 * * 功   能：  获取资源根目录下的文件或文件夹参数
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-26 09:03:51
 * * 修改记录： 
 * * 日期时间： 2018-09-26 09:03:51  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllaMaker.FTP.Model.Enum;

namespace EllaMaker.FTP.Model
{
    /// <summary>
    /// 获取资源根目录下的文件或文件夹参数
    /// </summary>
    public class FileInfoListInRootByParam
    {

        /// <summary>
        /// 动画书或图书编号
        /// </summary>
        private string bookID { get; set; }
        /// <summary>
        /// 资源类别
        /// </summary>
        private EnumFileResourceType resourceType;
        /// <summary>
        /// 名称关键字
        /// </summary>
        private string fileName { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        private EnumFileInfoType fileInfoType { get; set; }

        public FileInfoListInRootByParam()
        {
            
        }

        public FileInfoListInRootByParam(string bookID, EnumFileResourceType resourceType, string searchName,
            EnumFileInfoType fileInfoType)
        {
            this.bookID = bookID;
            this.resourceType = resourceType;
            this.fileInfoType = fileInfoType;
            this.fileName = searchName;
        }


    }
}
