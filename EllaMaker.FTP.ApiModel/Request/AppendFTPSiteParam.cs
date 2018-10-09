namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="添加FTP站点信息参数",description="添加FTP站点信息参数") public class AppendFTPSiteParam
	public class AppendFTPSiteParam
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="数据中心编号",name="datacentorid",example="1",required=true) private String datacentorid;
		private string datacentorid;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="ip",name="ip",example="1",required=true) private String ip;
		private string ip;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="port",name="port",example="1",required=true) private System.Nullable<int> port;
		private int? port;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="FTP站点存储根目录，以字和会“/”结尾",name="sitepath",example="1",required=true) private String sitepath;
		private string sitepath;

		public virtual string Datacentorid
		{
			get
			{
				return datacentorid;
			}
			set
			{
				this.datacentorid = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Ip
		{
			get
			{
				return ip;
			}
			set
			{
				this.ip = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual int? Port
		{
			get
			{
				return port;
			}
			set
			{
				this.port = value;
			}
		}


		public virtual string Sitepath
		{
			get
			{
				return sitepath;
			}
			set
			{
				this.sitepath = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


	}
}