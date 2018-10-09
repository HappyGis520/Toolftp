/*******************************************************************
 * * 版权所有： 郑州点读科技杭州研发中心
 * * 文件名称： Publisher.cs
 * * 功   能：  出版商信息
 * * 作   者： 王建军
 * * 编程语言： C# 
 * * 电子邮箱： 595303122@qq.com
 * * 创建日期： 2018-09-25 13:51:47
 * * 修改记录： 
 * * 日期时间： 2018-09-25 13:51:47  修改人：王建军  创建
 * *******************************************************************/
using System;
using System.Text;

namespace EllaMaker.FTP.Model
{
    [Serializable]
    public class Publisher
    {
        private string id;

        private string publishername;

        private string address;

        private string contacter;

        private string phone;

        private string creatorid;

        private string editorid;

        private DateTime createtime;

        private DateTime edittime;

        private const long serialVersionUID = 1L;

        public virtual string Id
        {
            get { return id; }
            set { this.id = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Publishername
        {
            get { return publishername; }
            set { this.publishername = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Address
        {
            get { return address; }
            set { this.address = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Contacter
        {
            get { return contacter; }
            set { this.contacter = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Phone
        {
            get { return phone; }
            set { this.phone = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Creatorid
        {
            get { return creatorid; }
            set { this.creatorid = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Editorid
        {
            get { return editorid; }
            set { this.editorid = string.ReferenceEquals(value, null) ? null : value.Trim(); }
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


        private bool? enableStatus;

        public virtual bool? EnableStatus
        {
            get { return enableStatus; }
            set { this.enableStatus = value; }
        }
    }
}


