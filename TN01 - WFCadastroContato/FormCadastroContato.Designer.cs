namespace TN01___WFCadastroContato
{
    partial class FormCadastroContato
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
            menuStrip1 = new MenuStrip();
            lblNome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            lblSobrenome = new Label();
            lblDddTelefone = new Label();
            label1 = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            lblEmail = new Label();
            mkdTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(35, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(119, 23);
            txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(178, 53);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(225, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(178, 24);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(71, 15);
            lblSobrenome.TabIndex = 4;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // lblDddTelefone
            // 
            lblDddTelefone.AutoSize = true;
            lblDddTelefone.Location = new Point(35, 117);
            lblDddTelefone.Name = "lblDddTelefone";
            lblDddTelefone.Size = new Size(80, 15);
            lblDddTelefone.TabIndex = 5;
            lblDddTelefone.Text = "DDD/Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 215);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(142, 117);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(305, 64);
            gbxTipoTelefone.TabIndex = 7;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone:";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(166, 30);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(81, 30);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(11, 30);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(39, 215);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail:";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(35, 143);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.arrow;
            btnVoltar.Location = new Point(257, 299);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(87, 49);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save;
            btnSalvar.Location = new Point(360, 299);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 49);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 297);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(24, 96);
            label3.Name = "label3";
            label3.Size = new Size(400, 1);
            label3.TabIndex = 14;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(24, 205);
            label4.Name = "label4";
            label4.Size = new Size(400, 1);
            label4.TabIndex = 15;
            // 
            // FormCadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 365);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(mkdTelefone);
            Controls.Add(lblEmail);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(label1);
            Controls.Add(lblDddTelefone);
            Controls.Add(lblSobrenome);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormCadastroContato";
            Text = "FormCadastroContato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label lblSobrenome;
        private Label lblDddTelefone;
        private Label label1;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private Label lblEmail;
        private MaskedTextBox mkdTelefone;
        private TextBox txtEmail;
        private Button btnVoltar;
        private Button btnSalvar;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}