using System.Collections.Generic;

namespace EllaMaker.Api
{
	using EbookPage = ella.entity.EbookPage;
	using UserEbookRelation = ella.entity.UserEbookRelation;
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="更新电子书信息参数",description="请求更新电子书使用的参数") public class UpdateEbookInfoParam extends ella.util.RequestModelBase
	public class UpdateEbookInfoParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书编号",name="id",example="sdfafdasdfds",required=true) private String id;
		private string id;
		/*实体书编号*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="实体书编号",name="bookid",example="sdfafdasdfds",required=true) private String bookid;
		private string bookid;
		/*电子书名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书名称",name="name",example="一本书",required=true) private String name;
		private string name;
		/*电子书拼音名称*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书拼音名称",name="pinyin",example="YBS",required=true) private String pinyin;
		private string pinyin;
		/*修改人编号*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="修改人编号",name="editorid",example="adsdwewqew",required=true) private String editorid;
		private string editorid;
		/*封面地址*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="封面地址",name="coverpng",example="") private String coverpng;
		private string coverpng;
		/*支持阅读模式列表*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="支持阅读模式列表",name="readmodels",example="2") private int readmodels;
		private int readmodels;
		/*支持动画书产品列表*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="支持动画书产品列表",name="producttypes",example="2") private int producttypes;
		private int producttypes;
		/*电子书参与者信息列表*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书参与者信息列表",name="authorralations") private java.util.List<ella.entity.UserEbookRelation> authorralations;
		private IList<UserEbookRelation> authorralations;

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


		public virtual string Bookid
		{
			get
			{
				return bookid;
			}
			set
			{
				this.bookid = value;
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


		public virtual string Pinyin
		{
			get
			{
				return pinyin;
			}
			set
			{
				this.pinyin = value;
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



		public virtual string Coverpng
		{
			get
			{
				return coverpng;
			}
			set
			{
				this.coverpng = value;
			}
		}


		public virtual int Readmodels
		{
			get
			{
				return readmodels;
			}
			set
			{
				this.readmodels = value;
			}
		}


		public virtual int Producttypes
		{
			get
			{
				return producttypes;
			}
			set
			{
				this.producttypes = value;
			}
		}



		public virtual IList<UserEbookRelation> Authorralations
		{
			get
			{
				return authorralations;
			}
			set
			{
				this.authorralations = value;
			}
		}


	}

}