using AtividadeAvaliativaFinal.Model;
using AtividadeAvaliativaFinal.Untils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeAvaliativaFinal.Forms
{
    public partial class Registrar_Venda : Form
    {
        int saleId;

        SaleCRUD saleCRUD = new SaleCRUD();
        ProductCRUD prodCRUD = new ProductCRUD();
        ClientCRUD clientCRUD = new ClientCRUD();
        List<SaleModel> saleItems = new List<SaleModel>();

        public Registrar_Venda()
        {
            InitializeComponent();

            saleId = saleCRUD.GenId();

            var clients = clientCRUD.Read();
            var prods = prodCRUD.Read();

            foreach (var prod in prods) cbProd.Items.Add(prod.Product);

            foreach (var client in clients) cbClient.Items.Add(client.Name);
        }

        private void cbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prod = prodCRUD.ReadByName(cbProd.Text);

            txtName.Text = prod.Product;
            txtCategory.Text = prod.Category;
            txtValue.Text = prod.Value.ToString();
            txtAmountBuy.Value = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registrar_Venda_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmountBuy.Value = 0;
            txtCategory.Text = "";
            txtName.Text = "";
            txtValue.Text = "";

            cbClient.SelectedIndex = 0;
            cbProd.SelectedIndex = 0;

            saleItems.Clear();
            gridSellItems.DataSource = null;
            saleId = saleCRUD.GenId();
        }

        private void btnAddInList_Click(object sender, EventArgs e)
        {
            if (cbClient.Text.Replace(" ", "").Length > 0 && cbProd.Text.Replace(" ", "").Length > 0)
            {
                var client = clientCRUD.ReadByName(cbClient.Text);
                var prod = prodCRUD.ReadByName(txtName.Text);

                if (prod != null && client != null)
                {
                    if (txtAmountBuy.Value > 0 && txtAmountBuy.Value <= prod.Amount)
                    {
                        SaleModel item = new SaleModel
                        {
                            Id = saleId,
                            Amount = Convert.ToInt16(txtAmountBuy.Value),
                            ClientId = client.Id,
                            ProductId = prod.Id,
                            TotalValue = Convert.ToInt16(txtAmountBuy.Value) * prod.Value
                        };

                        saleItems.Add(item);

                        genGridItems(saleItems);

                        prod.Amount = prod.Amount - Convert.ToInt16(txtAmountBuy.Value);

                        if (txtAmountBuy.Value >= prod.Amount) txtAmountBuy.Value = prod.Amount;

                        prodCRUD.Update(prod);
                    }
                    else if (prod.Amount == 0) ShowMessages.ErrorAlt($"Dont have more products in stock.");
                }
                else ShowMessages.ErrorAlt("Product or Client wrong.");

            }
        }

        private void genGridItems(List<SaleModel> sales)
        {
            List<(SaleModel sale, ClientModel client, ProductModel product)> formatSales = new List<(SaleModel sale, ClientModel client, ProductModel product)>();

            foreach (var sale in sales)
            {
                var client = clientCRUD.ReadById(sale.ClientId);
                var product = prodCRUD.ReadById(sale.ProductId);

                if(product != null && client != null)formatSales.Add((sale, client, product!)); 
            }

            gridSellItems.DataSource = null;
            gridSellItems.DataSource = formatSales.Select(x => new
            {
                x.sale.Id,
                x.client.CPF,
                x.product.Product,
                x.product.Category,
                x.product.Value,
                x.sale.Amount,
                x.sale.TotalValue
            }).ToList();
        }

        private void gridSellItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (saleItems.Count > 0) foreach (var sale in saleItems) saleCRUD.Create(sale);
            else ShowMessages.ErrorAlt("Don't have sales for submit the register.");
        } 
        private void txtAmountBuy_ValueChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Replace(" ", "").Length > 0)
            {
                var prod = prodCRUD.ReadByName(txtName.Text);

                if (prod != null)
                {
                    if (txtAmountBuy.Value > prod.Amount && prod.Amount > 0)
                    {
                        ShowMessages.ErrorAlt($"Just have {prod.Amount} products in stock.");
                        txtAmountBuy.Value = prod.Amount;
                    }
                    if (prod.Amount == 0)
                    {
                        ShowMessages.ErrorAlt($"Dont have more products in stock.");
                        txtAmountBuy.Value = 0;
                    }
                    if (txtAmountBuy.Value > 100)
                    {
                        ShowMessages.ErrorAlt($"You can select 100 units.");
                        txtAmountBuy.Value = 100;
                    }
                }
            } else txtAmountBuy.Value = 0;
        }
    }
}
