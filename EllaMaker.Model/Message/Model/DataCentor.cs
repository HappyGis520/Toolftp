using System;
using System.Text;

namespace EllaMaker.FTP.Model
{

	[Serializable]
	public class DataCentor
	{
		private string id;

		private string ip;

		private string mac;

		private string name;

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


		public DataCentor()
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
			DataCentor other = (DataCentor) that;
			return (string.ReferenceEquals(this.Id, null) ? string.ReferenceEquals(other.Id, null) : this.Id.Equals(other.Id)) && (string.ReferenceEquals(this.Ip, null) ? string.ReferenceEquals(other.Ip, null) : this.Ip.Equals(other.Ip)) && (string.ReferenceEquals(this.Mac, null) ? string.ReferenceEquals(other.Mac, null) : this.Mac.Equals(other.Mac)) && (string.ReferenceEquals(this.Name, null) ? string.ReferenceEquals(other.Name, null) : this.Name.Equals(other.Name));
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((string.ReferenceEquals(Id, null)) ? 0 : Id.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Ip, null)) ? 0 : Ip.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Mac, null)) ? 0 : Mac.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Name, null)) ? 0 : Name.GetHashCode());
			return result;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(this.GetType().Name);
			sb.Append(" [");
			sb.Append("Hash = ").Append(GetHashCode());
			sb.Append(", id=").Append(id);
			sb.Append(", ip=").Append(ip);
			sb.Append(", mac=").Append(mac);
			sb.Append(", name=").Append(name);
			sb.Append(", serialVersionUID=").Append(serialVersionUID);
			sb.Append("]");
			return sb.ToString();
		}
	}
}