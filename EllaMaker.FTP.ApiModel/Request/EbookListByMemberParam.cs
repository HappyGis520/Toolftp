namespace EllaMaker.Api
{
	using PageArg = ella.entity.Args.PageArg;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="根据成员查询电子书列表",description="请求根据成员查询电子书列表使用的参数") public class EbookListByMemberParam extends ella.entity.Args.PageArg
	public class EbookListByMemberParam : PageArg
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="成员ID",name="userid") private String userid;
		private string userid;

		public virtual string Userid
		{
			get
			{
				return userid;
			}
			set
			{
				this.userid = value;
			}
		}

	}

}