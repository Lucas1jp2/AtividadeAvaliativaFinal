using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Model
{
    class SaleModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double TotalValue { get; set; }
    }
}
