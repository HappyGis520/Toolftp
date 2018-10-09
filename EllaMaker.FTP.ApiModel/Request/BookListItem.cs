/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 17:45 2018/7/24
/// 描    述：图书集合项
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="图书集合项",description="后台管理图书列表中的每一项") public class BookListItem
	public class BookListItem
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="ISBN",name="isbn",example="Wangjianjun",required=true) private String isbn;
		private string isbn;
		/*图书名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="图书名称",name="bookName",example="Wangjianjun",required=true) public String bookName;
		public string bookName;
		/*出版社名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社名称",name="PublisherName",example="Wangjianjun",required=true) public String PublisherName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		public string PublisherName_Renamed;
		/*图书系列名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="图书系列名称",name="BookSetName",example="Wangjianjun",required=true) private String BookSetName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string BookSetName_Renamed;
		/*关联电子书数量*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="关联电子书数量",name="EBookCount",example="2",required=true) private int EBookCount;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private int EBookCount_Renamed;
		/*是否可见*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否可见",name="Visibled",example="1",required=true) private boolean Visibled;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
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