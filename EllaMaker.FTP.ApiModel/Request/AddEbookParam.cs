using System.Collections.Generic;

namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
    /// <summary>
    /// 添加电子书书参数
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
		//private IList<UserEbookRelation> authorralations;
		/*电子书页面信息列表*/
		//private IList<EbookPage> pages;

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

		////public virtual IList<UserEbookRelation> Authorralations
		//{
		//	get
		//	{
		//		return authorralations;
		//	}
		//	set
		//	{
		//		this.authorralations = value;
		//	}
		//}

		////public virtual IList<EbookPage> Pages
		//{
		//	get
		//	{
		//		return pages;
		//	}
		//	set
		//	{
		//		this.pages = value;
		//	}
		//}

	}

}