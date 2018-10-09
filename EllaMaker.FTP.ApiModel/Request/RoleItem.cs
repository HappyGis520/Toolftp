namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
	/// <summary>
	///************************************
	/// 创 建 者: 王建军
	/// 联系方式：wangjianjun@ellamaker.cn
	/// 创建时间: 9:25 2018/8/16
	/// 描    述：
	/// *************************************
	/// </summary>
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="RoleItem",description="角色名称+ID信息") public class RoleItem
	public class RoleItem
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="id",name="id",example="Wangjianjun",required=true) private String id;
		private string id;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="角色名称",name="name",example="管理员",required=true) private String name;
		private string name;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="角色类别",name="roletype",example="管理员",required=true) private System.Nullable<sbyte> roletype;
		private sbyte? roletype;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="角色枚举值",name="rolevalue",example="10",required=true) private System.Nullable<int> rolevalue;
		private int? rolevalue;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否内置角色",name="allowedit",example="false",required=true) private boolean allowedit;
		private bool allowedit;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="可用级别",name="behindlevel",example="10",required=true) private System.Nullable<sbyte> behindlevel;
		private sbyte? behindlevel;

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


		public virtual int? Rolevalue
		{
			get
			{
				return rolevalue;
			}
			set
			{
				value = value;
			}
		}

		public virtual sbyte? Roletype
		{
			get
			{
				return roletype;
			}
			set
			{
				this.roletype = value;
			}
		}


		public virtual bool? Allowedit
		{
			get
			{
				return allowedit;
			}
			set
			{
				this.allowedit = value.Value;
			}
		}


		public virtual sbyte? Behindlevel
		{
			get
			{
				return behindlevel;
			}
		}
	}

}