using System.ComponentModel;

/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： EnumMainToolButton.cs
 * * 功   能：  主工具栏命令枚举
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-10-15 10:14:40
 * * 修改记录： 
 * * 日期时间： 2018-10-15 10:14:40  修改人：王建军  创建
 * *******************************************************************/

namespace EllaMaker.FTP.UserControls
{
    /// <summary>
    /// 主工具栏命令枚举
    /// </summary>
    public enum EnumMainToolButton
    {
        [Description("未指定")]
        /// <summary>
        /// 未指定
        /// </summary>
        UNKNOW = 0,
        /// <summary>
        /// 加载图书列表
        /// </summary>
        [Description("加载图书列表")]
        LOADBOOK =1,
        /// <summary>
        /// 加载动画书列表
        /// </summary>
        [Description("加载动画书列表")]
        LOADEBOOK =2 ,
        /// <summary>
        /// 加载个人资源
        /// </summary>
        [Description("加载个人资源")]
        LOADPERSON =3 ,
        /// <summary>
        /// 加载共享资源
        /// </summary>
        [Description("加载共享资源")]
        LOADSHARED =4 ,
        /// <summary>
        /// 打开传输列表
        /// </summary>
        [Description("打开传输列表")]
        LOADTRANSLIST =5,
        /// <summary>
        /// 退出程序
        /// </summary>
        [Description("退出程序")]
        EXISIT =6,
        /// <summary>
        /// 最小化窗口
        /// </summary>
        [Description("最小化窗口")]
        MINWINDOW =7,
        /// <summary>
        /// 最大化窗口
        /// </summary>
        [Description("最大化窗口")]
        MAXWINDOW =8,
        /// <summary>
        /// 显示菜单
        /// </summary>
        [Description("显示菜单")]
        SHOWMENU = 9
    }
}