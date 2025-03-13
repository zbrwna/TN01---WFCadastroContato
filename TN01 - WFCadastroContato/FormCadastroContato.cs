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
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mkdTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            txtEmail.Clear();
   
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string email = txtEmail.Text;
            string telefone = mkdTelefone.Text;
            string tipotelefone = gbxTipoTelefone.Text;

            if (nome.Length == 0)
            {
                MessageBox.Show("O nome não foi informado!" , "Erro");
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
               tipotelefone = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                tipotelefone = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                tipotelefone = "Recado";
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi informado","Erro");
                return;
            }
 
            string mensagem = $@"
                Nome: {txtNome.Text} {txtSobrenome.Text}
                Tipo Telefone: {tipotelefone}
                DDD/Telefone: {telefone}
                E-mail: {txtEmail.Text}    ";

            Sucesso(mensagem);

         
        }
    }
}
