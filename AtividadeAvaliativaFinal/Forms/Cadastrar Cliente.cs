using AtividadeAvaliativaFinal.Context;
using AtividadeAvaliativaFinal.Model;
using AtividadeAvaliativaFinal.Untils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AtividadeAvaliativaFinal.Forms
{
    public partial class Cadastrar_Cliente : Form
    {
        public Cadastrar_Cliente()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool validCpf = true, validPhone = true, validEmail = true, validName = true;
            if (Checker.ValidCPF(txtCpf.Text)) validCpf = false;
            if (!Checker.ValidPhone(txtPhone.Text)) validPhone = false;
            if (!Checker.ValidEmail(txtEmail.Text)) validEmail = false;
            if (Checker.NumInText(txtName.Text)) { ShowMessages.InvalidData("Nome"); validName = false; }

            if (validCpf && validPhone && validEmail && validName)
            {
                ClientCRUD CRUD = new ClientCRUD();

                ClientModel Client = new ClientModel { Id = CRUD.GenId(), CPF = txtCpf.Text, Email = txtEmail.Text, Name = txtName.Text, Phone = txtPhone.Text };

                CRUD.Create(Client);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }
    }
}
