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
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btCancelarCadastroProdutos = new Button();
            btSalvarVenda = new Button();
            btAddProdutoRegistrarVendas = new Button();
            dataGridView1 = new DataGridView();
            dtCodigoVendaRegistrarVenda = new DataGridViewTextBoxColumn();
            dtCpfClienteRegistrarVenda = new DataGridViewTextBoxColumn();
            dtNomeProdutoRegistrarVenda = new DataGridViewTextBoxColumn();
            dtCategoriaProdutoRegistrarVenda = new DataGridViewTextBoxColumn();
            dtValorUnitarioProdutoRegistrarVenda = new DataGridViewTextBoxColumn();
            dtQuantidadeProdutoRegistrarVenda = new DataGridViewTextBoxColumn();
            dtTotalRegistrarVenda = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbSelecionarClienteRegistrarVenda = new ComboBox();
            cbSelecionarProdutoRegistrarProduto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 53);
            label1.TabIndex = 0;
            label1.Text = "Registrar vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 204);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(426, 31);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(603, 204);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(426, 31);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(107, 265);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(426, 31);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(603, 265);
            textBox6.Margin = new Padding(4, 5, 4, 5);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(426, 31);
            textBox6.TabIndex = 6;
            // 
            // btCancelarCadastroProdutos
            // 
            btCancelarCadastroProdutos.Location = new Point(590, 679);
            btCancelarCadastroProdutos.Margin = new Padding(4, 5, 4, 5);
            btCancelarCadastroProdutos.Name = "btCancelarCadastroProdutos";
            btCancelarCadastroProdutos.Size = new Size(227, 57);
            btCancelarCadastroProdutos.TabIndex = 15;
            btCancelarCadastroProdutos.Text = "CANCELAR VENDA";
            btCancelarCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // btSalvarVenda
            // 
            btSalvarVenda.Location = new Point(299, 679);
            btSalvarVenda.Margin = new Padding(4, 5, 4, 5);
            btSalvarVenda.Name = "btSalvarVenda";
            btSalvarVenda.Size = new Size(227, 57);
            btSalvarVenda.TabIndex = 14;
            btSalvarVenda.Text = "SALVAR VENDA";
            btSalvarVenda.UseVisualStyleBackColor = true;
            // 
            // btAddProdutoRegistrarVendas
            // 
            btAddProdutoRegistrarVendas.Location = new Point(510, 322);
            btAddProdutoRegistrarVendas.Margin = new Padding(4, 5, 4, 5);
            btAddProdutoRegistrarVendas.Name = "btAddProdutoRegistrarVendas";
            btAddProdutoRegistrarVendas.Size = new Size(116, 48);
            btAddProdutoRegistrarVendas.TabIndex = 16;
            btAddProdutoRegistrarVendas.Text = "ADD(+)";
            btAddProdutoRegistrarVendas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dtCodigoVendaRegistrarVenda, dtCpfClienteRegistrarVenda, dtNomeProdutoRegistrarVenda, dtCategoriaProdutoRegistrarVenda, dtValorUnitarioProdutoRegistrarVenda, dtQuantidadeProdutoRegistrarVenda, dtTotalRegistrarVenda });
            dataGridView1.Location = new Point(61, 380);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1004, 289);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtCodigoVendaRegistrarVenda
            // 
            dtCodigoVendaRegistrarVenda.HeaderText = "Codigo Venda";
            dtCodigoVendaRegistrarVenda.MinimumWidth = 8;
            dtCodigoVendaRegistrarVenda.Name = "dtCodigoVendaRegistrarVenda";
            dtCodigoVendaRegistrarVenda.Width = 150;
            // 
            // dtCpfClienteRegistrarVenda
            // 
            dtCpfClienteRegistrarVenda.HeaderText = "Cpf - Cliente";
            dtCpfClienteRegistrarVenda.MinimumWidth = 8;
            dtCpfClienteRegistrarVenda.Name = "dtCpfClienteRegistrarVenda";
            dtCpfClienteRegistrarVenda.Width = 150;
            // 
            // dtNomeProdutoRegistrarVenda
            // 
            dtNomeProdutoRegistrarVenda.HeaderText = "Produto";
            dtNomeProdutoRegistrarVenda.MinimumWidth = 8;
            dtNomeProdutoRegistrarVenda.Name = "dtNomeProdutoRegistrarVenda";
            dtNomeProdutoRegistrarVenda.Width = 150;
            // 
            // dtCategoriaProdutoRegistrarVenda
            // 
            dtCategoriaProdutoRegistrarVenda.HeaderText = "Categoria";
            dtCategoriaProdutoRegistrarVenda.MinimumWidth = 8;
            dtCategoriaProdutoRegistrarVenda.Name = "dtCategoriaProdutoRegistrarVenda";
            dtCategoriaProdutoRegistrarVenda.Width = 150;
            // 
            // dtValorUnitarioProdutoRegistrarVenda
            // 
            dtValorUnitarioProdutoRegistrarVenda.HeaderText = "Valor Unitário";
            dtValorUnitarioProdutoRegistrarVenda.MinimumWidth = 8;
            dtValorUnitarioProdutoRegistrarVenda.Name = "dtValorUnitarioProdutoRegistrarVenda";
            dtValorUnitarioProdutoRegistrarVenda.Width = 150;
            // 
            // dtQuantidadeProdutoRegistrarVenda
            // 
            dtQuantidadeProdutoRegistrarVenda.HeaderText = "Quantidade";
            dtQuantidadeProdutoRegistrarVenda.MinimumWidth = 8;
            dtQuantidadeProdutoRegistrarVenda.Name = "dtQuantidadeProdutoRegistrarVenda";
            dtQuantidadeProdutoRegistrarVenda.Width = 150;
            // 
            // dtTotalRegistrarVenda
            // 
            dtTotalRegistrarVenda.HeaderText = "Total";
            dtTotalRegistrarVenda.MinimumWidth = 8;
            dtTotalRegistrarVenda.Name = "dtTotalRegistrarVenda";
            dtTotalRegistrarVenda.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 18;
            label2.Text = "Selecionar Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 19;
            label3.Text = "Selecionar Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 174);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 20;
            label4.Text = "Nome do Produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 174);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 21;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 240);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 22;
            label6.Text = "Valor unitário:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(599, 240);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(237, 25);
            label7.TabIndex = 23;
            label7.Text = "Quantidade a ser comprada:";
            // 
            // cbSelecionarClienteRegistrarVenda
            // 
            cbSelecionarClienteRegistrarVenda.FormattingEnabled = true;
            cbSelecionarClienteRegistrarVenda.Location = new Point(156, 67);
            cbSelecionarClienteRegistrarVenda.Margin = new Padding(4, 5, 4, 5);
            cbSelecionarClienteRegistrarVenda.Name = "cbSelecionarClienteRegistrarVenda";
            cbSelecionarClienteRegistrarVenda.Size = new Size(794, 33);
            cbSelecionarClienteRegistrarVenda.TabIndex = 24;
            // 
            // cbSelecionarProdutoRegistrarProduto
            // 
            cbSelecionarProdutoRegistrarProduto.FormattingEnabled = true;
            cbSelecionarProdutoRegistrarProduto.Location = new Point(156, 136);
            cbSelecionarProdutoRegistrarProduto.Margin = new Padding(4, 5, 4, 5);
            cbSelecionarProdutoRegistrarProduto.Name = "cbSelecionarProdutoRegistrarProduto";
            cbSelecionarProdutoRegistrarProduto.Size = new Size(794, 33);
            cbSelecionarProdutoRegistrarProduto.TabIndex = 25;
            // 
            // Registrar_Venda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(cbSelecionarProdutoRegistrarProduto);
            Controls.Add(cbSelecionarClienteRegistrarVenda);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btAddProdutoRegistrarVendas);
            Controls.Add(btCancelarCadastroProdutos);
            Controls.Add(btSalvarVenda);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registrar_Venda";
            Text = "Registrar_Venda";
            Load += Registrar_Venda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btCancelarCadastroProdutos;
        private Button btSalvarVenda;
        private Button btAddProdutoRegistrarVendas;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbSelecionarClienteRegistrarVenda;
        private ComboBox cbSelecionarProdutoRegistrarProduto;
        private DataGridViewTextBoxColumn dtCodigoVendaRegistrarVenda;
        private DataGridViewTextBoxColumn dtCpfClienteRegistrarVenda;
        private DataGridViewTextBoxColumn dtNomeProdutoRegistrarVenda;
        private DataGridViewTextBoxColumn dtCategoriaProdutoRegistrarVenda;
        private DataGridViewTextBoxColumn dtValorUnitarioProdutoRegistrarVenda;
        private DataGridViewTextBoxColumn dtQuantidadeProdutoRegistrarVenda;
        private DataGridViewTextBoxColumn dtTotalRegistrarVenda;
    }
}