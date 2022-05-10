namespace Seguradora
{
    public partial class frm_CadCliente : Form
    {
        private object txtCep;

        public frm_CadCliente()
        {
            InitializeComponent();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Recuperar_Informacao_Tela();
            //validar cliente
            bool v = validar_cliente(cliente);
            if (v)
            {
                //verdadeiro vai salvar
                //chamar o metodo de salvar
            }
            else
            {
                //nao salvar e mandar mensagem
            }

        }
        private Cliente Recuperar_Informacao_Tela()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCPF.Text;
            cliente.Sexo = cbcSexo.Text;
            cliente.Telefonefixo = txtTelFixo.Text;
            cliente.Telefonecelular = txtTelCelular.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numerocasa = txtNEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Cep = txtCEP.Text;


            return cliente;
        }
        private bool validar_cliente(Cliente cliente)
        {
            if (cliente.Nome.Equals(""))
            {
                MessageBox.Show("O campo nome est� em branco !!","ALERTA !!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            if (cliente.Cpf.Equals(""))
            {
                MessageBox.Show("O campo CPF est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                return false;
            }
            if (cliente.Sexo.Equals(""))
            {
                MessageBox.Show("O campo sexo est� em braco !! \nEscolha uma op��o !!","ALERTA !!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbcSexo.Focus();
                return false;
            }
            if (cliente.Telefonecelular.Equals(""))

            {
                MessageBox.Show("O campo Celular est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelCelular.Focus();
                return false;            
            }
            if (cliente.Endereco.Equals(""))
            {
                MessageBox.Show("O campo Endere�o est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }

            if (cliente.Numerocasa.Equals(""))

            {
                MessageBox.Show("O campo Numero da Casa est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNEndereco.Focus();
                return false;
            }

            if(cliente.Bairro.Equals(""))
            
            {
                MessageBox.Show("O campo Bairro est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if(cliente.Cidade.Equals(""))

            {
                MessageBox.Show("O campo Cidade est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCidade.Focus();
                return false;
            }

            if(cliente.Cep.Equals(""))

            {
                MessageBox.Show("O campo CEP est� em branco !!", "ALERTA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCEP.Focus();
                return false;
            }

            return true;
        }
        private void salvar_cliente(Cliente cliente)
        {
            
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}