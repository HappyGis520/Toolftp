

using System;
using System.Text;

namespace EllaMaker.FTP.Model
{


    [Serializable]
    public class Permission
    {
        private string id;

        private string parentid;

        private string name;

        private sbyte? permissiontype;

        private int? permissionvalue;

        private string memo;

        private bool? islabel;

        private bool? presented;

        private bool? enablestatus;

        private DateTime createtime;

        private DateTime edittime;

        private const long serialVersionUID = 1L;

        public Permission(string id, string parentid, string name, sbyte? permissiontype, int? permissionvalue,
            string memo, bool? islabel, bool? presented, bool? enablestatus, DateTime createtime, DateTime edittime)
        {
            this.id = id;
            this.parentid = parentid;
            this.name = name;
            this.permissiontype = permissiontype;
            this.permissionvalue = permissionvalue;
            this.memo = memo;
            this.islabel = islabel;
            this.presented = presented;
            this.enablestatus = enablestatus;
            this.createtime = createtime;
            this.edittime = edittime;
        }

        public Permission() : base()
        {
        }

        public virtual string Id
        {
            get { return id; }
            set { this.id = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Parentid
        {
            get { return parentid; }
            set { this.parentid = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Name
        {
            get { return name; }
            set { this.name = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual sbyte? Permissiontype
        {
            get { return permissiontype; }
            set { this.permissiontype = value; }
        }


        public virtual int? Permissionvalue
        {
            get { return permissionvalue; }
            set { this.permissionvalue = value; }
        }


        public virtual string Memo
        {
            get { return memo; }
            set { this.memo = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual bool? Islabel
        {
            get { return islabel; }
            set { this.islabel = value; }
        }


        public virtual bool? Presented
        {
            get { return presented; }
            set { this.presented = value; }
        }


        public virtual bool? Enablestatus
        {
            get { return enablestatus; }
            set { this.enablestatus = value; }
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


    }
}
