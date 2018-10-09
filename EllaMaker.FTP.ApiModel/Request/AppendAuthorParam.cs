/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 14:56 2018/7/23
/// 描    述：新增作者请求参数
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
	/*新增作者请求参数*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="新增作者请求参数",description="新增作者请求参数") public class AppendAuthorParam extends ella.util.RequestModelBase
	public class AppendAuthorParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="名称",name="name",required=true,example = "wangjj",hidden=false) private String name;
		private string name;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="用户名",name="phone",example="13777885123") private String phone;
		private string phone;

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