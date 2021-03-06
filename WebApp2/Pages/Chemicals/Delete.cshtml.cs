#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp2.Data;
using WebApp2.Models;

namespace WebApp2.Pages.Chemicals
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp2.Data.Inventory _context;

        public DeleteModel(WebApp2.Data.Inventory context)
        {
            _context = context;
        }

        [BindProperty]
        public Chemical Chemicals { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chemicals = await _context.Chemicals.FirstOrDefaultAsync(m => m.ID == id);

            if (Chemicals == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chemicals = await _context.Chemicals.FindAsync(id);

            if (Chemicals != null)
            {
                _context.Chemicals.Remove(Chemicals);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
