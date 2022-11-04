using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PE_Ex2.Data;
using PE_Ex2.Models;

namespace PE_Ex2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly PE_Ex2.Data.BookManagementSystemContext _context;

        public IndexModel(PE_Ex2.Data.BookManagementSystemContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Book = await _context.Books.ToListAsync();
            }
        }
    }
}
