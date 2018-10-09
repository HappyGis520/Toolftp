namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="DeleteFTPSiteParam",description="删除FTP服务器参数") public class DeleteFTPSiteParam
	public class DeleteFTPSiteParam
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="FTPSiteID",name="FTPSiteID",example="FTP服务器唯一标识码",required=true) private String FTPSiteID;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string FTPSiteID_Renamed;
		public virtual string FTPSiteID
		{
			get
			{
				return FTPSiteID_Renamed;
			}
			set
			{
				FTPSiteID_Renamed = value;
			}
		}
	}

}