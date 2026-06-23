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
    public partial class Consultar_Cliente : Form
    {
        ClientCRUD CRUD = new ClientCRUD();

        public Consultar_Cliente()
        {
            InitializeComponent();
            
            var clients = CRUD.Read();

            foreach (var client in clients)
            {
                cbClients.Items.Add(client.Name);
            }

        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = CRUD.ReadByName(cbClients.Text);

            txtName.Text = client.Name;
            txtCpf.Text = client.CPF;
            txtPhone.Text = client.Phone;
            txtEmail.Text = client.Email;
        }
    }
}
