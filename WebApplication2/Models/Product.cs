using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string ProsuctName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }
    }
}
