using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle3.Data;
using RazorPagesTurtle3.Models;

namespace RazorPagesTurtle3.Pages.Turtles
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesTurtle3.Data.RazorPagesTurtle3Context _context;

        public DeleteModel(RazorPagesTurtle3.Data.RazorPagesTurtle3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Turtle Turtle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Turtle = await _context.Turtle.FirstOrDefaultAsync(m => m.ID == id);

            if (Turtle == null)
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

            Turtle = await _context.Turtle.FindAsync(id);

            if (Turtle != null)
            {
                _context.Turtle.Remove(Turtle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
