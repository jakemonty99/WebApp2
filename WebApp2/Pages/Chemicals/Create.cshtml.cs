#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp2.Data;
using WebApp2.Models;

namespace WebApp2.Pages.Chemicals
{
    public class CreateModel : PageModel
    {
        private readonly WebApp2.Data.Inventory _context;

        public CreateModel(WebApp2.Data.Inventory context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Chemical Chemicals { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Chemicals.Add(Chemicals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
