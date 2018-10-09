namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

	/// <summary>
	///************************************
	/// 创 建 者: 王建军
	/// 联系方式：wangjianjun@ellamaker.cn
	/// 创建时间: 15:11 2018/7/18
	/// 描    述：添加权限请求消息
	/// *************************************
	/// </summary>
	/*添加权限请求消息*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="添加权限请求消息",description="添加权限请求消息") public class AppendPermissionParam extends ella.util.RequestModelBase
	public class AppendPermissionParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="权限类别",dataType="java.lang.Byte", name="level",example="10",required=true) private System.Nullable<sbyte> permissionType;
		private sbyte? permissionType;
		public virtual sbyte? PermissionType
		{
			get
			{
				return permissionType;
			}
			set
			{
				permissionType = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="权限值",dataType="java.lang.Integer", name="PermissionValue",example="10",required=true) private System.Nullable<int> PermissionValue;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private int? PermissionValue_Renamed;
		public virtual int? PermissionValue
		{
			get
			{
				return PermissionValue_Renamed;
			}
			set
			{
				PermissionValue_Renamed = value;
			}
		}

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="父级编号",dataType="java.lang.String",name="parent",example="wangjj",required=true) private String parent;
		private string parent;
		public virtual string Parent
		{
			get
			{
				return parent;
			}
			set
			{
				parent = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="名称",dataType="java.lang.String",name="name",example="wangjj",required=true) private String name;
		private string name;
		public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否只是一个标签",dataType="java.lang.Boolean", name="islabel",example="1",required=true) private System.Nullable<bool> islabel;
		private bool? islabel;
		public virtual bool? Islabel
		{
			get
			{
				return islabel;
			}
			set
			{
				this.islabel = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否在界面上呈现",dataType="java.lang.Boolean",name="parent",example="UUID",required=true) private System.Nullable<bool> presented;
		private bool? presented;
		public virtual bool? Presented
		{
			get
			{
				return presented;
			}
			set
			{
				this.presented = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="备注",dataType="java.lang.String",name="memo",example="safdsafaf",required=true) private String memo;
		private string memo;
		public virtual string Memo
		{
			get
			{
				return memo;
			}
			set
			{
				memo = value;
			}
		}


	}

}