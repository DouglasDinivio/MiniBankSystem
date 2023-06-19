using System.Drawing;

namespace Teste3Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            String Nome = textBox1.Text;
            String Conta = textBox2.Text;
            String Saldo = textBox3.Text;

            LabelTitular.Text = Nome;
            LabelNrDaConta.Text = Conta;

            txtSaldo.Text = Saldo;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show("Bem Vindo " + Nome + "Cadastro de conta" + Conta + " efectuado com sucesso!!");
        }

        private void btnLevantamento_Click(object sender, EventArgs e)
        {
            Double SaldoInicial = Double.Parse(txtSaldo.Text);
            Double Deposito = Double.Parse(txtDeposito.Text);

            Double taxadeoperacao = 5;

            Double SaldoFinal = (SaldoInicial - Deposito) - taxadeoperacao;

            txtSaldo.Text = SaldoFinal.ToString();

            MessageBox.Show("Efectuou o levantamento de " + txtLevantamento.Text + " e seu saldo fica " + SaldoFinal);
            txtLevantamento.Clear();
        }

        private void txtLevantamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            Double SaldoInicial = Double.Parse(txtSaldo.Text);
            Double Deposito = Double.Parse(txtDeposito.Text);

            Double SaldoFinal = SaldoInicial + Deposito;

            txtSaldo.Text = SaldoFinal.ToString();

            MessageBox.Show("Efectuou o deposito de " + Deposito + "  e seu saldo fica " + SaldoFinal);

            txtDeposito.Clear();
        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}