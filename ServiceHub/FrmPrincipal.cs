namespace ServiceHub
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar uma instância do formulário Listar Clientes
            FrmListaClientes listaClientes = new();

            //associando o form listar clientes como filho do principal
            listaClientes.MdiParent = this;

            // chamar o form de clientes
            listaClientes.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente novoCliente = new();
            novoCliente.MdiParent = this;
            novoCliente.Show();
        }
    }
}
