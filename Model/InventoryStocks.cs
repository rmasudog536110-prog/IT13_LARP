using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IT13_Masudog.model
{
    internal class InventoryStocks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double priceD { get; set; }
        public int quantity { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }