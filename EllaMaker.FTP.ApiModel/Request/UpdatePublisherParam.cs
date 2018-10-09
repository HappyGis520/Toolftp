/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 14:34 2018/7/23
/// 描    述：更新出版社请求参数
/// *************************************
/// </summary>
namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

	/*更新出版社请求参数*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="更新出版社参数",description="更新出版社请求参数") public class UpdatePublisherParam extends ella.util.RequestModelBase
	public class UpdatePublisherParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="ID",name="",example="Wangjianjun",required=true) private String ID;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private string ID_Renamed;
		public virtual string ID
		{
			get
			{
				return ID_Renamed;
			}
			set
			{
				ID_Renamed = value;
			}
		}
		//出版社名称
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社名称",name="publishername",example="Wangjianjun",required=true) private String publishername;
		private string publishername;
		//出版社地址
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社地址",name="address",example="Wangjianjun",required=true) private String address;
		private string address;
		//联系人
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="联系人",name="contacter",example="Wangjianjun",required=true) private String contacter;
		private string contacter;
		//出版社联系电话
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="出版社联系电话",name="phone",example="Wangjianjun",required=true) private String phone;
		private string phone;

		public virtual string Publishername
		{
			get
			{
				return publishername;
			}
			set
			{
				this.publishername = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}
		public virtual string Address
		{
			get
			{
				return address;
			}
			set
			{
				this.address = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Contacter
		{
			get
			{
				return contacter;
			}
			set
			{
				this.contacter = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				this.phone = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}

	}

}