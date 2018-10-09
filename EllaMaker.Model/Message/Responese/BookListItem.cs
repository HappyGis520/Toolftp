/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： BookListItem.cs
 * * 功   能：  图书集合项
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 13:48:16
 * * 修改记录： 
 * * 日期时间： 2018-09-25 13:48:16  修改人：王建军  创建
 * *******************************************************************/

namespace EllaMaker.FTP.Model
{
    /// <summary>
    /// 图书集合项
    /// </summary>
	public class BookListItem
	{
		private string isbn;
		/*图书名称*/
		public string bookName;
		/*出版社名称*/
		public string PublisherName_Renamed;
		/*图书系列名称*/
		private string BookSetName_Renamed;
		/*关联电子书数量*/
		private int EBookCount_Renamed;
		/*是否可见*/
		private bool Visibled_Renamed;
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
			get
			{
				return bookName;
			}
			set
			{
				this.bookName = value;
			}
		}


		public virtual string PublisherName
		{
			get
			{
				return PublisherName_Renamed;
			}
			set
			{
				PublisherName_Renamed = value;
			}
		}


		public virtual string BookSetName
		{
			get
			{
				return BookSetName_Renamed;
			}
			set
			{
				BookSetName_Renamed = value;
			}
		}


		public virtual int EBookCount
		{
			get
			{
				return EBookCount_Renamed;
			}
			set
			{
				this.EBookCount_Renamed = value;
			}
		}


		public virtual bool Visibled
		{
			get
			{
				return Visibled_Renamed;
			}
			set
			{
				Visibled_Renamed = value;
			}
		}

	}

}