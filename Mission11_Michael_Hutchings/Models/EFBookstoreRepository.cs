namespace Mission11_Michael_Hutchings.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext _context;

        public EFBookstoreRepository(BookstoreContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
