using System.Collections.Generic;

namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
	/// <summary>
	///************************************
	/// 创 建 者: 王建军
	/// 联系方式：wangjianjun@ellamaker.cn
	/// 创建时间: 10:43 2018/7/26
	/// 描    述：分页获取的图书列表
	/// *************************************
	/// </summary>
	/*分页获取的图书列表*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="分页获取的图书列表",description="分页获取的图书列表") public class BookListByPage extends ListByPageParam
	public class BookListByPage : ListByPageParam
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="总记录数",name="recordCount",example="1000",required=true) private int recordCount;
		private int recordCount;
		public virtual int RecordCount
		{
			get
			{
				return recordCount;
			}
			set
			{
				this.recordCount = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="总页数",name="pageCount",example="100",required=true) private int pageCount;
		private int pageCount;
		public virtual int PageCount
		{
			get
			{
				return pageCount;
			}
			set
			{
				this.pageCount = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="图书对象集合",name="Items",example="Wangjianjun",required=true) private java.util.List<BookItem> Items;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private IList<BookItem> Items_Renamed;
		public virtual IList<BookItem> Items
		{
			set
			{
				Items_Renamed = value;
			}
			get
			{
				return Items_Renamed;
			}
		}
		public BookListByPage()
		{

		}
		public BookListByPage(BookListByPageParam param, IList<BookItem> items, int allRecordCount)
		{
			this.pageIndex = param.PageIndex;
			this.pageSize = param.PageSize;
			this.recordCount = allRecordCount;
			this.Items_Renamed = items;
			this.pageCount = (allRecordCount + param.pageSize - 1) / param.pageSize;
		}
	}

}