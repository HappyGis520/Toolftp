namespace EllaMaker.Api
{
	using EnumFileResourceType = ella.entity.Enum.EnumFileResourceType;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="FTPUploadParamValues",description="FTP文件上传需要的参数数值") public class FTPUploadParamValues
	public class FTPUploadParamValues
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="FtpIP",name="FtpIP",example="Wangjianjun",required=true) public String FtpIP;
		public string FtpIP;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="FtpPort",name="FtpPort",example="Wangjianjun",required=true) public String FtpPort;
		public string FtpPort;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="UserName",name="UserName",example="Wangjianjun",required=true) public String UserName;
		public string UserName;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="SavePath",name="SavePath",example="Wangjianjun",required=false) public String SavePath;
		public string SavePath;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="资源类别",name="ResourceType",example="Wangjianjun",required=true) public ella.entity.Enum.EnumFileResourceType ResourceType;
		public EnumFileResourceType ResourceType;

	}

}