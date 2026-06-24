namespace AtividadeAvaliativaFinal.Forms
{
    partial class Consultar_Venda
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
            btnFilter = new Button();
            label2 = new Label();
            label3 = new Label();
            txtCpf = new MaskedTextBox();
            txtSale = new NumericUpDown();
            gridSales = new DataGridView();
            gridId = new DataGridViewTextBoxColumn();
            gridClient = new DataGridViewTextBoxColumn();
            gridName = new DataGridViewTextBoxColumn();
            gridCategory = new DataGridViewTextBoxColumn();
            gridValue = new DataGridViewTextBoxColumn();
            gridAmount = new DataGridViewTextBoxColumn();
            gridTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)txtSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 5);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = " Listar Vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(312, 120);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(167, 29);
            btnFilter.TabIndex = 16;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 22);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 18;
            label2.Text = "CPF do Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 64);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 19;
            label3.Text = "Codigo da Venda";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(42, 38);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(700, 23);
            txtCpf.TabIndex = 27;
            // 
            // txtSale
            // 
            txtSale.Location = new Point(39, 82);
            txtSale.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(703, 23);
            txtSale.TabIndex = 28;
            // 
            // gridSales
            // 
            gridSales.AllowUserToAddRows = false;
            gridSales.AllowUserToOrderColumns = true;
            gridSales.AutoGenerateColumns = false;
            gridSales.Columns.AddRange(new DataGridViewColumn[] { gridId, gridClient, gridName, gridCategory, gridValue, gridAmount, gridTotal });
            gridSales.Location = new Point(39, 171);
            gridSales.Name = "gridSales";
            gridSales.RowHeadersVisible = false;
            gridSales.Size = new Size(703, 323);
            gridSales.TabIndex = 29;
            gridSales.CellFormatting += gridSales_CellFormatting;
            // 
            // gridId
            // 
            gridId.DataPropertyName = "Id";
            gridId.HeaderText = "Codigo Venda";
            gridId.Name = "gridId";
            gridId.Width = 150;
            // 
            // gridClient
            // 
            gridClient.DataPropertyName = "Client";
            gridClient.HeaderText = "CPF - Cliente";
            gridClient.Name = "gridClient";
            gridClient.Width = 150;
            // 
            // gridName
            // 
            gridName.DataPropertyName = "Name";
            gridName.HeaderText = "Produto";
            gridName.Name = "gridName";
            gridName.Width = 150;
            // 
            // gridCategory
            // 
            gridCategory.DataPropertyName = "Category";
            gridCategory.HeaderText = "Categoria";
            gridCategory.Name = "gridCategory";
            gridCategory.Width = 150;
            // 
            // gridValue
            // 
            gridValue.DataPropertyName = "Value";
            gridValue.HeaderText = "Valor Unitario";
            gridValue.Name = "gridValue";
            gridValue.Width = 150;
            gridValue.DefaultCellStyle.Format = "C2";
            // 
            // gridAmount
            // 
            gridAmount.DataPropertyName = "Amount";
            gridAmount.HeaderText = "Quantidade";
            gridAmount.Name = "gridAmount";
            gridAmount.Width = 150;
            // 
            // gridTotal
            // 
            gridTotal.DataPropertyName = "TotalValue";
            gridTotal.HeaderText = "Total";
            gridTotal.Name = "gridTotal";
            gridTotal.DefaultCellStyle.Format = "C2";
            gridTotal.Width = 150;
            // 
            // Consultar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(gridSales);
            Controls.Add(txtSale);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Name = "Consultar_Venda";
            Text = "Consultar_Venda";
            ((System.ComponentModel.ISupportInitialize)txtSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFilter;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtCpf;
        private NumericUpDown txtSale;
        private DataGridView gridSales;
        private DataGridViewTextBoxColumn gridId;
        private DataGridViewTextBoxColumn gridClient;
        private DataGridViewTextBoxColumn gridName;
        private DataGridViewTextBoxColumn gridCategory;
        private DataGridViewTextBoxColumn gridValue;
        private DataGridViewTextBoxColumn gridAmount;
        private DataGridViewTextBoxColumn gridTotal;
    }
}