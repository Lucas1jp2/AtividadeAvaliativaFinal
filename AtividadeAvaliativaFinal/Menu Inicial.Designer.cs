namespace AtividadeAvaliativaFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btCadastrarProdutos = new Button();
            btRegistrarVenda = new Button();
            btListarProdutos = new Button();
            btCadastrarCliente = new Button();
            btConsultarCliente = new Button();
            btListarVendas = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btCadastrarProdutos
            // 
            btCadastrarProdutos.Location = new Point(137, 42);
            btCadastrarProdutos.Name = "btCadastrarProdutos";
            btCadastrarProdutos.Size = new Size(146, 86);
            btCadastrarProdutos.TabIndex = 0;
            btCadastrarProdutos.Text = "Cadastrar Produto";
            btCadastrarProdutos.UseVisualStyleBackColor = true;
            btCadastrarProdutos.Click += btCadastrarProdutos_Click;
            // 
            // btRegistrarVenda
            // 
            btRegistrarVenda.Location = new Point(137, 154);
            btRegistrarVenda.Name = "btRegistrarVenda";
            btRegistrarVenda.Size = new Size(146, 86);
            btRegistrarVenda.TabIndex = 1;
            btRegistrarVenda.Text = "Registrar Venda";
            btRegistrarVenda.UseVisualStyleBackColor = true;
            btRegistrarVenda.Click += btRegistrarVenda_Click;
            // 
            // btListarProdutos
            // 
            btListarProdutos.Location = new Point(137, 265);
            btListarProdutos.Name = "btListarProdutos";
            btListarProdutos.Size = new Size(146, 86);
            btListarProdutos.TabIndex = 2;
            btListarProdutos.Text = "Listar Produtos";
            btListarProdutos.UseVisualStyleBackColor = true;
            // 
            // btCadastrarCliente
            // 
            btCadastrarCliente.Location = new Point(516, 42);
            btCadastrarCliente.Name = "btCadastrarCliente";
            btCadastrarCliente.Size = new Size(146, 86);
            btCadastrarCliente.TabIndex = 3;
            btCadastrarCliente.Text = "Cadastrar Cliente";
            btCadastrarCliente.UseVisualStyleBackColor = true;
            btCadastrarCliente.Click += btCadastrarCliente_Click;
            // 
            // btConsultarCliente
            // 
            btConsultarCliente.Location = new Point(516, 154);
            btConsultarCliente.Name = "btConsultarCliente";
            btConsultarCliente.Size = new Size(146, 86);
            btConsultarCliente.TabIndex = 4;
            btConsultarCliente.Text = "Consultar Cliente";
            btConsultarCliente.UseVisualStyleBackColor = true;
            // 
            // btListarVendas
            // 
            btListarVendas.Location = new Point(516, 265);
            btListarVendas.Name = "btListarVendas";
            btListarVendas.Size = new Size(146, 86);
            btListarVendas.TabIndex = 5;
            btListarVendas.Text = "Listar Vendas";
            btListarVendas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 369);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 6;
            label1.Text = "Gabriel Guedes Alves de Moura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 384);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 7;
            label2.Text = "Lucas José Pereira";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btListarVendas);
            Controls.Add(btConsultarCliente);
            Controls.Add(btCadastrarCliente);
            Controls.Add(btListarProdutos);
            Controls.Add(btRegistrarVenda);
            Controls.Add(btCadastrarProdutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCadastrarProdutos;
        private Button btRegistrarVenda;
        private Button btListarProdutos;
        private Button btCadastrarCliente;
        private Button btConsultarCliente;
        private Button btListarVendas;
        private Label label1;
        private Label label2;
    }
}
