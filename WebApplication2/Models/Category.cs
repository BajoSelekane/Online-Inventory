using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

    }
}
