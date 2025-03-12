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
    }
}
