using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    internal class Product
    {
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal ProductCost { get; set; }
        public int MaxDiscount { get; set; }
        public int ProductManufacturer { get; set; }
        public int ProductSupplier { get; set; }
        public int ProductCategory { get; set; }
        public int ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPhoto { get; set; }
    }
}
