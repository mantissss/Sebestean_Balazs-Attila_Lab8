using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sebestean_Balazs_Attila_Lab8.Data;
using Sebestean_Balazs_Attila_Lab8.Models;

namespace Sebestean_Balazs_Attila_Lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Sebestean_Balazs_Attila_Lab8.Data.Sebestean_Balazs_Attila_Lab8Context _context;

        public DetailsModel(Sebestean_Balazs_Attila_Lab8.Data.Sebestean_Balazs_Attila_Lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
