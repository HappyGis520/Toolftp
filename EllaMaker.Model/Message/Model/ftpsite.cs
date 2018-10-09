using System;
using System.Text;

namespace EllaMaker.FTP.Model
{

	[Serializable]
	public class ftpsite
	{
		private string id;

		private string datacentorid;

		private string ip;

		private int? port;

		private string sitepath;
		private bool? enableStatus;

		private const long serialVersionUID = 1L;

		public virtual string Id
		{
			get
			{
				return id;
			}
			set
			{
				this.id = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


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

		public virtual bool? EnableStatus
		{
			get
			{
				return enableStatus;
			}
			set
			{
				this.enableStatus = value;
			}
		}

		public ftpsite()
		{

		}

		public override bool Equals(object that)
		{
			if (this == that)
			{
				return true;
			}
			if (that == null)
			{
				return false;
			}
			if (this.GetType() != that.GetType())
			{
				return false;
			}
			ftpsite other = (ftpsite) that;
			return (string.ReferenceEquals(this.Id, null) ? string.ReferenceEquals(other.Id, null) : this.Id.Equals(other.Id)) && (string.ReferenceEquals(this.Datacentorid, null) ? string.ReferenceEquals(other.Datacentorid, null) : this.Datacentorid.Equals(other.Datacentorid)) && (string.ReferenceEquals(this.Ip, null) ? string.ReferenceEquals(other.Ip, null) : this.Ip.Equals(other.Ip)) && (this.Port == null ? other.Port == null : this.Port.Equals(other.Port)) && (string.ReferenceEquals(this.Sitepath, null) ? string.ReferenceEquals(other.Sitepath, null) : this.Sitepath.Equals(other.Sitepath));
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((string.ReferenceEquals(Id, null)) ? 0 : Id.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Datacentorid, null)) ? 0 : Datacentorid.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Ip, null)) ? 0 : Ip.GetHashCode());
			result = prime * result + ((Port == null) ? 0 : Port.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Sitepath, null)) ? 0 : Sitepath.GetHashCode());
			return result;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(this.GetType().Name);
			sb.Append(" [");
			sb.Append("Hash = ").Append(GetHashCode());
			sb.Append(", id=").Append(id);
			sb.Append(", datacentorid=").Append(datacentorid);
			sb.Append(", ip=").Append(ip);
			sb.Append(", port=").Append(port);
			sb.Append(", sitepath=").Append(sitepath);
			sb.Append(", serialVersionUID=").Append(serialVersionUID);
			sb.Append("]");
			return sb.ToString();
		}
	}
}