using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Model
{
    class SaleGridModel
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Value { get; set; }
        public int Amount { get; set; }
        public double TotalValue { get; set; }
    }
}
