using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
