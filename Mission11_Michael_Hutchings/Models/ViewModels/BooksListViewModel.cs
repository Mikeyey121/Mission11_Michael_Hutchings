namespace Mission11_Michael_Hutchings.Models.ViewModels
{
    // This is the model that allows us to get the books and the pagination info
    public class BooksListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
