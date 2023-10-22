using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutority.Data;
using WebAppAutority.Data.Identity;

namespace WebAppAutority.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly WebAppAutority.Data.ApplicationDbContext _context;

        public IndexModel(WebAppAutority.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Clients != null)
            {
                Client = await _context.Clients.ToListAsync();
            }
        }
    }
}
