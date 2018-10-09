namespace EllaMaker.Api
{
	using EnumFileResourceType = ella.entity.Enum.EnumFileResourceType;

	public class FTPUploadRequestParam
	{

		public bool? ISEookParam;
		public string BookID;
		public EnumFileResourceType.enumEBookResourceType ResourceType;

	}

}