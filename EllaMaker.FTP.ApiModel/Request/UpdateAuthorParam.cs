/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 15:00 2018/7/23
/// 描    述：更新作者信息请求参数
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

	/*更新作者信息请求参数*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="更新作者参数",description="更新作者信息请求参数") public class UpdateAuthorParam extends ella.util.RequestModelBase
	public class UpdateAuthorParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="更新对象的ID号",name="ID",example="Wangjianjun",required=true) private String ID;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string ID_Renamed;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="更新的名称",name="name",example="Wangjianjun",required=true) private String name;
		private string name;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="更新后的联系电话",name="phone",example="Wangjianjun",required=true) private String phone;
		private string phone;

		public virtual string ID
		{
			get
			{
				return ID_Renamed;
			}
			set
			{
				ID_Renamed = value;
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


		public virtual string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				this.phone = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}

	}

}