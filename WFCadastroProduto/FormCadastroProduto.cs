using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Atenção(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
                return true;
            if (cbxCategoria.SelectedIndex == -1)
                return true;
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
                return true;
            if (nupPreco.Value <= 0)
                return true;
            if (dtpDataVencimento.Value == DateTime.Today)
                return true;
            if (string.IsNullOrEmpty(txtObservacao.Text))
                return true;


            return false;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNomeProduto.Clear();
            txtObservacao.Clear();
            dtpDataVencimento.Value = DateTime.Today;
            cbxCategoria.SelectedIndex = -1;
            nupPreco.Value = 0;
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "00" + Produto.ObterLista().Count + 1;
            dtpDataVencimento.Value = DateTime.Today;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposNaoPreenchidos() == true)
            {
                Erro("Os Campos Obrigatórios devem ser Preenchidos");
                return;
            }

            Produto prod = new Produto();
            prod.Codigo = Convert.ToInt32(txtCodigo.Text);// int.Parse(txt.Codigo.Text);
            prod.Nome = txtNomeProduto.Text;
            prod.DataVencimento = dtpDataVencimento.Value;
            prod.Preco = Convert.ToDouble(nupPreco.Value);
            prod.Categoria = cbxCategoria.SelectedItem!.ToString();
            prod.Observacao = txtObservacao.Text;

            prod.Cadastrar();

            LimparCampos();
            int totallista = Produto.ObterLista().Count + 1;
            txtCodigo.Text = "000" + totallista;

            //Produto.ListaProdutos.Add(prod);

            //if (string.IsNullOrEmpty(txtNomeProduto.Text))
            //{
            //    MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtCodigo.Text))
            //{
            //    MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrEmpty(dtpDataVencimento.Text)) ;
            //{
            //    MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrEmpty(cbxCategoria.Text))
            //{
            //    MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtObservacao.Text))
            //{
            //    MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

       
    }
}
