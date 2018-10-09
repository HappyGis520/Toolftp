namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
	/// <summary>
	///************************************
	/// 创 建 者: 王建军
	/// 联系方式：wangjianjun@ellamaker.cn
	/// 创建时间: 19:44 2018/8/15
	/// 描    述：
	/// *************************************
	/// </summary>

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="PermissionItem",description="权限集合项，描述权限") public class PermissionItem
	public class PermissionItem
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="唯一标识码",name="id",example="UUID",required=true) private String id;
		private string id;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="权限类别;权限类别，根据权限对功能的影响，分为不依赖于具体某本书的：动画书管理类，图书管理类，动画书编辑类，图书编辑类，\n" + " * 用八个二进制位，从最高位开始排，最后四位保留；例：动画书管理类的，为1000 0000 即用128表示",name="parent",example="UUID",required=true) private System.Nullable<sbyte> permissiontype;
		private sbyte? permissiontype;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="权限值",name="permissionvalue",example="1",required=true) private System.Nullable<int> permissionvalue;
		private int? permissionvalue;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否只是一个标签",name="islabel",example="1",required=true) private System.Nullable<sbyte> islabel;
		private sbyte? islabel;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否在界面上呈现",name="parent",example="UUID",required=true) private System.Nullable<bool> presented;
		private bool? presented;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="父类ID，Level为顶级的，没有父级",name="parent",example="UUID",required=true) private String parentID;
		private string parentID;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="名称",name="name",example="PSD文件管理",required=true) private String name;
		private string name;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="备注，提示信息",name="memo",example="PSD文件管理",required=true) private String memo;
		private string memo;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否在界面上呈现",name="presented",example="",required=true) public String getId()
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
		public virtual string ParentID
		{
			get
			{
				return parentID;
			}
			set
			{
				this.parentID = string.ReferenceEquals(value, null) ? null : value.Trim();
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
		public virtual string Memo
		{
			get
			{
				return memo;
			}
			set
			{
				this.memo = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}
		public virtual sbyte? Permissiontype
		{
			get
			{
				return permissiontype;
			}
			set
			{
				this.permissiontype = value;
			}
		}
		public virtual int? Permissionvalue
		{
			get
			{
				return permissionvalue;
			}
			set
			{
				this.permissionvalue = value;
			}
		}
		public virtual sbyte? Islabel
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
	}

}