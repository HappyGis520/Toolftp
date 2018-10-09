namespace EllaMaker.Api
{

	/// <summary>
	///************************************
	/// 创 建 者: 王建军
	/// 联系方式：wangjianjun@ellamaker.cn
	/// 创建时间: 11:37 2018/7/26
	/// 描    述：原版书信息描述对象，关联多张表数据的对象
	/// *************************************
	/// </summary>
	public class BookItem
	{
		protected internal string id;
		protected internal string isbn;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		protected internal string Name_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		protected internal decimal Price_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string PublisherID_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string PublisherName_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string AuthorID_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string AuthorName_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string BookSetID_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string BookSetName_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private int EBookCount_Renamed;
		protected internal bool? enabled;
		protected internal bool? visibled;
		public virtual string getid()
		{
			return id;
		}
		public virtual void setid(string id)
		{
			this.id = string.ReferenceEquals(id, null) ? null : id.Trim();
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
		public virtual string Name
		{
			get
			{
				return Name_Renamed;
			}
			set
			{
				Name_Renamed = value;
			}
		}
		public virtual string PublisherID
		{
			get
			{
				return PublisherID_Renamed;
			}
			set
			{
				PublisherID_Renamed = value;
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
		public virtual string AuthorName
		{
			get
			{
				return AuthorName_Renamed;
			}
			set
			{
				AuthorName_Renamed = value;
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
		public virtual string AuthorID
		{
			get
			{
				return AuthorID_Renamed;
			}
			set
			{
				AuthorID_Renamed = value;
			}
		}

		public virtual string BookSetID
		{
			get
			{
				return BookSetID_Renamed;
			}
			set
			{
				BookSetID_Renamed = value;
			}
		}

		public virtual bool? Enabled
		{
			get
			{
				return enabled;
			}
			set
			{
				this.enabled = value;
			}
		}
		public virtual bool? getvisibled()
		{
			return visibled;
		}
		public virtual decimal Price
		{
			get
			{
				return Price_Renamed;
			}
			set
			{
				Price_Renamed = value;
			}
		}
	}

}