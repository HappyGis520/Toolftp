using System.Collections.Generic;

namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="删除数据库实体对象参数",description="删除数据库实体对象参数") public class DeleteEntityParam extends ella.util.RequestModelBase
	public class DeleteEntityParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="将要删除的记录ID集合",name="RemovedItemIDs",example="",required=true) private java.util.List<String> RemovedItemIDs;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private IList<string> RemovedItemIDs_Renamed;
		public virtual IList<string> RemovedItemIDs
		{
			get
			{
				return RemovedItemIDs_Renamed;
			}
			set
			{
				RemovedItemIDs_Renamed = value;
			}
		}
	}

}