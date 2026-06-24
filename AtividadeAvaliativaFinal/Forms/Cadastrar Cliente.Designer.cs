namespace AtividadeAvaliativaFinal.Forms
{
    partial class Cadastrar_Cliente
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
            btnCancel = new Button();
            btnSubmit = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPhone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(388, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 34);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(184, 389);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(159, 34);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Cadastrar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 315);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 22;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 251);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 21;
            label4.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 186);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 20;
            label3.Text = "Cpf:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 131);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 19;
            label2.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(588, 23);
            txtName.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 269);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(588, 23);
            txtEmail.TabIndex = 16;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 28);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 14;
            label1.Text = "Cadastrar Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(106, 333);
            txtPhone.Mask = "(00) 0 0000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(588, 23);
            txtPhone.TabIndex = 25;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(106, 204);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(588, 23);
            txtCpf.TabIndex = 26;
            // 
            // Cadastrar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCpf);
            Controls.Add(txtPhone);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Cadastrar_Cliente";
            Text = "Cadastrar_Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSubmit;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label1;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtCpf;
    }
}