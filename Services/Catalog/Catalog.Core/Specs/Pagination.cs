

namespace Catalog.Core.Specs
{
    public class Pagination<T> where T : class
    {
        public Pagination()
        {

        }
        public Pagination(int pageIndex, int pageSize, int count, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        public int PageIndex { get; }
        public int PageSize { get; private set; }
        public int Count { get; private set; }
        public IReadOnlyList<T> Data { get; private set; }
    }
}
