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
		public string _BookName;
		/*出版社名称*/
		public string _PublisherName;
		/*图书系列名称*/
		private string _BookSetName;
		/*关联电子书数量*/
		private int _EBookCount;
		/*是否可见*/
		private bool _Visibled;
		public  string Isbn
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
				return _BookName;
			}
			set
			{
				this._BookName = value;
			}
		}


		public  string PublisherName
		{
			get
			{
				return _PublisherName;
			}
			set
			{
                _PublisherName = value;
			}
		}


		public  string BookSetName
		{
			get
			{
				return _BookSetName;
			}
			set
			{
				_BookSetName = value;
			}
		}


		public  int EBookCount
		{
			get
			{
				return _EBookCount;
			}
			set
			{
				this._EBookCount = value;
			}
		}


		public  bool Visibled
		{
			get
			{
				return _Visibled;
			}
			set
			{
				_Visibled = value;
			}
		}

	}

}