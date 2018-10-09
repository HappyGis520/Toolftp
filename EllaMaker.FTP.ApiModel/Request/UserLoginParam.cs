namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="用户登录参数",description="用户登录系统时采用的参数") public class UserLoginParam
	public class UserLoginParam
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="账户名称",name="UserName",example="Wangjianjun",required=true) private String UserName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string UserName_Renamed;
		public virtual string UserName
		{
			get
			{
				return UserName_Renamed;
			}
			set
			{
				UserName_Renamed = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="账户密码",name="Password",example="Wangjianjun",required=true) private String Password;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string Password_Renamed;
		public virtual string Password
		{
			get
			{
				return Password_Renamed;
			}
			set
			{
				Password_Renamed = value;
			}
		}
	}

}