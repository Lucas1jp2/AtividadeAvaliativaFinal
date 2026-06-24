using AtividadeAvaliativaFinal.Context;
using AtividadeAvaliativaFinal.CRUD;
using AtividadeAvaliativaFinal.Untils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace AtividadeAvaliativaFinal.Model
{
    class SaleCRUD : CRUD<SaleModel>
    {
        public bool Create(SaleModel sale)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Sales);
                var sales = JsonSerializer.Deserialize<List<SaleModel>>(json);

                sales.Add(sale);

                string _json = JsonSerializer.Serialize(sales);
                File.WriteAllText(DBJson.Sales, _json);

                ShowMessages.Success("Sale registered.");
                return true;
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Register Sale", "Cannot register a sale.");
                return false;
            }
        }

        public List<SaleModel> Read()
        {
            try
            {
                string json = File.ReadAllText(DBJson.Sales);
                var sales = JsonSerializer.Deserialize<List<SaleModel>>(json);

                if (sales != null) return sales;
                else return new List<SaleModel>(0);
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Sales", "Cannot get sales.");
                return new List<SaleModel>(0);
            }
        }

        public SaleModel ReadById(int id)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Sales);
                var sales = JsonSerializer.Deserialize<List<SaleModel>>(json);
                var sale = sales.FirstOrDefault(s => s.Id == id);

                if (sale != null) return sale;
                else return new SaleModel();
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Sale", "Cannot get sale.");
                return new SaleModel();
            }
        }

        public List<SaleModel> ReadByFilter(int? id = 0, string? cpf = "")
        {
            try
            {
                var sales = Read();
                var filterSales = new List<SaleModel>();

                if(sales != null)
                {
                    if (id != 0 && cpf != "" && Checker.ValidCPF(cpf)) filterSales.AddRange(sales.Where(s => s.Id == id && s.Client == cpf));
                    else if (id != 0) filterSales.AddRange(sales.Where(s => s.Id == id));
                    else if (cpf != "" && Checker.ValidCPF(cpf)) filterSales.AddRange(sales.Where(s => s.Client == cpf));
                    else filterSales.AddRange(sales);

                    filterSales.OrderBy(s => s.Id).OrderBy(s => s.Client);

                    return filterSales;
                }
                else return filterSales;
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Sales", "Cannot get sales.");
                return new List<SaleModel>();
            }
        }

        public void Update(SaleModel sale)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Sales);
                var sales = JsonSerializer.Deserialize<List<SaleModel>>(json);

                var _sale = sales.FirstOrDefault(s => s.Id == sale.Id);

                if (_sale != null)
                {
                    _sale.Client = sale.Client;
                    _sale.Product = sale.Product;
                    _sale.Amount = sale.Amount;
                    _sale.TotalValue = sale.Product.Value * sale.Amount;
                }
                else ShowMessages.ErrorAlt($"The sale #{sale.Id} don't exist");

                string _json = JsonSerializer.Serialize(sales);
                File.WriteAllText(DBJson.Sales, _json);

                ShowMessages.Success("Sale edited.");
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Edit Sale", "Cannot edit sale.");
            }
        }

        public void Delete(SaleModel sale)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Sales);
                var sales = JsonSerializer.Deserialize<List<SaleModel>>(json);

                var _sale = sales.FirstOrDefault(s => s.Id == sale.Id);

                if (_sale != null) sales.Remove(_sale);
                else ShowMessages.ErrorAlt($"The sale #{sale.Id} don't exist");

                string _json = JsonSerializer.Serialize(sales);
                File.WriteAllText(DBJson.Sales, _json);

                ShowMessages.Success("Sale deleted.");
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Delete Sale", "Cannot delete sale.");
            }
        }

        public int GenId()
        {
            try
            {
                string json = File.ReadAllText(DBJson.Sales);
                var sales = JsonSerializer.Deserialize<List<SaleModel>>(json);

                int newId;

                if (sales.Count >= 9999)
                {
                    ShowMessages.ErrorAlt("You can't register more sales (limit: 9999).");
                    return 0;
                }
                else
                {
                    Random random = new Random();

                    while (true)
                    {
                        newId = random.Next(1, 9999);
                        var sale = sales.FirstOrDefault(s => s.Id == newId);
                        if (sale == null) break;
                    }

                    return newId;
                }
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Generate Sale Id", "Cannot generate id.");
                return 0;
            }
        }
    }
}
