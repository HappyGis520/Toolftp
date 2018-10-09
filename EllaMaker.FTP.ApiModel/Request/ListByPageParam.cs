/// <summary>
///************************************
/// 创 建 者: 王建军
/// 联系方式：wangjianjun@ellamaker.cn
/// 创建时间: 10:46 2018/7/26
/// 描    述：分页获取对象集合
/// *************************************
/// </summary>
namespace ella.Messages
{
    /// <summary>
    /// 分页获取对象集合
    /// </summary>
	public class ListByPageParam
	{
        /// <summary>
        /// 
        /// </summary>
		protected internal int pageSize;
		protected internal int pageIndex;
		protected internal int startIndex;
		public virtual int PageSize
		{
			get
			{
				return pageSize;
			}
			set
			{
				this.pageSize = value;
			}
		}
		public virtual int PageIndex
		{
			get
			{
				return pageIndex;
			}
			set
			{
				this.pageIndex = value;
			}
		}
		public virtual int StartIndex
		{
			get
			{
				startIndex = pageIndex * pageSize;
				return startIndex;
			}
		}
	}

}