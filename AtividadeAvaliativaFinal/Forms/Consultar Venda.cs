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
    public partial class Consultar_Venda : Form
    {
        SaleCRUD saleCRUD = new SaleCRUD();
        ProductCRUD prodCRUD = new ProductCRUD();
        ClientCRUD clientCRUD = new ClientCRUD();
        List<SaleModel> SalesList = new List<SaleModel>();

        public Consultar_Venda()
        {
            InitializeComponent();

            SalesList.AddRange(saleCRUD.Read());
            genGridItems(SalesList, "", 0);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SalesList.Clear();

            if (
                txtCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "").Length > 0 &&
                Checker.ValidCPF(txtCpf.Text) &&
                txtSale.Value > 0
            ) SalesList.AddRange(saleCRUD.ReadByFilter(Convert.ToInt16(txtSale.Value), txtCpf.Text));

            else if (
                txtCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "").Length > 0 &&
                Checker.ValidCPF(txtCpf.Text)
            ) SalesList.AddRange(saleCRUD.ReadByFilter(0, txtCpf.Text));

            else if (txtSale.Value > 0) SalesList.AddRange(saleCRUD.ReadByFilter(Convert.ToInt16(txtSale.Value)));

            else SalesList.AddRange(saleCRUD.Read());

            genGridItems(SalesList, txtCpf.Text, Convert.ToInt16(txtSale.Value));
        }

        private void genGridItems(List<SaleModel> sales, string? cpf = "", int? saleId = 0)
        {
            List<(SaleModel sale, ClientModel client, ProductModel product)> formatSales = new List<(SaleModel sale, ClientModel client, ProductModel product)>();

            var client = new ClientModel();
            var sale = new SaleModel();

            foreach (var _sale in sales)
            {
                var _client = clientCRUD.ReadById(_sale.ClientId);
                var _product = prodCRUD.ReadById(_sale.ProductId);

                if (_product != null && _client != null) formatSales.Add((_sale, _client, _product!));
            }

            if (Checker.ValidCPF(cpf) && cpf.Length > 0) client = clientCRUD.ReadByCPF(cpf);
            if (saleId != 0) sale = saleCRUD.ReadById(Convert.ToInt16(saleId));

            if(Checker.ValidCPF(cpf) && cpf.Length > 0 && saleId != 0) 
            {
                var filterSales = formatSales.Where(s => s.client.CPF == client.CPF && s.sale.Id == sale.Id).ToList();
                formatSales.Clear();
                formatSales.AddRange(filterSales);
            }
            else if(Checker.ValidCPF(cpf) && cpf.Length > 0) 
            {
                var filterSales = formatSales.Where(s => s.client.CPF == client.CPF).ToList();
                formatSales.Clear();
                formatSales.AddRange(filterSales);
            }
            else if(saleId != 0) 
            {
                var filterSales = formatSales.Where(s => s.sale.Id == sale.Id).ToList();
                formatSales.Clear();
                formatSales.AddRange(filterSales);
            }

            gridSales.DataSource = null;
            gridSales.DataSource = formatSales.Select(x => new
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

        private void gridSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
