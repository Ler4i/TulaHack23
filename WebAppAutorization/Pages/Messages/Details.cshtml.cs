﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;

namespace WebAppAutorization.Pages.Messages
{
    public class DetailsModel : PageModel
    {
        private readonly WebAppAutorization.Data.ApplicationDbContext _context;

        public DetailsModel(WebAppAutorization.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Message Message { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Messages == null)
            {
                return NotFound();
            }

            var message = await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
            if (message == null)
            {
                return NotFound();
            }
            else 
            {
                Message = message;
            }
            return Page();
        }
    }
}
