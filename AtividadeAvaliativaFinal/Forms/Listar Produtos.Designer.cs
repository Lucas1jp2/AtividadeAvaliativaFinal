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
            txtNomeProdutoListarProdutos = new TextBox();
            txtCategoriaProdutoListarProdutos = new TextBox();
            btFiltrarListarProdutos = new Button();
            dtListarProdutos = new DataGridView();
            dtIdProdutoListarProdutos = new DataGridViewTextBoxColumn();
            dtNomeProdutoListarProdutos = new DataGridViewTextBoxColumn();
            dtCategoriaListarProdutos = new DataGridViewTextBoxColumn();
            dtValorUnitarioProdutoListarProdutos = new DataGridViewTextBoxColumn();
            dtQuantidadeEstoqueListarProdutos = new DataGridViewTextBoxColumn();
            dtTotalListarProdutos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtListarProdutos).BeginInit();
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
            // txtNomeProdutoListarProdutos
            // 
            txtNomeProdutoListarProdutos.Location = new Point(105, 83);
            txtNomeProdutoListarProdutos.Name = "txtNomeProdutoListarProdutos";
            txtNomeProdutoListarProdutos.Size = new Size(588, 23);
            txtNomeProdutoListarProdutos.TabIndex = 33;
            // 
            // txtCategoriaProdutoListarProdutos
            // 
            txtCategoriaProdutoListarProdutos.Location = new Point(105, 138);
            txtCategoriaProdutoListarProdutos.Name = "txtCategoriaProdutoListarProdutos";
            txtCategoriaProdutoListarProdutos.Size = new Size(588, 23);
            txtCategoriaProdutoListarProdutos.TabIndex = 32;
            // 
            // btFiltrarListarProdutos
            // 
            btFiltrarListarProdutos.Location = new Point(313, 191);
            btFiltrarListarProdutos.Name = "btFiltrarListarProdutos";
            btFiltrarListarProdutos.Size = new Size(159, 34);
            btFiltrarListarProdutos.TabIndex = 36;
            btFiltrarListarProdutos.Text = "FILTRAR";
            btFiltrarListarProdutos.UseVisualStyleBackColor = true;
            // 
            // dtListarProdutos
            // 
            dtListarProdutos.AllowUserToAddRows = false;
            dtListarProdutos.AllowUserToOrderColumns = true;
            dtListarProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListarProdutos.Columns.AddRange(new DataGridViewColumn[] { dtIdProdutoListarProdutos, dtNomeProdutoListarProdutos, dtCategoriaListarProdutos, dtValorUnitarioProdutoListarProdutos, dtQuantidadeEstoqueListarProdutos, dtTotalListarProdutos });
            dtListarProdutos.Location = new Point(105, 254);
            dtListarProdutos.Name = "dtListarProdutos";
            dtListarProdutos.RowHeadersVisible = false;
            dtListarProdutos.Size = new Size(603, 65);
            dtListarProdutos.TabIndex = 37;
            // 
            // dtIdProdutoListarProdutos
            // 
            dtIdProdutoListarProdutos.HeaderText = "Id";
            dtIdProdutoListarProdutos.Name = "dtIdProdutoListarProdutos";
            // 
            // dtNomeProdutoListarProdutos
            // 
            dtNomeProdutoListarProdutos.HeaderText = "Produto";
            dtNomeProdutoListarProdutos.Name = "dtNomeProdutoListarProdutos";
            // 
            // dtCategoriaListarProdutos
            // 
            dtCategoriaListarProdutos.HeaderText = "Categoria";
            dtCategoriaListarProdutos.Name = "dtCategoriaListarProdutos";
            // 
            // dtValorUnitarioProdutoListarProdutos
            // 
            dtValorUnitarioProdutoListarProdutos.HeaderText = "Valor Unitário";
            dtValorUnitarioProdutoListarProdutos.Name = "dtValorUnitarioProdutoListarProdutos";
            // 
            // dtQuantidadeEstoqueListarProdutos
            // 
            dtQuantidadeEstoqueListarProdutos.HeaderText = "Quantidade em Estoque";
            dtQuantidadeEstoqueListarProdutos.Name = "dtQuantidadeEstoqueListarProdutos";
            // 
            // dtTotalListarProdutos
            // 
            dtTotalListarProdutos.HeaderText = "Total";
            dtTotalListarProdutos.Name = "dtTotalListarProdutos";
            // 
            // Listar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtListarProdutos);
            Controls.Add(btFiltrarListarProdutos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeProdutoListarProdutos);
            Controls.Add(txtCategoriaProdutoListarProdutos);
            Controls.Add(label1);
            Name = "Listar_Produto";
            Text = "Listar_Produto";
            ((System.ComponentModel.ISupportInitialize)dtListarProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtNomeProdutoListarProdutos;
        private TextBox txtCategoriaProdutoListarProdutos;
        private Button btFiltrarListarProdutos;
        private DataGridView dtListarProdutos;
        private DataGridViewTextBoxColumn dtIdProdutoListarProdutos;
        private DataGridViewTextBoxColumn dtNomeProdutoListarProdutos;
        private DataGridViewTextBoxColumn dtCategoriaListarProdutos;
        private DataGridViewTextBoxColumn dtValorUnitarioProdutoListarProdutos;
        private DataGridViewTextBoxColumn dtQuantidadeEstoqueListarProdutos;
        private DataGridViewTextBoxColumn dtTotalListarProdutos;
    }
}