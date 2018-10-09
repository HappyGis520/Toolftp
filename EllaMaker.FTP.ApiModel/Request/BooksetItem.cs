/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 15:28 2018/7/25
/// 描    述：书集列表项
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

	/*书集列表项*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="书集列表项",description="书集列表项，通常用于用户界面，书集选择下拉框") public class BooksetItem
	public class BooksetItem
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="唯一识别码",name="id",example="Wangjianjun",required=true) private String id;
		private string id;
		/*名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="名称",name="name",example="Wangjianjun",required=true) private String name;
		private string name;
		public virtual string Id
		{
			get
			{
				return id;
			}
			set
			{
				this.id = string.ReferenceEquals(value, null) ? null : value.Trim();
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
	}

}