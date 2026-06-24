namespace AtividadeAvaliativaFinal.Forms
{
    partial class Listar_Produto
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
            label3 = new Label();
            label2 = new Label();
            txtFilter = new TextBox();
            txtCategory = new TextBox();
            btnFilter = new Button();
            gridProds = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            totalProd = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridProds).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 26;
            label1.Text = "Listar Produtos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 120);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 35;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 34;
            label2.Text = "Produto:";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(105, 83);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(588, 23);
            txtFilter.TabIndex = 33;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(105, 138);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(588, 23);
            txtCategory.TabIndex = 32;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(316, 163);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(159, 34);
            btnFilter.TabIndex = 36;
            btnFilter.Text = "FILTRAR";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // gridProds
            // 
            gridProds.AllowUserToAddRows = false;
            gridProds.AutoGenerateColumns = false;
            gridProds.AllowUserToOrderColumns = true;
            gridProds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProds.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Category, Value, Amount, totalProd });
            gridProds.Location = new Point(97, 203);
            gridProds.Name = "gridProds";
            gridProds.RowHeadersVisible = false;
            gridProds.RowHeadersWidth = 62;
            gridProds.Size = new Size(603, 239);
            gridProds.TabIndex = 37;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Name
            // 
            Name.HeaderText = "Produto";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // Category
            // 
            Category.HeaderText = "Categoria";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 150;
            // 
            // Value
            // 
            Value.HeaderText = "Valor Unitário";
            Value.MinimumWidth = 8;
            Value.Name = "Value";
            Value.Width = 150;
            // 
            // Amount
            // 
            Amount.HeaderText = "Quantidade em Estoque";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.Width = 150;
            // 
            // totalProd
            // 
            totalProd.HeaderText = "Total";
            totalProd.MinimumWidth = 8;
            totalProd.Name = "totalProd";
            totalProd.Width = 150;
            // 
            // Listar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridProds);
            Controls.Add(btnFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFilter);
            Controls.Add(txtCategory);
            Controls.Add(label1);
            Text = "Listar_Produto";
            ((System.ComponentModel.ISupportInitialize)gridProds).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 
            // Grid_Cols_Config
            // 
            Id.DataPropertyName = "Id";
            Name.DataPropertyName = "Name";
            Category.DataPropertyName = "Category";
            Value.DataPropertyName = "Value";
            Value.DefaultCellStyle.Format = "C2";
            Amount.DataPropertyName = "Amount";
            totalProd.DataPropertyName = "TotalValue";
            totalProd.DefaultCellStyle.Format = "C2";
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtFilter;
        private TextBox txtCategory;
        private Button btnFilter;
        private DataGridView gridProds;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn totalProd;
    }
}