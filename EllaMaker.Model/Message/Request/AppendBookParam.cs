/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： AppendBookParam.cs
 * * 功   能：  添加图书参数
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 13:44:26
 * * 修改记录： 
 * * 日期时间： 2018-09-25 13:44:26  修改人：王建军  创建
 * *******************************************************************/
using System;

namespace EllaMaker.FTP.Model
{

    /// <summary>
    /// 添加图书参数
    /// </summary>
	public class AppendBookParam : RequestModelBase
	{
		private string publisherid;
		/*系列书/书集编号*/
		private string bookSetid;
		/*作者编号*/
		private string authorid;
		/*ISBN*/
		private string isbn;
		/*图书名称*/
		private string bookName;
		/*价格*/
		private decimal price;
		/*价格*/
		private DateTime publicationTime;
		public virtual string Publisherid
		{
			get
			{
				return publisherid;
			}
			set
			{
				this.publisherid = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}
		public virtual string BookSetid
		{
			get
			{
				return bookSetid;
			}
			set
			{
				this.bookSetid = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Authorid
		{
			get
			{
				return authorid;
			}
			set
			{
				this.authorid = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Isbn
		{
			get
			{
				return isbn;
			}
			set
			{
				this.isbn = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string BookName
		{
			set
			{
				bookName = value;
			}
			get
			{
				return bookName;
			}
		}

		public virtual decimal Price
		{
			get
			{
				return price;
			}
			set
			{
				this.price = value;
			}
		}


		public virtual DateTime PublicationTime
		{
			get
			{
				return publicationTime;
			}
			set
			{
				this.publicationTime = value;
			}
		}


	}

}