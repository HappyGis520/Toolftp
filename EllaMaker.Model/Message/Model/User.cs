namespace EllaMaker.FTP.Model
{

	public class MUser
	{
	  private string id;
	  private string roleid;
	  private string name;
	  private string gitauthor;
	  private string phone;
	  private string password;
	  private string face;
	  private string createtime;
	  private string edittime;
	  private string token;
	  private string tokencreatetime;
	  private bool enabled;

	  public MUser()
	  {
		this.id = "wangjianjunID";
	  }


	  public virtual string Id
	  {
		  set
		  {
			this.id = value;
		  }
		  get
		  {
			return id;
		  }
	  }


	  public virtual string Roleid
	  {
		  get
		  {
			return roleid;
		  }
		  set
		  {
			this.roleid = value;
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
			this.name = value;
		  }
	  }


	  public virtual string Gitauthor
	  {
		  get
		  {
			return gitauthor;
		  }
		  set
		  {
			this.gitauthor = value;
		  }
	  }


	  public virtual string Phone
	  {
		  get
		  {
			return phone;
		  }
		  set
		  {
			this.phone = value;
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
			this.password = value;
		  }
	  }


	  public virtual string Face
	  {
		  get
		  {
			return face;
		  }
		  set
		  {
			this.face = value;
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


	  public virtual string Token
	  {
		  get
		  {
			return token;
		  }
		  set
		  {
			this.token = value;
		  }
	  }


	  public virtual string Tokencreatetime
	  {
		  get
		  {
			return tokencreatetime;
		  }
		  set
		  {
			this.tokencreatetime = value;
		  }
	  }


	  public virtual bool Enabled
	  {
		  set
		  {
			  enabled = value;
		  }
		  get
		  {
			  return enabled;
		  }
	  }


	}

}