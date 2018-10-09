/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 11:45 2018/8/20
/// 描    述：
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="DeleteDataCentorParam",description="删除数据中心参数") public class DeleteDataCentorParam
	public class DeleteDataCentorParam
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="DataCentorID",name="DataCentorID",example="数据中心唯一标识码",required=true) private String DataCentorID;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string DataCentorID_Renamed;
		public virtual string DataCentorID
		{
			get
			{
				return DataCentorID_Renamed;
			}
			set
			{
				DataCentorID_Renamed = value;
			}
		}
	}

}