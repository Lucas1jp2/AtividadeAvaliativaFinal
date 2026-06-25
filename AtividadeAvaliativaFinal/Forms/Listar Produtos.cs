using AtividadeAvaliativaFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeAvaliativaFinal.Forms
{
    public partial class Listar_Produto : Form
    {
        ProductCRUD CRUD = new ProductCRUD();
        List<ProductModel> ProdList = new List<ProductModel>();

        public Listar_Produto()
        {
            InitializeComponent();
            ProdList = CRUD.Read();
            gridProds.DataSource = ProdList.OrderBy(p => p.Category).ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ProdList.Clear();
            var formatList = CRUD.Read();

            if (txtFilter.Text.Replace(" ", "").Length > 0 && txtCategory.Text.Replace(" ", "").Length > 0)
            {
                ProdList.AddRange(formatList.Where(p => p.Product == txtFilter.Text && p.Category == txtCategory.Text));
            }
            else if (txtFilter.Text.Replace(" ", "").Length > 0 && txtCategory.Text.Replace(" ", "").Length == 0)
            {
                ProdList.AddRange(formatList.Where(p => p.Product == txtFilter.Text));
            }
            else if (txtCategory.Text.Replace(" ", "").Length == 0 && txtCategory.Text.Replace(" ", "").Length > 0)
            {
                ProdList.AddRange(formatList.Where(p => p.Product == txtCategory.Text));
            }
            else ProdList.AddRange(formatList);

            gridProds.DataSource = ProdList.OrderBy(p => p.Category).ToList();

        }
    }
}
