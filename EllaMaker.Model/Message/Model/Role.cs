
using System;
using System.Text;

namespace EllaMaker.FTP.Model
{
    using AppendRoleParam = EllaMaker.FTP.Model.AppendRoleParam;



    [Serializable]
    public class Role
    {
        private string id;

        private string name;

        private sbyte? roletype;

        private bool? allowedit;

        private sbyte? behindlevel;

        private DateTime createtime;

        private DateTime edittime;

        private bool? enablestatus;

        private int? rolevalue;


        private const long serialVersionUID = 1L;

        public Role(string id, string name, sbyte? roletype, bool? allowedit, sbyte? behindlevel, DateTime createtime,
            DateTime edittime, bool? enablestatus, int? RoleValue)
        {
            this.id = id;
            this.name = name;
            this.roletype = roletype;
            this.allowedit = allowedit;
            this.behindlevel = behindlevel;
            this.createtime = createtime;
            this.edittime = edittime;
            this.enablestatus = enablestatus;
            this.rolevalue = RoleValue;
        }



        public Role() : base()
        {
        }

        public virtual string Id
        {
            get { return id; }
            set { this.id = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Name
        {
            get { return name; }
            set { this.name = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual sbyte? Roletype
        {
            get { return roletype; }
            set { this.roletype = value; }
        }


        public virtual bool? Allowedit
        {
            get { return allowedit; }
            set { this.allowedit = value; }
        }


        public virtual sbyte? Behindlevel
        {
            get { return behindlevel; }
            set { this.behindlevel = value; }
        }


        public virtual DateTime Createtime
        {
            get { return createtime; }
            set { this.createtime = value; }
        }


        public virtual DateTime Edittime
        {
            get { return edittime; }
            set { this.edittime = value; }
        }


        public virtual bool? Enablestatus
        {
            get { return enablestatus; }
            set { this.enablestatus = value; }
        }


        public virtual int? Rolevalue
        {
            get { return rolevalue; }
            set { rolevalue = value; }
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
            Role other = (Role) that;
            return (string.ReferenceEquals(this.Id, null)
                       ? string.ReferenceEquals(other.Id, null)
                       : this.Id.Equals(other.Id)) &&
                   (string.ReferenceEquals(this.Name, null)
                       ? string.ReferenceEquals(other.Name, null)
                       : this.Name.Equals(other.Name)) &&
                   (this.Roletype == null ? other.Roletype == null : this.Roletype.Equals(other.Roletype)) &&
                   (this.Allowedit == null ? other.Allowedit == null : this.Allowedit.Equals(other.Allowedit)) &&
                   (this.Behindlevel == null ? other.Behindlevel == null : this.Behindlevel.Equals(other.Behindlevel)) &&
                   (this.Createtime == null ? other.Createtime == null : this.Createtime.Equals(other.Createtime)) &&
                   (this.Edittime == null ? other.Edittime == null : this.Edittime.Equals(other.Edittime)) &&
                   (this.Enablestatus == null
                       ? other.Enablestatus == null
                       : this.Enablestatus.Equals(other.Enablestatus)) &&
                   (this.Rolevalue == null ? other.Rolevalue == null : this.Rolevalue.Equals(other.Rolevalue));
        }
    }
}