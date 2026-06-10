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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btCancelarCadastroProdutos = new Button();
            btSalvarVenda = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dtCodigoVenda = new DataGridViewTextBoxColumn();
            dtCpfCliente = new DataGridViewTextBoxColumn();
            dtNomeProduto = new DataGridViewTextBoxColumn();
            dtCategoriaProduto = new DataGridViewTextBoxColumn();
            dtValorUnitarioProduto = new DataGridViewTextBoxColumn();
            dtQuantidadeProduto = new DataGridViewTextBoxColumn();
            dtTotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "Registrar vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(464, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(434, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(434, 210);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(234, 23);
            textBox6.TabIndex = 6;
            // 
            // btCancelarCadastroProdutos
            // 
            btCancelarCadastroProdutos.Location = new Point(406, 381);
            btCancelarCadastroProdutos.Name = "btCancelarCadastroProdutos";
            btCancelarCadastroProdutos.Size = new Size(159, 34);
            btCancelarCadastroProdutos.TabIndex = 15;
            btCancelarCadastroProdutos.Text = "CANCELAR VENDA";
            btCancelarCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // btSalvarVenda
            // 
            btSalvarVenda.Location = new Point(202, 381);
            btSalvarVenda.Name = "btSalvarVenda";
            btSalvarVenda.Size = new Size(159, 34);
            btSalvarVenda.TabIndex = 14;
            btSalvarVenda.Text = "SALVAR VENDA";
            btSalvarVenda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(346, 234);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 16;
            button1.Text = "ADD(+)";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dtCodigoVenda, dtCpfCliente, dtNomeProduto, dtCategoriaProduto, dtValorUnitarioProduto, dtQuantidadeProduto, dtTotal });
            dataGridView1.Location = new Point(40, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(701, 91);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dtCodigoVenda
            // 
            dtCodigoVenda.HeaderText = "Codigo Venda";
            dtCodigoVenda.Name = "dtCodigoVenda";
            // 
            // dtCpfCliente
            // 
            dtCpfCliente.HeaderText = "Cpf - Cliente";
            dtCpfCliente.Name = "dtCpfCliente";
            // 
            // dtNomeProduto
            // 
            dtNomeProduto.HeaderText = "Produto";
            dtNomeProduto.Name = "dtNomeProduto";
            // 
            // dtCategoriaProduto
            // 
            dtCategoriaProduto.HeaderText = "Categoria";
            dtCategoriaProduto.Name = "dtCategoriaProduto";
            // 
            // dtValorUnitarioProduto
            // 
            dtValorUnitarioProduto.HeaderText = "Valor Unitário";
            dtValorUnitarioProduto.Name = "dtValorUnitarioProduto";
            // 
            // dtQuantidadeProduto
            // 
            dtQuantidadeProduto.HeaderText = "Quantidade";
            dtQuantidadeProduto.Name = "dtQuantidadeProduto";
            // 
            // dtTotal
            // 
            dtTotal.HeaderText = "Total";
            dtTotal.Name = "dtTotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 34);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 18;
            label2.Text = "Selecionar Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 81);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 19;
            label3.Text = "Selecionar Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 133);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 20;
            label4.Text = "Nome do Produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 133);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 21;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 195);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 22;
            label6.Text = "Valor unitário:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 195);
            label7.Name = "label7";
            label7.Size = new Size(156, 15);
            label7.TabIndex = 23;
            label7.Text = "Quantidade a ser comprada:";
            // 
            // Registrar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btCancelarCadastroProdutos);
            Controls.Add(btSalvarVenda);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Registrar_Venda";
            Text = "Registrar_Venda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btCancelarCadastroProdutos;
        private Button btSalvarVenda;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dtCodigoVenda;
        private DataGridViewTextBoxColumn dtCpfCliente;
        private DataGridViewTextBoxColumn dtNomeProduto;
        private DataGridViewTextBoxColumn dtCategoriaProduto;
        private DataGridViewTextBoxColumn dtValorUnitarioProduto;
        private DataGridViewTextBoxColumn dtQuantidadeProduto;
        private DataGridViewTextBoxColumn dtTotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}