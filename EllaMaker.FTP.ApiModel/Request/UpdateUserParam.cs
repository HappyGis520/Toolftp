namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="更新用户成员",description="请求更新用户成员使用的参数") public class UpdateUserParam extends ella.util.RequestModelBase
	public class UpdateUserParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="成员ID",name="id") private String id;
		private string id;
		/*角色ID*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="角色ID",name="roleid") private String roleid;
		private string roleid;
		/*用户名*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="用户名",name="name") private String name;
		private string name;
		/*联系方式*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="联系方式",name="phone") private String phone;
		private string phone;
		/*密码*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="密码",name="password") private String password;
		private string password;
		/*头像*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="头像",name="face") private String face;
		private string face;
		/*是否启用*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否启用",name="enabled") private boolean enabled;
		private bool enabled;

		public virtual string Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return id;
			}
		}


		public virtual string Roleid
		{
			get
			{
				return roleid;
			}
			set
			{
				this.roleid = value;
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
				this.name = value;
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
				this.phone = value;
			}
		}


		public virtual string Password
		{
			get
			{
				return password;
			}
			set
			{
				this.password = value;
			}
		}


		public virtual string Face
		{
			get
			{
				return face;
			}
			set
			{
				this.face = value;
			}
		}



		public virtual bool Enabled
		{
			set
			{
				enabled = value;
			}
			get
			{
				return enabled;
			}
		}

	}

}