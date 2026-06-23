namespace AtividadeAvaliativaFinal.Forms
{
    partial class Listar_Venda
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
            btnFilter = new Button();
            label3 = new Label();
            label2 = new Label();
            txtCpf = new TextBox();
            txtSellCode = new TextBox();
            label1 = new Label();
            gridSales = new DataGridView();
            gridId = new DataGridViewTextBoxColumn();
            gridCpf = new DataGridViewTextBoxColumn();
            gridProd = new DataGridViewTextBoxColumn();
            gridCategory = new DataGridViewTextBoxColumn();
            gridValue = new DataGridViewTextBoxColumn();
            gridAmount = new DataGridViewTextBoxColumn();
            gridTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridSales).BeginInit();
            SuspendLayout();
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(321, 148);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(159, 34);
            btnFilter.TabIndex = 43;
            btnFilter.Text = "FILTRAR";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 98);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 42;
            label3.Text = "Código da Venda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 43);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 41;
            label2.Text = "Cpf do Cliente:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(56, 61);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(703, 23);
            txtCpf.TabIndex = 40;
            // 
            // txtSellCode
            // 
            txtSellCode.Location = new Point(56, 116);
            txtSellCode.Name = "txtSellCode";
            txtSellCode.Size = new Size(703, 23);
            txtSellCode.TabIndex = 39;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 38;
            label1.Text = "Listar Vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridSales
            // 
            gridSales.AllowUserToAddRows = false;
            gridSales.AllowUserToOrderColumns = true;
            gridSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSales.Columns.AddRange(new DataGridViewColumn[] { gridId, gridCpf, gridProd, gridCategory, gridValue, gridAmount, gridTotal });
            gridSales.Location = new Point(56, 191);
            gridSales.Name = "gridSales";
            gridSales.RowHeadersVisible = false;
            gridSales.RowHeadersWidth = 62;
            gridSales.Size = new Size(703, 233);
            gridSales.TabIndex = 44;
            // 
            // gridId
            // 
            gridId.HeaderText = "Codigo Venda";
            gridId.MinimumWidth = 8;
            gridId.Name = "gridId";
            gridId.Width = 150;
            // 
            // gridCpf
            // 
            gridCpf.HeaderText = "Cpf - Cliente";
            gridCpf.MinimumWidth = 8;
            gridCpf.Name = "gridCpf";
            gridCpf.Width = 150;
            // 
            // gridProd
            // 
            gridProd.HeaderText = "Produto";
            gridProd.MinimumWidth = 8;
            gridProd.Name = "gridProd";
            gridProd.Width = 150;
            // 
            // gridCategory
            // 
            gridCategory.HeaderText = "Categoria";
            gridCategory.MinimumWidth = 8;
            gridCategory.Name = "gridCategory";
            gridCategory.Width = 150;
            // 
            // gridValue
            // 
            gridValue.HeaderText = "Valor Unitário";
            gridValue.MinimumWidth = 8;
            gridValue.Name = "gridValue";
            gridValue.Width = 150;
            // 
            // gridAmount
            // 
            gridAmount.HeaderText = "Quantidade";
            gridAmount.MinimumWidth = 8;
            gridAmount.Name = "gridAmount";
            gridAmount.Width = 150;
            // 
            // gridTotal
            // 
            gridTotal.HeaderText = "Total";
            gridTotal.MinimumWidth = 8;
            gridTotal.Name = "gridTotal";
            gridTotal.Width = 150;
            // 
            // Listar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridSales);
            Controls.Add(btnFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCpf);
            Controls.Add(txtSellCode);
            Controls.Add(label1);
            Name = "Listar_Venda";
            Text = "Listar_Venda";
            ((System.ComponentModel.ISupportInitialize)gridSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridSells;
        private Button btnFilter;
        private Label label3;
        private Label label2;
        private TextBox txtCpf;
        private TextBox txtSellCode;
        private Label label1;
        private DataGridView gridSales;
        private DataGridViewTextBoxColumn gridId;
        private DataGridViewTextBoxColumn gridCpf;
        private DataGridViewTextBoxColumn gridProd;
        private DataGridViewTextBoxColumn gridCategory;
        private DataGridViewTextBoxColumn gridValue;
        private DataGridViewTextBoxColumn gridAmount;
        private DataGridViewTextBoxColumn gridTotal;
    }
}