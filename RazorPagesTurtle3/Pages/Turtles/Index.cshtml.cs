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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTurtle3.Data.RazorPagesTurtle3Context _context;

        public IndexModel(RazorPagesTurtle3.Data.RazorPagesTurtle3Context context)
        {
            _context = context;
        }

        public IList<Turtle> Turtle { get;set; }

        public async Task OnGetAsync()
        {
            Turtle = await _context.Turtle.ToListAsync();
        }
    }
}
