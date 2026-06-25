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

        public Consultar_Venda()
        {
            InitializeComponent();
            genGridItems(saleCRUD.Read());
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            genGridItems(saleCRUD.Read(), txtCpf.Text, Convert.ToInt16(txtSale.Value));
            MessageBox.Show(txtCpf.Text);
        }

        private void genGridItems(List<SaleModel> sales, string? cpf = "", int? saleId = 0)
        {
            List<(SaleModel sale, ClientModel client, ProductModel product)> formatSales = new List<(SaleModel sale, ClientModel client, ProductModel product)>();

            foreach (var sale in sales)
            {
                var client = clientCRUD.ReadById(sale.ClientId);
                var product = prodCRUD.ReadById(sale.ProductId);

                if (product != null && client != null) formatSales.Add((sale, client, product!));
            }

            if(cpf.Length == 14 && clientCRUD.ReadByCPF(cpf) != null) 
            {
                var filterSales = formatSales.Where(s => s.client.CPF == clientCRUD.ReadByCPF(cpf).CPF).ToList();
                formatSales.Clear();
                formatSales.AddRange(filterSales);
            }

            if(saleId > 0 && saleCRUD.ReadById(Convert.ToInt16(saleId)) != null) 
            {
                var filterSales = formatSales.Where(s => s.sale.Id == saleCRUD.ReadById(Convert.ToInt16(saleId)).Id).ToList();
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
