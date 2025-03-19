namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            cbxCategoria = new ComboBox();
            lblCategoria = new Label();
            lblPreco = new Label();
            dtpDataVencimento = new DateTimePicker();
            lblDataVencimento = new Label();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            btnSalvar = new Button();
            nupPreco = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 21);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(12, 77);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 2;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 95);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(284, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Perecível", "Não Perecível" });
            cbxCategoria.Location = new Point(139, 39);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(139, 21);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 137);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço";
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Location = new Point(151, 155);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(162, 23);
            dtpDataVencimento.TabIndex = 8;
            dtpDataVencimento.TabStop = false;
            dtpDataVencimento.Value = new DateTime(2025, 3, 18, 0, 0, 0, 0);
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(151, 137);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(113, 15);
            lblDataVencimento.TabIndex = 9;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(12, 198);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 10;
            lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.BorderStyle = BorderStyle.FixedSingle;
            txtObservacao.Location = new Point(12, 216);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(284, 98);
            txtObservacao.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(221, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 33);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // nupPreco
            // 
            nupPreco.DecimalPlaces = 2;
            nupPreco.Location = new Point(12, 155);
            nupPreco.Name = "nupPreco";
            nupPreco.Size = new Size(120, 23);
            nupPreco.TabIndex = 13;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 362);
            Controls.Add(nupPreco);
            Controls.Add(btnSalvar);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(lblDataVencimento);
            Controls.Add(dtpDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(lblCategoria);
            Controls.Add(cbxCategoria);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nupPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private ComboBox cbxCategoria;
        private Label lblCategoria;
        private Label lblPreco;
        private DateTimePicker dtpDataVencimento;
        private Label lblDataVencimento;
        private Label lblObservacao;
        private TextBox txtObservacao;
        private Button btnSalvar;
        private NumericUpDown nupPreco;
    }
}