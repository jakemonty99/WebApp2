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
    public class IndexModel : PageModel
    {
        private readonly WebApp2.Data.Inventory _context;

        public IndexModel(WebApp2.Data.Inventory context)
        {
            _context = context;
        }

        public IList<Chemical> Chemicals { get;set; }

        public async Task OnGetAsync()
        {
            Chemicals = await _context.Chemicals.ToListAsync();
        }
    }
}
