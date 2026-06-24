using AtividadeAvaliativaFinal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AtividadeAvaliativaFinal.Context
{
    public class DBJson
    {
        public static string Clients = Path.Combine(AppContext.BaseDirectory, "Context", "Data", "Clients.json");
        public static string Products = Path.Combine(AppContext.BaseDirectory, "Context", "Data", "Products.json");
        public static string Sales = Path.Combine(AppContext.BaseDirectory, "Context", "Data", "Sales.json");

    }
}
