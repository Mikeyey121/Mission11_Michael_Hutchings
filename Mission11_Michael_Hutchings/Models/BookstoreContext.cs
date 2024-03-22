using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
// This is our context file which has a DbSet Books and inherits from the base DbContext. 
namespace Mission11_Michael_Hutchings.Models;

public partial class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
    {
    }

   public DbSet<Book> Books { get; set; }
}
