using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db; //dependency injection.. we need db objects to display on this page

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
                
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGetAsync() //this method is going into the db getting all books and storing it inside IEnum books
        {
            Books = await _db.Book.ToListAsync(); //async lets you run multiple tasks at a time until its awaiting.. we need to await because we need to wait until we assing all the books that we found

        }
    }
}