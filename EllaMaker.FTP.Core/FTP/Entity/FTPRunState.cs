/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： FTPRunState.cs
 * * 功   能：  FTP运行状态
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-08-31 14:31:18
 * * 修改记录： 
 * * 日期时间： 2018-08-31 14:31:18  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.Core.Entity
{
    /// <summary>
    /// FTP运行状态
    /// </summary>
    public enum FTPRunState
    {
        /// <summary>
        /// 无状态等待执行
        /// </summary>
        None,
        /// <summary>
        /// 正在跑
        /// </summary>
        Run,
        /// <summary>
        /// 中断
        /// </summary>
        Abort,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 出错状态
        /// </summary>
        Error
        /// <summary>
        /// 等待关闭
        /// </summary>
        //WaitingCloseing//,
        /// <summary>
        /// 已关闭 直接移除
        /// </summary>
        //Closed
    }
}
