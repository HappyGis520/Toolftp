//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Text;

namespace EllaMaker.FTP.Model
{
    /// <summary>
    ///************************************
    /// 创 建 者: 王建军
    /// 联系方式：wangjianjun@ellamaker.cn
    /// 创建时间: 10:01 2018/7/23
    /// 描    述：原版图书信息
    /// *************************************
    /// </summary>


    [Serializable]
    public class Book
    {
        protected internal string id;
        protected internal string publisherid;
        protected internal string bookSetID;
        protected internal string authorid;
        protected internal string isbn;
        protected internal string Name_Renamed;
        protected internal string giturl;
        protected internal DateTime publicationTime;
        protected internal decimal price;
        protected internal string creatorid;
        protected internal string editorid;
        protected internal DateTime createtime;
        protected internal DateTime edittime;

        public virtual string getid()
        {
            return id;
        }

        public virtual void setid(string id)
        {
            this.id = string.ReferenceEquals(id, null) ? null : id.Trim();
        }

        public virtual string Publisherid
        {
            get { return publisherid; }
            set { this.publisherid = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string BookSetID
        {
            get { return bookSetID; }
            set { this.bookSetID = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Authorid
        {
            get { return authorid; }
            set { this.authorid = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Isbn
        {
            get { return isbn; }
            set { this.isbn = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual string Name
        {
            get { return Name_Renamed; }
            set { Name_Renamed = value; }
        }

        public virtual string Giturl
        {
            get { return giturl; }
            set { this.giturl = string.ReferenceEquals(value, null) ? null : value.Trim(); }
        }


        public virtual DateTime Datetime
        {
            get { return publicationTime; }
            set { this.publicationTime = value; }
        }


        public virtual decimal Price
        {
            get { return price; }
            set { this.price = value; }
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


        protected internal bool? enableStatus;
    }
}


