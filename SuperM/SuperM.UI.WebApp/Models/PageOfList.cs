namespace SuperM.UI.WebApp.Models
{
    class PageOfList
    {
        public interface IPageOfList
        {
            long CurrentStart { get; }

            int PageIndex { get; set; }

            int PageSize { get; set; }

            int PageTotal { get; }

            long RecordTotal { get; set; }
        }
    }
}
