/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： AddUserParam.cs
 * * 功   能：  添加用户参数
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 
 * * 修改记录： 
 * * 日期时间：   修改人：王建军  创建
 * *******************************************************************/
namespace EllaMaker.FTP.Model
{
    /// <summary>
    /// 添加用户参数
    /// </summary>
	public class AddUserParam : RequestModelBase
	{

		private string roleid;
		/*用户名*/

		private string name;
		/*联系方式*/

		private string phone;
		/*密码*/

		private string password;
		/*头像*/

		private string face;
		/*是否启用*/

		private bool enabled;


		public virtual string Roleid
		{
			get
			{
				return roleid;
			}
			set
			{
				this.roleid = value;
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
				this.name = value;
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
				this.phone = value;
			}
		}


		public virtual string Password
		{
			get
			{
				return password;
			}
			set
			{
				this.password = value;
			}
		}


		public virtual string Face
		{
			get
			{
				return face;
			}
			set
			{
				this.face = value;
			}
		}



		public virtual bool Enabled
		{
			set
			{
				enabled = value;
			}
			get
			{
				return enabled;
			}
		}

	}

}