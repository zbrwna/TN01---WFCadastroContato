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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("18/03/2025 18:30");
            Usuario.ListaUsuarios.Add(us);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtLogin.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                        FormMain form = new FormMain();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Não Autenticado!",
                               "Erro!", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                        return;
                    }
                }
               

            }


        }
    }
}
