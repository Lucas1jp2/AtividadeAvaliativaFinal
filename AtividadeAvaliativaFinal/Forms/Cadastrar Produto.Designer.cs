namespace AtividadeAvaliativaFinal.Forms
{
    partial class Cadastrar_Produto
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
            txtQtdEstoqueProduto = new TextBox();
            txtValorUnitProtudo = new TextBox();
            txtNomeProduto = new TextBox();
            txtCategoriaProduto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btCadastrarProdutos = new Button();
            btCancelarCadastroProdutos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 36);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Produtos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQtdEstoqueProduto
            // 
            txtQtdEstoqueProduto.Location = new Point(90, 314);
            txtQtdEstoqueProduto.Name = "txtQtdEstoqueProduto";
            txtQtdEstoqueProduto.Size = new Size(588, 23);
            txtQtdEstoqueProduto.TabIndex = 4;
            // 
            // txtValorUnitProtudo
            // 
            txtValorUnitProtudo.Location = new Point(90, 250);
            txtValorUnitProtudo.Name = "txtValorUnitProtudo";
            txtValorUnitProtudo.Size = new Size(588, 23);
            txtValorUnitProtudo.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(90, 130);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(588, 23);
            txtNomeProduto.TabIndex = 7;
            // 
            // txtCategoriaProduto
            // 
            txtCategoriaProduto.Location = new Point(90, 185);
            txtCategoriaProduto.Name = "txtCategoriaProduto";
            txtCategoriaProduto.Size = new Size(588, 23);
            txtCategoriaProduto.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 112);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome do protudo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 167);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 232);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 10;
            label4.Text = "Valor unitário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 296);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 11;
            label5.Text = "Quantidade em Estoque:";
            // 
            // btCadastrarProdutos
            // 
            btCadastrarProdutos.Location = new Point(168, 370);
            btCadastrarProdutos.Name = "btCadastrarProdutos";
            btCadastrarProdutos.Size = new Size(159, 34);
            btCadastrarProdutos.TabIndex = 12;
            btCadastrarProdutos.Text = "Cadastrar";
            btCadastrarProdutos.UseVisualStyleBackColor = true;
            // 
            // btCancelarCadastroProdutos
            // 
            btCancelarCadastroProdutos.Location = new Point(372, 370);
            btCancelarCadastroProdutos.Name = "btCancelarCadastroProdutos";
            btCancelarCadastroProdutos.Size = new Size(159, 34);
            btCancelarCadastroProdutos.TabIndex = 13;
            btCancelarCadastroProdutos.Text = "Cancelar";
            btCancelarCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // Cadastrar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancelarCadastroProdutos);
            Controls.Add(btCadastrarProdutos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCategoriaProduto);
            Controls.Add(txtValorUnitProtudo);
            Controls.Add(txtQtdEstoqueProduto);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowText;
            Name = "Cadastrar_Produto";
            Text = "Cadastrar_Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtQtdEstoqueProduto;
        private TextBox txtValorUnitProtudo;
        private TextBox txtNomeProduto;
        private TextBox txtCategoriaProduto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btCadastrarProdutos;
        private Button btCancelarCadastroProdutos;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}