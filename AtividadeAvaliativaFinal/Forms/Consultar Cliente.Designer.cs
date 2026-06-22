namespace AtividadeAvaliativaFinal.Forms
{
    partial class Consultar_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNomeCliente = new TextBox();
            txtCpfCliente = new TextBox();
            txtEmailCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            label1 = new Label();
            label6 = new Label();
            cbSelecionarClienteConsultarCliente = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 315);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 33;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 251);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 32;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 186);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 31;
            label3.Text = "Cpf:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 131);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 30;
            label2.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(106, 149);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(588, 23);
            txtNomeCliente.TabIndex = 29;
            // 
            // txtCpfCliente
            // 
            txtCpfCliente.Location = new Point(106, 204);
            txtCpfCliente.Name = "txtCpfCliente";
            txtCpfCliente.Size = new Size(588, 23);
            txtCpfCliente.TabIndex = 28;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(106, 269);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(588, 23);
            txtEmailCliente.TabIndex = 27;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(106, 333);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(588, 23);
            txtTelefoneCliente.TabIndex = 26;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 25;
            label1.Text = "Consultar Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 61);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 37;
            label6.Text = "Selecionar Cliente:";
            // 
            // cbSelecionarClienteConsultarCliente
            // 
            cbSelecionarClienteConsultarCliente.FormattingEnabled = true;
            cbSelecionarClienteConsultarCliente.Location = new Point(157, 79);
            cbSelecionarClienteConsultarCliente.Name = "cbSelecionarClienteConsultarCliente";
            cbSelecionarClienteConsultarCliente.Size = new Size(479, 23);
            cbSelecionarClienteConsultarCliente.TabIndex = 38;
            cbSelecionarClienteConsultarCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Consultar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSelecionarClienteConsultarCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtCpfCliente);
            Controls.Add(txtEmailCliente);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(label1);
            Name = "Consultar_Cliente";
            Text = "Consultar_Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNomeCliente;
        private TextBox txtCpfCliente;
        private TextBox txtEmailCliente;
        private TextBox txtTelefoneCliente;
        private Label label1;
        private Label label6;
        private ComboBox cbSelecionarClienteConsultarCliente;
    }
}