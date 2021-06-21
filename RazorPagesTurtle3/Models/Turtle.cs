using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTurtle3.Models
{
    public class Turtle
    {
        public int ID { get; set; }
        public string TurtleName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
