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
            label1.Location = new Point(341, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 60);
            label1.TabIndex = 26;
            label1.Text = "Listar Produtos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 35;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 34;
            label2.Text = "Produto:";
            // 
            // txtNomeProdutoListarProdutos
            // 
            txtNomeProdutoListarProdutos.Location = new Point(150, 138);
            txtNomeProdutoListarProdutos.Margin = new Padding(4, 5, 4, 5);
            txtNomeProdutoListarProdutos.Name = "txtNomeProdutoListarProdutos";
            txtNomeProdutoListarProdutos.Size = new Size(838, 31);
            txtNomeProdutoListarProdutos.TabIndex = 33;
            // 
            // txtCategoriaProdutoListarProdutos
            // 
            txtCategoriaProdutoListarProdutos.Location = new Point(150, 230);
            txtCategoriaProdutoListarProdutos.Margin = new Padding(4, 5, 4, 5);
            txtCategoriaProdutoListarProdutos.Name = "txtCategoriaProdutoListarProdutos";
            txtCategoriaProdutoListarProdutos.Size = new Size(838, 31);
            txtCategoriaProdutoListarProdutos.TabIndex = 32;
            // 
            // btFiltrarListarProdutos
            // 
            btFiltrarListarProdutos.Location = new Point(452, 271);
            btFiltrarListarProdutos.Margin = new Padding(4, 5, 4, 5);
            btFiltrarListarProdutos.Name = "btFiltrarListarProdutos";
            btFiltrarListarProdutos.Size = new Size(227, 57);
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
            dtListarProdutos.Location = new Point(139, 338);
            dtListarProdutos.Margin = new Padding(4, 5, 4, 5);
            dtListarProdutos.Name = "dtListarProdutos";
            dtListarProdutos.RowHeadersVisible = false;
            dtListarProdutos.RowHeadersWidth = 62;
            dtListarProdutos.Size = new Size(861, 398);
            dtListarProdutos.TabIndex = 37;
            // 
            // dtIdProdutoListarProdutos
            // 
            dtIdProdutoListarProdutos.HeaderText = "Id";
            dtIdProdutoListarProdutos.MinimumWidth = 8;
            dtIdProdutoListarProdutos.Name = "dtIdProdutoListarProdutos";
            dtIdProdutoListarProdutos.Width = 150;
            // 
            // dtNomeProdutoListarProdutos
            // 
            dtNomeProdutoListarProdutos.HeaderText = "Produto";
            dtNomeProdutoListarProdutos.MinimumWidth = 8;
            dtNomeProdutoListarProdutos.Name = "dtNomeProdutoListarProdutos";
            dtNomeProdutoListarProdutos.Width = 150;
            // 
            // dtCategoriaListarProdutos
            // 
            dtCategoriaListarProdutos.HeaderText = "Categoria";
            dtCategoriaListarProdutos.MinimumWidth = 8;
            dtCategoriaListarProdutos.Name = "dtCategoriaListarProdutos";
            dtCategoriaListarProdutos.Width = 150;
            // 
            // dtValorUnitarioProdutoListarProdutos
            // 
            dtValorUnitarioProdutoListarProdutos.HeaderText = "Valor Unitário";
            dtValorUnitarioProdutoListarProdutos.MinimumWidth = 8;
            dtValorUnitarioProdutoListarProdutos.Name = "dtValorUnitarioProdutoListarProdutos";
            dtValorUnitarioProdutoListarProdutos.Width = 150;
            // 
            // dtQuantidadeEstoqueListarProdutos
            // 
            dtQuantidadeEstoqueListarProdutos.HeaderText = "Quantidade em Estoque";
            dtQuantidadeEstoqueListarProdutos.MinimumWidth = 8;
            dtQuantidadeEstoqueListarProdutos.Name = "dtQuantidadeEstoqueListarProdutos";
            dtQuantidadeEstoqueListarProdutos.Width = 150;
            // 
            // dtTotalListarProdutos
            // 
            dtTotalListarProdutos.HeaderText = "Total";
            dtTotalListarProdutos.MinimumWidth = 8;
            dtTotalListarProdutos.Name = "dtTotalListarProdutos";
            dtTotalListarProdutos.Width = 150;
            // 
            // Listar_Produto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dtListarProdutos);
            Controls.Add(btFiltrarListarProdutos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeProdutoListarProdutos);
            Controls.Add(txtCategoriaProdutoListarProdutos);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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