using System.Collections.Generic;

namespace EllaMaker.Api
{
	using EbookPage = ella.entity.EbookPage;
	using UserEbookRelation = ella.entity.UserEbookRelation;
	using RequestModelBase = ella.util.RequestModelBase;
	using ApiModel = io.swagger.annotations.ApiModel;
	using ApiModelProperty = io.swagger.annotations.ApiModelProperty;

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModel(value="更新电子书页面信息参数",description="请求更新电子书页面使用的参数") public class UpdateEbookPageParam extends ella.util.RequestModelBase
	public class UpdateEbookPageParam : RequestModelBase
	{
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书编号",name="id",example="sdfafdasdfds",required=true) private String id;
		private string id;
		/*电子书参与者信息列表*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书参与者信息列表",name="authorralations",required=true) private java.util.List<ella.entity.UserEbookRelation> authorralations;
		private IList<UserEbookRelation> authorralations;
		/*电子书页面信息列表*/
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @ApiModelProperty(value="电子书页面信息列表",name="pages",required=true) private java.util.List<ella.entity.EbookPage> pages;
		private IList<EbookPage> pages;

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


		public virtual IList<EbookPage> Pages
		{
			get
			{
				return pages;
			}
			set
			{
				this.pages = value;
			}
		}

	}

}