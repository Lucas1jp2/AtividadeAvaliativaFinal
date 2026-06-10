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

        }

        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarVenda_Click(object sender, EventArgs e)
        {
            Form Registrar = new Forms.Registrar_Venda();
            Registrar.ShowDialog();
        }
    }
}
