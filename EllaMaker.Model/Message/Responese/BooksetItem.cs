/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： BooksetItem.cs
 * * 功   能：  书集列表项
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 13:48:37
 * * 修改记录： 
 * * 日期时间： 2018-09-25 13:48:37  修改人：王建军  创建
 * *******************************************************************/
namespace EllaMaker.FTP.Model
{

    /// <summary>
    /// 书集列表项
    /// </summary>
    public class BooksetItem
	{
		private string id;
		/*名称*/
		private string name;
		public virtual string Id
		{
			get
			{
				return id;
			}
			set
			{
				this.id = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}
		public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}
	}

}