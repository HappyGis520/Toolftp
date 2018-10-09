/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 11:36 2018/7/23
/// 描    述：添加出版商请求消息参数
/// *************************************
/// </summary>
namespace EllaMaker.FTP.Model
{

	/*添加出版商请求消息参数*/
//ORIGINAL LINE: @ApiModel(value = "添加出版商请求消息参数",description = "添加出版商请求消息参数，TOken必须有") public class AppendPublisherParam extends RequestModelBase
	public class AppendPublisherParam : RequestModelBase
	{
//ORIGINAL LINE: @ApiModelProperty(value="出版社名称",name="username",example="xingguo",required = true,hidden = false) private String publishername;
		private string publishername;
			//出版社地址
//ORIGINAL LINE: @ApiModelProperty(value="出版社地址",name="address",example="xingguo",required = true,hidden = false) private String address;
			private string address;
			//联系人
//ORIGINAL LINE: @ApiModelProperty(value="联系人",name="contacter",example="xingguo",required = true,hidden = false) private String contacter;
			private string contacter;
			//出版社联系电话
//ORIGINAL LINE: @ApiModelProperty(value="出版社联系电话",name="phone",example="xingguo",required = true,hidden = false) private String phone;
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