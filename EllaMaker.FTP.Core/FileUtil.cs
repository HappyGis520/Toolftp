/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： FileUtil.cs
 * * 功   能：  文件操作相关功能封装
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-08-31 14:26:46
 * * 修改记录： 
 * * 日期时间： 2018-08-31 14:26:46  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EllaMaker.FTP.Core;

namespace EllaMaker.FTP.Core
{
    public class FileUtil
    {
        public static string NewPath(int companyId)
        {
            var path = $"/{companyId}/{DateTime.Now.ToString("yyMM/dd")}/{Guid.NewGuid().ToString("n")}/";
            return path;
        }

        public static string GetFileDir()
        {
       

            string fileDir = System.Configuration.ConfigurationManager.AppSettings["FileDir"];
         
            return fileDir;
        }

        public static string GetFileName(string path)
        {
            var idx = path.LastIndexOf('/');
            return path.Substring(idx + 1);
        }
    }
}
