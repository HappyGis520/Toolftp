/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 15:37 2018/7/25
/// 描    述：添加书集参数
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="添加书集参数",description="请求添加原版书集使用的参数") public class AppendBooksetParam extends ella.util.RequestModelBase
	public class AppendBooksetParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社唯一标识码",name="publisherid",example="Wangjianjun",required=true) private String publisherid;
		private string publisherid;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="作者唯一标识码",name="authorid",example="Wangjianjun",required=true) private String authorid;
		private string authorid;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="书集名称",name="name",example="Wangjianjun",required=true) private String name;
		private string name;

		private decimal price;


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


		public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name = string.ReferenceEquals(value, null) ? null : value.Trim();
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


	}

}