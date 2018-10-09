namespace EllaMaker.FTP.Model
{
	public class UserEbookRelation
	{
	  private string userid;
	  private string ebookid;
	  private int makerrole;
	  private string username;

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


	  public virtual int Makerrole
	  {
		  get
		  {
			return makerrole;
		  }
		  set
		  {
			this.makerrole = value;
		  }
	  }


	  public virtual string Username
	  {
		  get
		  {
			return username;
		  }
		  set
		  {
			this.username = value;
		  }
	  }

	}

}