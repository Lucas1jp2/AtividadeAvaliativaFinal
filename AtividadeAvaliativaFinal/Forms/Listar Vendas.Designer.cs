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
            dtListarVendas = new DataGridView();
            dtCodigoVendaListarVendas = new DataGridViewTextBoxColumn();
            dtCpfClienteListarVendas = new DataGridViewTextBoxColumn();
            dtProdutoListarVendas = new DataGridViewTextBoxColumn();
            dtCategoriaListarVendas = new DataGridViewTextBoxColumn();
            dtValorUnitarioListarVendas = new DataGridViewTextBoxColumn();
            dtQuantidadeListarVendas = new DataGridViewTextBoxColumn();
            dtTotalListarVendas = new DataGridViewTextBoxColumn();
            btFiltrarListarVendas = new Button();
            label3 = new Label();
            label2 = new Label();
            txtCpfClienteListarVendas = new TextBox();
            txtCodigoVendaListarVendas = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtListarVendas).BeginInit();
            SuspendLayout();
            // 
            // dtListarVendas
            // 
            dtListarVendas.AllowUserToAddRows = false;
            dtListarVendas.AllowUserToOrderColumns = true;
            dtListarVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListarVendas.Columns.AddRange(new DataGridViewColumn[] { dtCodigoVendaListarVendas, dtCpfClienteListarVendas, dtProdutoListarVendas, dtCategoriaListarVendas, dtValorUnitarioListarVendas, dtQuantidadeListarVendas, dtTotalListarVendas });
            dtListarVendas.Location = new Point(66, 347);
            dtListarVendas.Margin = new Padding(4, 5, 4, 5);
            dtListarVendas.Name = "dtListarVendas";
            dtListarVendas.RowHeadersVisible = false;
            dtListarVendas.RowHeadersWidth = 62;
            dtListarVendas.Size = new Size(1004, 394);
            dtListarVendas.TabIndex = 44;
            // 
            // dtCodigoVendaListarVendas
            // 
            dtCodigoVendaListarVendas.HeaderText = "Id";
            dtCodigoVendaListarVendas.MinimumWidth = 8;
            dtCodigoVendaListarVendas.Name = "dtCodigoVendaListarVendas";
            dtCodigoVendaListarVendas.Width = 150;
            // 
            // dtCpfClienteListarVendas
            // 
            dtCpfClienteListarVendas.HeaderText = "Cpf - Cliente";
            dtCpfClienteListarVendas.MinimumWidth = 8;
            dtCpfClienteListarVendas.Name = "dtCpfClienteListarVendas";
            dtCpfClienteListarVendas.Width = 150;
            // 
            // dtProdutoListarVendas
            // 
            dtProdutoListarVendas.HeaderText = "Produto";
            dtProdutoListarVendas.MinimumWidth = 8;
            dtProdutoListarVendas.Name = "dtProdutoListarVendas";
            dtProdutoListarVendas.Width = 150;
            // 
            // dtCategoriaListarVendas
            // 
            dtCategoriaListarVendas.HeaderText = "Categoria";
            dtCategoriaListarVendas.MinimumWidth = 8;
            dtCategoriaListarVendas.Name = "dtCategoriaListarVendas";
            dtCategoriaListarVendas.Width = 150;
            // 
            // dtValorUnitarioListarVendas
            // 
            dtValorUnitarioListarVendas.HeaderText = "Valor Unitario";
            dtValorUnitarioListarVendas.MinimumWidth = 8;
            dtValorUnitarioListarVendas.Name = "dtValorUnitarioListarVendas";
            dtValorUnitarioListarVendas.Width = 150;
            // 
            // dtQuantidadeListarVendas
            // 
            dtQuantidadeListarVendas.HeaderText = "Quantidade";
            dtQuantidadeListarVendas.MinimumWidth = 8;
            dtQuantidadeListarVendas.Name = "dtQuantidadeListarVendas";
            dtQuantidadeListarVendas.Width = 150;
            // 
            // dtTotalListarVendas
            // 
            dtTotalListarVendas.HeaderText = "Total";
            dtTotalListarVendas.MinimumWidth = 8;
            dtTotalListarVendas.Name = "dtTotalListarVendas";
            dtTotalListarVendas.Width = 150;
            // 
            // btFiltrarListarVendas
            // 
            btFiltrarListarVendas.Location = new Point(458, 280);
            btFiltrarListarVendas.Margin = new Padding(4, 5, 4, 5);
            btFiltrarListarVendas.Name = "btFiltrarListarVendas";
            btFiltrarListarVendas.Size = new Size(227, 57);
            btFiltrarListarVendas.TabIndex = 43;
            btFiltrarListarVendas.Text = "FILTRAR";
            btFiltrarListarVendas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 42;
            label3.Text = "Código da Venda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 41;
            label2.Text = "Cpf do Cliente:";
            // 
            // txtCpfClienteListarVendas
            // 
            txtCpfClienteListarVendas.Location = new Point(151, 138);
            txtCpfClienteListarVendas.Margin = new Padding(4, 5, 4, 5);
            txtCpfClienteListarVendas.Name = "txtCpfClienteListarVendas";
            txtCpfClienteListarVendas.Size = new Size(838, 31);
            txtCpfClienteListarVendas.TabIndex = 40;
            // 
            // txtCodigoVendaListarVendas
            // 
            txtCodigoVendaListarVendas.Location = new Point(151, 230);
            txtCodigoVendaListarVendas.Margin = new Padding(4, 5, 4, 5);
            txtCodigoVendaListarVendas.Name = "txtCodigoVendaListarVendas";
            txtCodigoVendaListarVendas.Size = new Size(838, 31);
            txtCodigoVendaListarVendas.TabIndex = 39;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 60);
            label1.TabIndex = 38;
            label1.Text = "Listar Vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Listar_Venda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(dtListarVendas);
            Controls.Add(btFiltrarListarVendas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCpfClienteListarVendas);
            Controls.Add(txtCodigoVendaListarVendas);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Listar_Venda";
            Text = "Listar_Venda";
            ((System.ComponentModel.ISupportInitialize)dtListarVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtListarVendas;
        private Button btFiltrarListarVendas;
        private Label label3;
        private Label label2;
        private TextBox txtCpfClienteListarVendas;
        private TextBox txtCodigoVendaListarVendas;
        private Label label1;
        private DataGridViewTextBoxColumn dtCodigoVendaListarVendas;
        private DataGridViewTextBoxColumn dtCpfClienteListarVendas;
        private DataGridViewTextBoxColumn dtProdutoListarVendas;
        private DataGridViewTextBoxColumn dtCategoriaListarVendas;
        private DataGridViewTextBoxColumn dtValorUnitarioListarVendas;
        private DataGridViewTextBoxColumn dtQuantidadeListarVendas;
        private DataGridViewTextBoxColumn dtTotalListarVendas;
    }
}