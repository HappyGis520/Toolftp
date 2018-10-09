using System;
using System.Text;

/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 15:30 2018/7/19
/// 描    述：
/// *************************************
/// </summary>
namespace EllaMaker.FTP.Model
{
	[Serializable]
	public class RolePermissionRelation : RolePermissionRelationKey
	{
		private sbyte? enabled;


		private const long serialVersionUID = 1L;

		public RolePermissionRelation()
		{

		}
		public RolePermissionRelation(string RoleID, string PermissionID, sbyte? Enabled)
		{
			Enabled = Enabled;
			Permissionid = PermissionID;
			Roleid = RoleID;

		}

		public virtual sbyte? Enabled
		{
			get
			{
				return enabled;
			}
			set
			{
				this.enabled = value;
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
			RolePermissionRelation other = (RolePermissionRelation) that;
			return (string.ReferenceEquals(this.Roleid, null) ? string.ReferenceEquals(other.Roleid, null) : this.Roleid.Equals(other.Roleid)) && (string.ReferenceEquals(this.Permissionid, null) ? string.ReferenceEquals(other.Permissionid, null) : this.Permissionid.Equals(other.Permissionid)) && (this.Enabled == null ? other.Enabled == null : this.Enabled.Equals(other.Enabled));
		}

		public override int GetHashCode()
		{
			const int prime = 31;
			int result = 1;
			result = prime * result + ((string.ReferenceEquals(Roleid, null)) ? 0 : Roleid.GetHashCode());
			result = prime * result + ((string.ReferenceEquals(Permissionid, null)) ? 0 : Permissionid.GetHashCode());
			result = prime * result + ((Enabled == null) ? 0 : Enabled.GetHashCode());
			return result;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(this.GetType().Name);
			sb.Append(" [");
			sb.Append("Hash = ").Append(GetHashCode());
			sb.Append(", enabled=").Append(enabled);
			sb.Append(", serialVersionUID=").Append(serialVersionUID);
			sb.Append("]");
			return sb.ToString();
		}
	}
}