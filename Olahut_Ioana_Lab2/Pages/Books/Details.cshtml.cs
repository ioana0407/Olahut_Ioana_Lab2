using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Olahut_Ioana_Lab2.Data;
using Olahut_Ioana_Lab2.Models;

namespace Olahut_Ioana_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Olahut_Ioana_Lab2.Data.Olahut_Ioana_Lab2Context _context;

        public DetailsModel(Olahut_Ioana_Lab2.Data.Olahut_Ioana_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b=>b.Author)  
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
