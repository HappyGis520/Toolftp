namespace EllaMaker.FTP.Model
{

	public class AppendFTPSiteParam
	{
		private string datacentorid;
		private string ip;
		private int? port;
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