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
        SaleCRUD CRUD = new SaleCRUD();
        List<SaleModel> SalesList = new List<SaleModel>();

        public Consultar_Venda()
        {
            InitializeComponent();

            SalesList.AddRange(CRUD.Read());
            RenderGrid(SalesList);
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
            ) SalesList.AddRange(CRUD.ReadByFilter(Convert.ToInt16(txtSale.Value), txtCpf.Text));

            else if (
                txtCpf.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("_", "").Length > 0 &&
                Checker.ValidCPF(txtCpf.Text)
            ) SalesList.AddRange(CRUD.ReadByFilter(0, txtCpf.Text));

            else if (txtSale.Value > 0) SalesList.AddRange(CRUD.ReadByFilter(Convert.ToInt16(txtSale.Value)));

            else SalesList.AddRange(CRUD.Read());

            RenderGrid(SalesList);
        }

        private void RenderGrid(List<SaleModel> sales)
        {
            gridSales.DataSource = null;
            gridSales.DataSource = sales;
        }

        private void gridSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                var saleProd = gridSales.Rows[e.RowIndex].DataBoundItem as SaleModel;

                

                if (saleProd != null)
                {
                    if (e.RowIndex >= 0 || e.ColumnIndex >= 0)
                    {
                        if (gridSales.Columns[e.ColumnIndex].Name == "gridName") e.Value = saleProd.Product.Name;
                        if (gridSales.Columns[e.ColumnIndex].Name == "gridCategory") e.Value = saleProd.Product.Category;
                        if (gridSales.Columns[e.ColumnIndex].Name == "gridValue") e.Value = saleProd.Product.Value;

                    }
                }
                
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "See Sales List");
            }
        }
    }
}
