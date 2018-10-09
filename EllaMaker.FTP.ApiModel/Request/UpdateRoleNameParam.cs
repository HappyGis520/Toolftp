namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="UpdateRoleNameParam",description="更新角色名参数") public class UpdateRoleNameParam
	public class UpdateRoleNameParam
	{
		public virtual string ID
		{
			get
			{
				return ID_Renamed;
			}
			set
			{
				this.ID_Renamed = value;
			}
		}
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="ID",name="角色唯一标识码",example="Wangjianjun",required=true) private String ID;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string ID_Renamed;

		public virtual string NewName
		{
			get
			{
				return NewName_Renamed;
			}
			set
			{
				NewName_Renamed = value;
			}
		}


//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="NewName",name="将采用的新名称",example="Wangjianjun",required=true) private String NewName;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string NewName_Renamed;
	}

}