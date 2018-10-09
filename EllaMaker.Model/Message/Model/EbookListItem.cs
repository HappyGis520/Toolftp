namespace EllaMaker.FTP.Model
{

	public class EbookListItem
	{
		private string id;
		private string name;
		private string createtime;
		private string publishtime;
		private long? status;
		private string uploadtime;
		private string publishername;
		private string creatorname;
		private string seriesname;

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


		public virtual string Publishtime
		{
			get
			{
				return publishtime;
			}
			set
			{
				this.publishtime = value;
			}
		}


		public virtual long? Status
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


		public virtual string Uploadtime
		{
			get
			{
				return uploadtime;
			}
			set
			{
				this.uploadtime = value;
			}
		}


		public virtual string Publishername
		{
			get
			{
				return publishername;
			}
			set
			{
				this.publishername = value;
			}
		}

		public virtual string Creatorname
		{
			get
			{
				return creatorname;
			}
			set
			{
				this.creatorname = value;
			}
		}



		public virtual string Seriesname
		{
			get
			{
				return seriesname;
			}
			set
			{
				this.seriesname = value;
			}
		}

	}

}