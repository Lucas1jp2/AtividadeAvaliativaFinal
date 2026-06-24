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
    public partial class Cadastrar_Produto : Form
    {
        ProductCRUD CRUD = new ProductCRUD();

        public Cadastrar_Produto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtValue.Value > 0 && txtCategory.Text.Replace(" ", "").Length > 0 && txtName.Text.Replace(" ", "").Length > 0) 
            {
                ProductModel product = new ProductModel
                {
                    Id = CRUD.GenId(),
                    Name = txtName.Text,
                    Category = txtCategory.Text,
                    Value = Convert.ToDouble(txtValue.Value),
                    Amount = Convert.ToInt16(txtAmount.Value),
                    TotalValue = Convert.ToDouble(txtValue.Value) * Convert.ToInt16(txtAmount.Value)
                };
                CRUD.Create(product);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCategory.Text = "";
            txtValue.Value = 0;
            txtAmount.Value = 0;   
        }
    }
}
