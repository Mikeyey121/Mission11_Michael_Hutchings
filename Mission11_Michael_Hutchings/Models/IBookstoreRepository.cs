
//This is our interface for the repository pattern
namespace Mission11_Michael_Hutchings.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
