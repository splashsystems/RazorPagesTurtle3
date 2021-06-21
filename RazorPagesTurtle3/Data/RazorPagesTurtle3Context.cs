using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle3.Models;

namespace RazorPagesTurtle3.Data
{
    public class RazorPagesTurtle3Context : DbContext
    {
        public RazorPagesTurtle3Context (DbContextOptions<RazorPagesTurtle3Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTurtle3.Models.Turtle> Turtle { get; set; }
    }
}
