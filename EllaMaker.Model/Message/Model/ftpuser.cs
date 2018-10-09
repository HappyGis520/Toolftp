using System;
using System.Text;

namespace EllaMaker.FTP.Model
{

	[Serializable]
	public class ftpuser
	{
		private string id;

		private string ftpid;

		private string sysuserid;

		private string name;

		private string password;

		private bool? status;

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


		public virtual string Ftpid
		{
			get
			{
				return ftpid;
			}
			set
			{
				this.ftpid = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Sysuserid
		{
			get
			{
				return sysuserid;
			}
			set
			{
				this.sysuserid = string.ReferenceEquals(value, null) ? null : value.Trim();
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


		public virtual string Password
		{
			get
			{
				return password;
			}
			set
			{
				this.password = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual bool? Status
		{
			get
			{
				return status;
			}
			set
			{
				this.status = value;
			}
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
			ftpuser other = (ftpuser) that;
			return (string.ReferenceEquals(this.Id, null) ? string.ReferenceEquals(other.Id, null) : this.Id.Equals(other.Id)) && (string.ReferenceEquals(this.Ftpid, null) ? string.ReferenceEquals(other.Ftpid, null) : this.Ftpid.Equals(other.Ftpid)) && (string.ReferenceEquals(this.Sysuserid, null) ? string.ReferenceEquals(other.Sysuserid, null) : this.Sysuserid.Equals(other.Sysuserid)) && (string.ReferenceEquals(this.Name, null) ? string.ReferenceEquals(other.Name, null) : this.Name.Equals(other.Name)) && (string.ReferenceEquals(this.Password, null) ? string.ReferenceEquals(other.Password, null) : this.Password.Equals(other.Password)) && (this.Status == null ? other.Status == null : this.Status.Equals(other.Status));
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((string.ReferenceEquals(Id, null)) ? 0 : Id.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Ftpid, null)) ? 0 : Ftpid.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Sysuserid, null)) ? 0 : Sysuserid.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Name, null)) ? 0 : Name.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Password, null)) ? 0 : Password.GetHashCode());
			result = prime * result + ((Status == null) ? 0 : Status.GetHashCode());
			return result;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(this.GetType().Name);
			sb.Append(" [");
			sb.Append("Hash = ").Append(GetHashCode());
			sb.Append(", id=").Append(id);
			sb.Append(", ftpid=").Append(ftpid);
			sb.Append(", sysuserid=").Append(sysuserid);
			sb.Append(", name=").Append(name);
			sb.Append(", password=").Append(password);
			sb.Append(", status=").Append(status);
			sb.Append(", serialVersionUID=").Append(serialVersionUID);
			sb.Append("]");
			return sb.ToString();
		}
	}
}