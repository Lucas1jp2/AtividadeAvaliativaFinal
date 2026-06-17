namespace AtividadeAvaliativaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form CadastrarCliente = new Forms.Cadastrar_Cliente();
            CadastrarCliente.ShowDialog();
        }

        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {
            Form CadastrarProduto = new Forms.Cadastrar_Produto();
            CadastrarProduto.ShowDialog();
        }

        private void btRegistrarVenda_Click(object sender, EventArgs e)
        {
            Form Registrar = new Forms.Registrar_Venda();
            Registrar.ShowDialog();
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            Form ConsultarCliente = new Forms.Consultar_Cliente();
            ConsultarCliente.ShowDialog();
        }

        private void btListarProdutos_Click(object sender, EventArgs e)
        {
            Form ListarProdutos = new Forms.Listar_Produto();
            ListarProdutos.ShowDialog();
        }

        private void btListarVendas_Click(object sender, EventArgs e)
        {
            Form ListarVendas = new Forms.Listar_Venda();
            ListarVendas.ShowDialog();
        }
    }
}
