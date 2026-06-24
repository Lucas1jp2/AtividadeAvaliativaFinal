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
            txtName = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label6 = new Label();
            cbClients = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 315);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
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
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(106, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(588, 23);
            txtName.TabIndex = 29;
            // 
            // txtCpf
            // 
            txtCpf.Enabled = false;
            txtCpf.Location = new Point(106, 204);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(588, 23);
            txtCpf.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(106, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(588, 23);
            txtEmail.TabIndex = 27;
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(106, 333);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(588, 23);
            txtPhone.TabIndex = 26;
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
            // cbClients
            // 
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(157, 79);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(479, 23);
            cbClients.TabIndex = 38;
            cbClients.SelectedIndexChanged += cbClients_SelectedIndexChanged;
            // 
            // Consultar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbClients);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
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
        private TextBox txtName;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label1;
        private Label label6;
        private ComboBox cbClients;
    }
}