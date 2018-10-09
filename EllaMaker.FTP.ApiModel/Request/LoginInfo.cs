namespace EllaMaker.Api
{
	public class LoginInfo
	{
		private string id;
		private string roleid;
		private string name;
		private string phone;
		private string face;
		private string token;

		public virtual string Id
		{
			get
			{
				return id;
			}
			set
			{
				this.id = value;
			}
		}


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


		public virtual string Token
		{
			get
			{
				return token;
			}
			set
			{
				this.token = value;
			}
		}

	}

}