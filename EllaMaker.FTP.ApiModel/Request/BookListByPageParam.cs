namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

	/// <summary>
	///************************************
	/// 创 建 者: 王建军
	/// 联系方式：wangjianjun@ellamaker.cn
	/// 创建时间: 16:47 2018/7/26
	/// 描    述：分页获取图书列表的请求参数
	/// *************************************
	/// </summary>
	/*分页获取图书列表的请求参数*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="分页获取图书列表的请求参数",description="分页获取图书列表的请求参数") public class BookListByPageParam extends ListByPageParam
		public class BookListByPageParam : ListByPageParam
		{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="作者搜索关键字",name="SearchAuthorName",example="Wangjianjun",required=true) private String SearchAuthorName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
			private string SearchAuthorName_Renamed;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社搜索关键字",name="SearchPublisherName",example="Wangjianjun",required=true) private String SearchPublisherName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string SearchPublisherName_Renamed;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="书集搜索关键字",name="SearchBookSetName",example="Wangjianjun",required=true) private String SearchBookSetName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string SearchBookSetName_Renamed;
		public virtual string SearchAuthorName
		{
			get
			{
				return SearchAuthorName_Renamed;
			}
			set
			{
				SearchAuthorName_Renamed = value;
			}
		}


		public virtual string SearchPublisherName
		{
			get
			{
				return SearchPublisherName_Renamed;
			}
			set
			{
				SearchPublisherName_Renamed = value;
			}
		}


		public virtual string SearchBookSetName
		{
			get
			{
				return SearchBookSetName_Renamed;
			}
			set
			{
				SearchBookSetName_Renamed = value;
			}
		}




		}

}