using AtividadeAvaliativaFinal.Context;
using AtividadeAvaliativaFinal.CRUD;
using AtividadeAvaliativaFinal.Untils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AtividadeAvaliativaFinal.Model
{
    class ProductCRUD : CRUD<ProductModel>
    {
        public bool Create(ProductModel product)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);

                products.Add(product);

                string _json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(DBJson.Products, _json);

                ShowMessages.Success("Product created.");
                return true;
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Create Product", "Cannot create a product.");
                return false;
            }
        }

        public List<ProductModel> Read()
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);

                if (products != null) return products;
                else return new List<ProductModel>(0);
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Products", "Cannot get products.");
                return new List<ProductModel>(0);
            }
        }

        public ProductModel ReadById(int id)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);
                var product = products.FirstOrDefault(p => p.Id == id);

                if (product != null) return product;
                else return new ProductModel();
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Product", "Cannot get product.");
                return new ProductModel();
            }
        }

        public ProductModel ReadByName(string name)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);
                var product = products.FirstOrDefault(p => p.Name == name);

                if (product != null) return product;
                else return new ProductModel();
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Product", "Cannot get product.");
                return new ProductModel();
            }
        }

        public void Update(ProductModel product)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);

                var _product = products.FirstOrDefault(p => p.Id == product.Id);

                if (_product != null)
                {
                    _product.Name = product.Name;
                    _product.Category = product.Category;
                    _product.Value = product.Value;
                    _product.Amount = product.Amount;
                    _product.TotalValue = product.Value * product.Amount;
                }
                else ShowMessages.ErrorAlt($"The product #{product.Id} don't exist");

                string _json = JsonSerializer.Serialize(products);
                File.WriteAllText(DBJson.Products, _json);

                ShowMessages.Success("Product edited.");
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Edit Product", "Cannot edit product.");
            }
        }

        public void Delete(ProductModel product)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);

                var _product = products.FirstOrDefault(p => p.Id == product.Id);

                if (_product != null) products.Remove(_product);
                else ShowMessages.ErrorAlt($"The product #{product.Id} don't exist");

                string _json = JsonSerializer.Serialize(products);
                File.WriteAllText(DBJson.Products, _json);

                ShowMessages.Success("Product deleted.");
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Delete product", "Cannot delete product.");
            }
        }

        public int GenId()
        {
            try
            {
                string json = File.ReadAllText(DBJson.Products);
                var products = JsonSerializer.Deserialize<List<ProductModel>>(json);

                int newId;

                if (products.Count >= 500)
                {
                    ShowMessages.ErrorAlt("You can't register more products (limit: 500).");
                    return 0;
                }
                else
                {
                    Random random = new Random();

                    while (true)
                    {
                        newId = random.Next(1, 500);
                        var product = products.FirstOrDefault(p => p.Id == newId);
                        if (product == null) break;
                    }

                    return newId;
                }
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Generate Product Id", "Cannot generate id.");
                return 0;
            }
        }
    }
}
