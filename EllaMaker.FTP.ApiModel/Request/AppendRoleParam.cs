using System.Collections.Generic;

/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 15:43 2018/7/19
/// 描    述：添加权限请求消息参数
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="添加角色参数",description="添加角色请求消息参数") public class AppendRoleParam extends ella.util.RequestModelBase
	public class AppendRoleParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="角色名称",name="RoleName",example="管理员",required=true) private String RoleName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string RoleName_Renamed;
		public virtual string RoleName
		{
			get
			{
				return RoleName_Renamed;
			}
			set
			{
				RoleName_Renamed = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="权限唯一识别码列表",name="PermissionItemIDs",example="fsaf",required=true) private java.util.List<String> PermissionItemIDs;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private IList<string> PermissionItemIDs_Renamed;
		public virtual IList<string> PermissionItemIDs
		{
			get
			{
				return PermissionItemIDs_Renamed;
			}
			set
			{
				PermissionItemIDs_Renamed = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="是否允许编辑",name="allowedit",example="true",required=true) private System.Nullable<bool> allowedit;
		private bool? allowedit;
		public virtual bool? Allowedit
		{
			get
			{
				return allowedit;
			}
			set
			{
				this.allowedit = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="可用级别",name="behindlevel",example="10",required=true,dataType ="java.lang.Byte") private System.Nullable<sbyte> behindlevel;
		private sbyte? behindlevel;
		public virtual sbyte? Behindlevel
		{
			get
			{
				return behindlevel;
			}
			set
			{
				this.behindlevel = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="角色枚举值，自定义角色填0",name="rolevalue",example="10",required=true) private System.Nullable<int> rolevalue;
		private int? rolevalue;
		public virtual int? Rolevalue
		{
			get
			{
				return rolevalue;
			}
			set
			{
				rolevalue = value;
			}
		}




	}

}