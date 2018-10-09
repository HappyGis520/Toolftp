/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： AddEbookParam.cs
 * * 功   能：  添加动画书参数
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 13:43:46
 * * 修改记录： 
 * * 日期时间： 2018-09-25 13:43:46  修改人：王建军  创建
 * *******************************************************************/
using System.Collections.Generic;

namespace EllaMaker.FTP.Model
{
    /// <summary>
    /// 添加动画书参数
    /// 
    /// </summary>
    public class AddEbookParam : RequestModelBase
	{

		private string bookid;
		/*电子书名称*/
		private string name;
		/*电子书拼音名称*/
		private string pinyin;
		/*创建人编号*/
		private string creatorid;
		/*封面地址*/
		private string coverpng;
		/*支持阅读模式列表*/
		private int readmodels;
		/*支持动画书产品列表*/
		private int producttypes;
		/*电子书参与者信息列表*/
		private IList<UserEbookRelation> authorralations;
		/*电子书页面信息列表*/
		private IList<EbookPage> pages;
		public virtual string Bookid
		{
			get
			{
				return bookid;
			}
			set
			{
				this.bookid = value;
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
				this.name = value;
			}
		}

		public virtual string Pinyin
		{
			get
			{
				return pinyin;
			}
			set
			{
				this.pinyin = value;
			}
		}

		public virtual string Creatorid
		{
			get
			{
				return creatorid;
			}
			set
			{
				this.creatorid = value;
			}
		}
		public virtual string Coverpng
		{
			get
			{
				return coverpng;
			}
			set
			{
				this.coverpng = value;
			}
		}

		public virtual int Readmodels
		{
			get
			{
				return readmodels;
			}
			set
			{
				this.readmodels = value;
			}
		}

		public virtual int Producttypes
		{
			get
			{
				return producttypes;
			}
			set
			{
				this.producttypes = value;
			}
		}

		public virtual IList<UserEbookRelation> Authorralations
		{
			get
			{
				return authorralations;
			}
			set
			{
				this.authorralations = value;
			}
		}

		public virtual IList<EbookPage> Pages
		{
			get
			{
				return pages;
			}
			set
			{
				this.pages = value;
			}
		}

	}

}