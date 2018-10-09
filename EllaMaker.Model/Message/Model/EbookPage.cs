namespace EllaMaker.FTP.Model
{
	public class EbookPage
	{
	  private string id;
	  private string userid;
	  private int pageindex;
	  private string previewpng;
	  private string giturl;
	  private int status;
	  private string creatorid;
	  private string editorid;
	  private string createtime;
	  private string edittime;
	  private string ebookid;
	  private int isdelete;
	  public virtual string Id
	  {
		  get
		  {
			return id;
		  }
		  set
		  {
			this.id = value;
		  }
	  }


	  public virtual string Userid
	  {
		  get
		  {
			return userid;
		  }
		  set
		  {
			this.userid = value;
		  }
	  }


	  public virtual int Pageindex
	  {
		  get
		  {
			return pageindex;
		  }
		  set
		  {
			this.pageindex = value;
		  }
	  }


	  public virtual string Previewpng
	  {
		  get
		  {
			return previewpng;
		  }
		  set
		  {
			this.previewpng = value;
		  }
	  }


	  public virtual string Giturl
	  {
		  get
		  {
			return giturl;
		  }
		  set
		  {
			this.giturl = value;
		  }
	  }


	  public virtual int Status
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


	  public virtual string Creatorid
	  {
		  get
		  {
			return creatorid;
		  }
		  set
		  {
			this.creatorid = value;
		  }
	  }


	  public virtual string Editorid
	  {
		  get
		  {
			return editorid;
		  }
		  set
		  {
			this.editorid = value;
		  }
	  }


	  public virtual string Createtime
	  {
		  get
		  {
			return createtime;
		  }
		  set
		  {
			this.createtime = value;
		  }
	  }


	  public virtual string Edittime
	  {
		  get
		  {
			return edittime;
		  }
		  set
		  {
			this.edittime = value;
		  }
	  }


	  public virtual string Ebookid
	  {
		  get
		  {
			return ebookid;
		  }
		  set
		  {
			this.ebookid = value;
		  }
	  }


	  public virtual int Isdelete
	  {
		  get
		  {
			return isdelete;
		  }
		  set
		  {
			this.isdelete = value;
		  }
	  }

	}

}