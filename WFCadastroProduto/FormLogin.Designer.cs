namespace WFCadastroProduto
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(25, 98);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite a sua senha..";
            txtSenha.Size = new Size(113, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(25, 80);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(25, 24);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(25, 42);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite o seu login..";
            txtLogin.Size = new Size(113, 23);
            txtLogin.TabIndex = 1;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(90, 142);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 3;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 212);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(btnAcessar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblLogin;
        private TextBox txtLogin;
        private Button btnAcessar;
    }
}