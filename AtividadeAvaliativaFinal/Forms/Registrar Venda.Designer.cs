namespace AtividadeAvaliativaFinal.Forms
{
    partial class Registrar_Venda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtValue = new TextBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            btnAddInList = new Button();
            gridSellItems = new DataGridView();
            gridId = new DataGridViewTextBoxColumn();
            gridCpf = new DataGridViewTextBoxColumn();
            gridProd = new DataGridViewTextBoxColumn();
            gridCategory = new DataGridViewTextBoxColumn();
            gridValue = new DataGridViewTextBoxColumn();
            gridAmount = new DataGridViewTextBoxColumn();
            gridTotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbClient = new ComboBox();
            cbProd = new ComboBox();
            txtAmountBuy = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gridSellItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAmountBuy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 5);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "Registrar vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(39, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 23);
            txtName.TabIndex = 3;
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Location = new Point(422, 125);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(320, 23);
            txtCategory.TabIndex = 4;
            // 
            // txtValue
            // 
            txtValue.Enabled = false;
            txtValue.Location = new Point(39, 169);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(322, 23);
            txtValue.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(422, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 34);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "CANCELAR VENDA";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(218, 455);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(159, 34);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "SALVAR VENDA";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnAddInList
            // 
            btnAddInList.Location = new Point(316, 204);
            btnAddInList.Name = "btnAddInList";
            btnAddInList.Size = new Size(167, 29);
            btnAddInList.TabIndex = 16;
            btnAddInList.Text = "ADD(+)";
            btnAddInList.UseVisualStyleBackColor = true;
            btnAddInList.Click += btnAddInList_Click;
            // 
            // gridSellItems
            // 
            gridSellItems.AllowUserToAddRows = false;
            gridSellItems.AllowUserToOrderColumns = true;
            gridSellItems.AutoGenerateColumns = false;
            gridSellItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSellItems.Columns.AddRange(new DataGridViewColumn[] { gridId, gridCpf, gridProd, gridCategory, gridValue, gridAmount, gridTotal });
            gridSellItems.Location = new Point(39, 245);
            gridSellItems.Name = "gridSellItems";
            gridSellItems.RowHeadersVisible = false;
            gridSellItems.RowHeadersWidth = 62;
            gridSellItems.Size = new Size(703, 192);
            gridSellItems.TabIndex = 17;
            gridSellItems.CellContentClick += dataGridView1_CellContentClick;
            gridSellItems.CellFormatting += gridSellItems_CellFormatting;
            // 
            // gridId
            // 
            gridId.DataPropertyName = "Id";
            gridId.HeaderText = "Codigo Venda";
            gridId.MinimumWidth = 8;
            gridId.Name = "gridId";
            gridId.Width = 150;
            // 
            // gridCpf
            // 
            gridCpf.DataPropertyName = "Client";
            gridCpf.HeaderText = "Cpf - Cliente";
            gridCpf.MinimumWidth = 8;
            gridCpf.Name = "gridCpf";
            gridCpf.Width = 150;
            // 
            // gridProd
            // 
            gridProd.DataPropertyName = "Name";
            gridProd.HeaderText = "Produto";
            gridProd.MinimumWidth = 8;
            gridProd.Name = "gridProd";
            gridProd.Width = 150;
            // 
            // gridCategory
            // 
            gridCategory.DataPropertyName = "Category";
            gridCategory.HeaderText = "Categoria";
            gridCategory.MinimumWidth = 8;
            gridCategory.Name = "gridCategory";
            gridCategory.Width = 150;
            // 
            // gridValue
            // 
            gridValue.DataPropertyName = "Value";
            dataGridViewCellStyle1.Format = "C2";
            gridValue.DefaultCellStyle = dataGridViewCellStyle1;
            gridValue.HeaderText = "Valor Unitário";
            gridValue.MinimumWidth = 8;
            gridValue.Name = "gridValue";
            gridValue.Width = 150;
            // 
            // gridAmount
            // 
            gridAmount.DataPropertyName = "Amount";
            gridAmount.HeaderText = "Quantidade";
            gridAmount.MinimumWidth = 8;
            gridAmount.Name = "gridAmount";
            gridAmount.Width = 150;
            // 
            // gridTotal
            // 
            gridTotal.DataPropertyName = "TotalValue";
            dataGridViewCellStyle2.Format = "C2";
            gridTotal.DefaultCellStyle = dataGridViewCellStyle2;
            gridTotal.HeaderText = "Total";
            gridTotal.MinimumWidth = 8;
            gridTotal.Name = "gridTotal";
            gridTotal.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 22);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 18;
            label2.Text = "Selecionar Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 64);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 19;
            label3.Text = "Selecionar Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 107);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 20;
            label4.Text = "Nome do Produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 107);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 21;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 154);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 22;
            label6.Text = "Valor unitário:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 154);
            label7.Name = "label7";
            label7.Size = new Size(156, 15);
            label7.TabIndex = 23;
            label7.Text = "Quantidade a ser comprada:";
            // 
            // cbClient
            // 
            cbClient.FormattingEnabled = true;
            cbClient.Items.AddRange(new object[] { "    " });
            cbClient.Location = new Point(39, 40);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(703, 23);
            cbClient.TabIndex = 24;
            // 
            // cbProd
            // 
            cbProd.FormattingEnabled = true;
            cbProd.Items.AddRange(new object[] { "    " });
            cbProd.Location = new Point(39, 82);
            cbProd.Name = "cbProd";
            cbProd.Size = new Size(703, 23);
            cbProd.TabIndex = 25;
            cbProd.SelectedIndexChanged += cbProd_SelectedIndexChanged;
            // 
            // txtAmountBuy
            // 
            txtAmountBuy.Location = new Point(422, 169);
            txtAmountBuy.Name = "txtAmountBuy";
            txtAmountBuy.Size = new Size(320, 23);
            txtAmountBuy.TabIndex = 26;
            txtAmountBuy.ValueChanged += txtAmountBuy_ValueChanged;
            // 
            // Registrar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(txtAmountBuy);
            Controls.Add(cbProd);
            Controls.Add(cbClient);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gridSellItems);
            Controls.Add(btnAddInList);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtValue);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Registrar_Venda";
            Text = "Registrar_Venda";
            Load += Registrar_Venda_Load;
            ((System.ComponentModel.ISupportInitialize)gridSellItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAmountBuy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtValue;
        private Button btnCancel;
        private Button btnSubmit;
        private Button btnAddInList;
        private DataGridView gridSellItems;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbClient;
        private ComboBox cbProd;
        private NumericUpDown txtAmountBuy;
        private DataGridViewTextBoxColumn gridId;
        private DataGridViewTextBoxColumn gridCpf;
        private DataGridViewTextBoxColumn gridProd;
        private DataGridViewTextBoxColumn gridCategory;
        private DataGridViewTextBoxColumn gridValue;
        private DataGridViewTextBoxColumn gridAmount;
        private DataGridViewTextBoxColumn gridTotal;
    }
}