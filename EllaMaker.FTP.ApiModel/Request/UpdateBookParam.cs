using System;

namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="编辑原版书参数",description="请求添加原版书使用的参数") public class UpdateBookParam extends ella.util.RequestModelBase
	public class UpdateBookParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="图书唯一标号",name="id",example="1",required=true) private String id;
		private string id;
		public virtual string getid()
		{
			return id;
		}
		public virtual void setid(string id)
		{
			this.id = string.ReferenceEquals(id, null) ? null : id.Trim();
		}
		/*出版社编号*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社编号",name="publisherid",example="1",required=true) private String publisherid;
		private string publisherid;
		/*系列书/书集编号*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="书集编号",name="bookSetid",example="1",required=true) private String bookSetid;
		private string bookSetid;
		/*作者编号*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="作者编号",name="authorid",example="1",required=true) private String authorid;
		private string authorid;
		/*ISBN*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="ISBN",name="isbn",example="1",required=true) private String isbn;
		private string isbn;
		/*图书名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="图书名称",name="bookName",example="Wangjianjun",required=true) private String bookName;
		private string bookName;
		/*价格*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="价格",name="price",example="1",required=true) private java.math.BigDecimal price;
		private decimal price;

		private DateTime publicationTime;
		/*是否可用*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否可用",name="enabled",example="1",required=true) private System.Nullable<bool> enabled;
		private bool? enabled;
		/*是否可见*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否可见",name="visibled",example="1",required=true) protected System.Nullable<bool> visibled;
		protected internal bool? visibled;
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

		public virtual void setvisibled(bool? enabled)
		{
			this.visibled = enabled;
		}
	}

}