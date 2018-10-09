using System;

namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="添加原版书参数",description="请求添加原版书使用的参数") public class AppendBookParam extends ella.util.RequestModelBase
	public class AppendBookParam : RequestModelBase
	{
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
		/*价格*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="发行时间",name="publicationTime",example="1",required=true) private java.util.Date publicationTime;
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