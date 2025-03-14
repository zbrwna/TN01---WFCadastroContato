using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01___WFCadastroContato
{
    public partial class FormCadastroContato : Form
    {
        public FormCadastroContato()
        {
            InitializeComponent();
        }

        public void Sucesso(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);}

        public void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mkdTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            txtEmail.Clear();
        }private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string email = txtEmail.Text;
            string telefone = mkdTelefone.Text;
            ETipoTelefone tipotelefone;
           

            if (nome.Length == 0)
            {
                MessageBox.Show("O nome não foi informado!", "Erro");
                return;
            }
            if (sobrenome.Length == 0)
            {
                MessageBox.Show("O sobrenome não foi informado!", "Erro");
                return;
            }

            if (email.Length == 0)
            {
                MessageBox.Show("O email não foi informado!", "Erro");
                return;
            }

            if (telefone.Length == 0)
            {
                MessageBox.Show("O telefone não foi informado!", "Erro");
                return;
            }

            if (rdbPessoal.Checked)
            {
                tipotelefone = ETipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                tipotelefone = ETipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                tipotelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi informado", "Erro");
                return;
            }


            Contato c1 = new Contato();
            c1.Nome = nome;
            c1.Sobrenome = sobrenome;
            c1.Email = email;
            c1.Codigo = 0;
            c1.TipoTelefone = tipotelefone;
            c1.DDD = mkdTelefone.Text.Substring(1, 2);
            c1.Telefone = mkdTelefone.Text.Substring(5);


            Contato.ListaContatos.Add(c1);

            Sucesso("Cadastrado com Sucesso");

            LimparFormulario();
        }
       
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
