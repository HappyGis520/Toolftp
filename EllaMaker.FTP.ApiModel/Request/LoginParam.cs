namespace EllaMaker.Api
{
	using RequestModelBase = ella.util.RequestModelBase;

	public class LoginParam : RequestModelBase
	{
		private string username;
		private string password;

		public virtual string Username
		{
			get
			{
				return username;
			}
			set
			{
				this.username = value;
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

	}

}