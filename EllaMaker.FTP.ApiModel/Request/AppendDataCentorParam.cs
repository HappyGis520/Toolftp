namespace EllaMaker.Api
{
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="添加F数据中心参数",description="添加F数据中心参数") public class AppendDataCentorParam
	public class AppendDataCentorParam
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="ip",name="ip",example="1",required=true) private String ip;
		private string ip;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="mac",name="mac",example="1",required=true) private String mac;
		private string mac;
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="name",name="name",example="1",required=true) private String name;
		private string name;
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


		public virtual string Mac
		{
			get
			{
				return mac;
			}
			set
			{
				this.mac = string.ReferenceEquals(value, null) ? null : value.Trim();
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

	}

}