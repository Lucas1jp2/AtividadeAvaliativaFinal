using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Model
{
    class SaleModel
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public (string Name, string Category, double Value) Product { get; set; }
        public string ProductName { get { return Product.Name; } }
        public string ProductCategory { get { return Product.Category; } }
        public double ProductValue { get { return Product.Value; } }
        public int Amount { get; set; }
        public double TotalValue { get; set; }
    }
}
