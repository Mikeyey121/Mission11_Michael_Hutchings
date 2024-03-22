namespace Mission11_Michael_Hutchings.Models.ViewModels
{
    // This is our pagination info for our view models
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumPages => (int) (Math.Ceiling((decimal) TotalItems / ItemsPerPage));
    }
}
