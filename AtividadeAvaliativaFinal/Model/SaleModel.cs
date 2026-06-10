using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Model
{
    class SaleModel
    {
        private int Id { get; set; }
        private int Code { get; set; }
        private int ClientId { get; set; }
        private List<(int Id, int Amount)> Products { get; set; }
        private double Value { get; set; }
    }
}
