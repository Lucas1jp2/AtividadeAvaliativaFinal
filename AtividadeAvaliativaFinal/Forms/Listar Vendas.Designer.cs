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
            btFiltrarListarVendas = new Button();
            label3 = new Label();
            label2 = new Label();
            txtCpfClienteListarVendas = new TextBox();
            txtCodigoVendaListarVendas = new TextBox();
            label1 = new Label();
            dtCodigoVendaListarVendas = new DataGridViewTextBoxColumn();
            dtCpfClienteListarVendas = new DataGridViewTextBoxColumn();
            dtProdutoListarVendas = new DataGridViewTextBoxColumn();
            dtCategoriaListarVendas = new DataGridViewTextBoxColumn();
            dtValorUnitarioListarVendas = new DataGridViewTextBoxColumn();
            dtQuantidadeListarVendas = new DataGridViewTextBoxColumn();
            dtTotalListarVendas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtListarVendas).BeginInit();
            SuspendLayout();
            // 
            // dtListarVendas
            // 
            dtListarVendas.AllowUserToAddRows = false;
            dtListarVendas.AllowUserToOrderColumns = true;
            dtListarVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListarVendas.Columns.AddRange(new DataGridViewColumn[] { dtCodigoVendaListarVendas, dtCpfClienteListarVendas, dtProdutoListarVendas, dtCategoriaListarVendas, dtValorUnitarioListarVendas, dtQuantidadeListarVendas, dtTotalListarVendas });
            dtListarVendas.Location = new Point(65, 256);
            dtListarVendas.Name = "dtListarVendas";
            dtListarVendas.RowHeadersVisible = false;
            dtListarVendas.Size = new Size(703, 66);
            dtListarVendas.TabIndex = 44;
            // 
            // btFiltrarListarVendas
            // 
            btFiltrarListarVendas.Location = new Point(314, 191);
            btFiltrarListarVendas.Name = "btFiltrarListarVendas";
            btFiltrarListarVendas.Size = new Size(159, 34);
            btFiltrarListarVendas.TabIndex = 43;
            btFiltrarListarVendas.Text = "FILTRAR";
            btFiltrarListarVendas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 120);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 42;
            label3.Text = "Código da Venda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 65);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 41;
            label2.Text = "Cpf do Cliente:";
            // 
            // txtCpfClienteListarVendas
            // 
            txtCpfClienteListarVendas.Location = new Point(106, 83);
            txtCpfClienteListarVendas.Name = "txtCpfClienteListarVendas";
            txtCpfClienteListarVendas.Size = new Size(588, 23);
            txtCpfClienteListarVendas.TabIndex = 40;
            // 
            // txtCodigoVendaListarVendas
            // 
            txtCodigoVendaListarVendas.Location = new Point(106, 138);
            txtCodigoVendaListarVendas.Name = "txtCodigoVendaListarVendas";
            txtCodigoVendaListarVendas.Size = new Size(588, 23);
            txtCodigoVendaListarVendas.TabIndex = 39;
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
            // dtCodigoVendaListarVendas
            // 
            dtCodigoVendaListarVendas.HeaderText = "Id";
            dtCodigoVendaListarVendas.Name = "dtCodigoVendaListarVendas";
            // 
            // dtCpfClienteListarVendas
            // 
            dtCpfClienteListarVendas.HeaderText = "Cpf - Cliente";
            dtCpfClienteListarVendas.Name = "dtCpfClienteListarVendas";
            // 
            // dtProdutoListarVendas
            // 
            dtProdutoListarVendas.HeaderText = "Produto";
            dtProdutoListarVendas.Name = "dtProdutoListarVendas";
            // 
            // dtCategoriaListarVendas
            // 
            dtCategoriaListarVendas.HeaderText = "Categoria";
            dtCategoriaListarVendas.Name = "dtCategoriaListarVendas";
            // 
            // dtValorUnitarioListarVendas
            // 
            dtValorUnitarioListarVendas.HeaderText = "Valor Unitario";
            dtValorUnitarioListarVendas.Name = "dtValorUnitarioListarVendas";
            // 
            // dtQuantidadeListarVendas
            // 
            dtQuantidadeListarVendas.HeaderText = "Quantidade";
            dtQuantidadeListarVendas.Name = "dtQuantidadeListarVendas";
            // 
            // dtTotalListarVendas
            // 
            dtTotalListarVendas.HeaderText = "Total";
            dtTotalListarVendas.Name = "dtTotalListarVendas";
            // 
            // Listar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtListarVendas);
            Controls.Add(btFiltrarListarVendas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCpfClienteListarVendas);
            Controls.Add(txtCodigoVendaListarVendas);
            Controls.Add(label1);
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