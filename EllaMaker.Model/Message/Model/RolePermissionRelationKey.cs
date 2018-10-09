using System;
using System.Text;

namespace EllaMaker.FTP.Model
{

	[Serializable]
	public class RolePermissionRelationKey
	{
		private string roleid;

		private string permissionid;

		private const long serialVersionUID = 1L;

		public virtual string Roleid
		{
			get
			{
				return roleid;
			}
			set
			{
				this.roleid = string.ReferenceEquals(value, null) ? null : value.Trim();
			}
		}


		public virtual string Permissionid
		{
			get
			{
				return permissionid;
			}
			set
			{
				this.permissionid = string.ReferenceEquals(value, null) ? null : value.Trim();
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
			RolePermissionRelationKey other = (RolePermissionRelationKey) that;
			return (string.ReferenceEquals(this.Roleid, null) ? string.ReferenceEquals(other.Roleid, null) : this.Roleid.Equals(other.Roleid)) && (string.ReferenceEquals(this.Permissionid, null) ? string.ReferenceEquals(other.Permissionid, null) : this.Permissionid.Equals(other.Permissionid));
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((string.ReferenceEquals(Roleid, null)) ? 0 : Roleid.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Permissionid, null)) ? 0 : Permissionid.GetHashCode());
			return result;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(this.GetType().Name);
			sb.Append(" [");
			sb.Append("Hash = ").Append(GetHashCode());
			sb.Append(", roleid=").Append(roleid);
			sb.Append(", permissionid=").Append(permissionid);
			sb.Append(", serialVersionUID=").Append(serialVersionUID);
			sb.Append("]");
			return sb.ToString();
		}
	}
}