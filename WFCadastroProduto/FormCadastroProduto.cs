using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(dtpDataVencimento.))
            {
                MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Produto prod = new Produto();
            prod.Codigo = Convert.ToInt32(txtCodigo.Text);
            prod.Nome = txtNomeProduto.Text;
            prod.DataVencimento = dtpDataVencimento.Value;
            prod.Preco = Convert.ToDouble(nupPreco.Value);
            prod.Categoria = cbxCategoria.SelectedItem!.ToString();
            prod.Observacao = txtObservacao.Text;

            Produto.ListaProdutos.Add(prod);

            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();


        }
    }
}
