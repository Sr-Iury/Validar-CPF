namespace valida_cpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             Validacoes.ValidaCPF(mask.Text).ToString();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            
            

        }

        private void botao_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mask.Text);
            string cpf = mask.Text;
            MessageBox.Show(Validacoes.ValidaCPF(cpf).ToString());
        }
    }
}