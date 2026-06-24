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
        public int Amount { get; set; }
        public double TotalValue { get; set; }
    }
}
