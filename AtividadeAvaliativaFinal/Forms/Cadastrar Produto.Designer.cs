namespace AtividadeAvaliativaFinal.Forms
{
    partial class Cadastrar_Produto
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
            label1 = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            txtValue = new NumericUpDown();
            txtAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Produtos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(588, 23);
            txtName.TabIndex = 7;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(90, 185);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(588, 23);
            txtCategory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 112);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome do protudo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 167);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 232);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 10;
            label4.Text = "Valor unitário (R$):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 296);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 11;
            label5.Text = "Quantidade em Estoque:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(168, 370);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(159, 34);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Cadastrar";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(372, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtValue
            // 
            txtValue.DecimalPlaces = 2;
            txtValue.Location = new Point(90, 250);
            txtValue.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(588, 23);
            txtValue.TabIndex = 14;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(90, 314);
            txtAmount.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(588, 23);
            txtAmount.TabIndex = 15;
            // 
            // Cadastrar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAmount);
            Controls.Add(txtValue);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtCategory);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowText;
            Name = "Cadastrar_Produto";
            Text = "Cadastrar_Produto";
            ((System.ComponentModel.ISupportInitialize)txtValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtName;
        private TextBox txtCategory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private NumericUpDown txtValue;
        private NumericUpDown txtAmount;
    }
}