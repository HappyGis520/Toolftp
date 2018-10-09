

using System.Collections.Generic;

namespace EllaMaker.FTP.Model
{

    public class Ebook
    {
        private string id;
        private string bookid;
        private string name;
        private string pinyin;
        private string giturl;
        private string creatorid;
        private string editorid;
        private string createtime;
        private string edittime;
        private string publishtime;
        private string uploadtime;
        private string coverpng;
        private int readmodels;
        private int status;
        private int producttypes;
        private int bookresource;
        private string publishername;
        private string creatorname;
        private string seriesname;
        private IList<UserEbookRelation> authorralations;
        private IList<EbookPage> pages;

        public virtual string Id
        {
            get { return id; }
            set { this.id = value; }
        }


        public virtual string Bookid
        {
            get { return bookid; }
            set { this.bookid = value; }
        }


        public virtual string Name
        {
            get { return name; }
            set { this.name = value; }
        }


        public virtual string Pinyin
        {
            get { return pinyin; }
            set { this.pinyin = value; }
        }


        public virtual string Giturl
        {
            get { return giturl; }
            set { this.giturl = value; }
        }


        public virtual string Creatorid
        {
            get { return creatorid; }
            set { this.creatorid = value; }
        }


        public virtual string Editorid
        {
            get { return editorid; }
            set { this.editorid = value; }
        }


        public virtual string Createtime
        {
            get { return createtime; }
            set { this.createtime = value; }
        }


        public virtual string Edittime
        {
            get { return edittime; }
            set { this.edittime = value; }
        }


        public virtual string Publishtime
        {
            get { return publishtime; }
            set { this.publishtime = value; }
        }


        public virtual string Uploadtime
        {
            get { return uploadtime; }
            set { this.uploadtime = value; }
        }


        public virtual string Coverpng
        {
            get { return coverpng; }
            set { this.coverpng = value; }
        }


        public virtual int Readmodels
        {
            get { return readmodels; }
        }
    }
}