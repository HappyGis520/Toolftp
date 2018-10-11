using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace EllaMaker.FTP.ViewModel
{
    /// <summary>
    /// 主工具栏命令枚举
    /// </summary>
    public enum EnumMainToolButton
    {
        /// <summary>
        /// 加载图书列表
        /// </summary>
        [Description("加载图书列表")]
        LOADBOOK,
        /// <summary>
        /// 加载动画书列表
        /// </summary>
        [Description("加载动画书列表")]
        LOADEBOOK,
        /// <summary>
        /// 加载个人资源
        /// </summary>
        [Description("加载个人资源")]
        LOADPERSON,
        /// <summary>
        /// 加载共享资源
        /// </summary>
        [Description("加载共享资源")]
        LOADSHARED,
        /// <summary>
        /// 打开传输列表
        /// </summary>
        [Description("打开传输列表")]
        LOADTRANSLIST,
        /// <summary>
        /// 退出程序
        /// </summary>
        [Description("退出程序")]
        EXISIT,
        /// <summary>
        /// 最小化窗口
        /// </summary>
        [Description("最小化窗口")]
        MINWINDOW,
        /// <summary>
        /// 最大化窗口
        /// </summary>
        [Description("最大化窗口")]
        MAXWINDOW,
        /// <summary>
        /// 显示菜单
        /// </summary>
        [Description("显示菜单")]
        SHOWMENU
    }
}