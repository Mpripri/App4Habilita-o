namespace App4Habilitação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void bntVerificar_Click(object sender, EventArgs e) 
        {
            string nome = txtNome.Text;
            int idade;
            string tipoCarteira = txtTipo.Text.ToUpper();

            // Verifica se a idade é um número válido
            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("Por favor, digite uma idade válida.");
                return;
            }

            string resultado = "";

            if (idade < 18)
            {
                resultado = $"{nome}, você ainda não pode tirar habilitação. Espere mais um pouco! 🛑";
            }
            else
            {
                if ("ABCDE".Contains(tipoCarteira))
                {
                    resultado = $"{nome}, você pode tirar sua habilitação tipo {tipoCarteira}! ✅";
                }
                else
                {
                    resultado = $"Tipo de carteira inválido, {nome}. Escolha A, B, C, D ou E.";
                }
            }

            lblResultado.Text = resultado;
            lblResultado.Visible = true; // Mostra o resultado
        }

    }
}
