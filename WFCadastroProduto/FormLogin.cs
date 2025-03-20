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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Codigo = 001;
            user.Login = "admin";
            user.Senha = "123456";
            user.DataCadastro = Convert.ToDateTime("18/03/2025 18:30"); // DateTime.Parse ("18/03/2025 18:30");

            Usuario.ListaUsuarios.Add(user);// us.Cadastrar(); < depois de acrescentar o Cadastrar na Class Usuario
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.TodosOsUsuarios())
            {
                if ((txtLogin.Text == us.Login)
                    && (txtSenha.Text == us.Senha))
                {
                    FormMain form = new FormMain();
                    form.ShowDialog();

                    //Limpa os dados dos componentes
                    txtLogin.Clear();
                    txtSenha.Clear();

                    return;
                }
            }

            txtSenha.Clear();
            Erro("Usuário e Senha não se encontram na base!");
            return;


            //private void FormLogin_Load(object sender, EventArgs e)
            // {
            //   Usuario us = new Usuario();
            //    us.Codigo = 001;
            // us.Login = "admin";
            // us.Senha = "123456";
            //us.DataCadastro = Convert.ToDateTime("18/03/2025 18:30");
            // Usuario.ListaUsuarios.Add(us);
            //}

            // private void btnAcessar_Click(object sender, EventArgs e)
            //{

            // foreach (Usuario user in Usuario.ListaUsuarios)
            //     {
            //      if (user.Login == txtLogin.Text)
            //    {
            //         if (user.Senha == txtSenha.Text)
            //        {
            //             MessageBox.Show(
            //                 "Usuario Autenticado com Sucesso!",
            //                "Sucesso!", MessageBoxButtons.OK,
            //                 MessageBoxIcon.Information
            //                  );

            //              FormMain form = new FormMain();
            //              form.ShowDialog();
            //          }
            //          else
            //          {
            //              MessageBox.Show("Usuario Não Autenticado!",
            //              "Erro!", MessageBoxButtons.OK,
            //               MessageBoxIcon.Error);
            //           return;
            //          }
        }
    }
}
