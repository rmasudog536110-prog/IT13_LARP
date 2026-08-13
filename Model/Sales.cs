using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IT13_Masudog.model
{
    internal class Sales
    {
        public string SaleId { get; set; } = Guid.NewGuid().ToString();
        public DateTime Date { get; set; } = DateTime.Now;
        public string ProcessedBy { get; set; }
        public List<SaleItem> Items { get; set; } = new List<SaleItem>();
        public decimal TotalAmount => Items.Sum(i => i.Subtotal);


    }