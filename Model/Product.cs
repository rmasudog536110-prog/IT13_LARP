using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IT13_Masudog.model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public int BarCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? LastUpdated { get; set; }

    }