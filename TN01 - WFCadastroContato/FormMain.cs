namespace TN01___WFCadastroContato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroContato form = new FormCadastroContato();
            form.ShowDialog();
        }

        private void mnsListagem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }

        private void mnsSobre_Click(object sender, EventArgs e)
        {

        }
    }
}
