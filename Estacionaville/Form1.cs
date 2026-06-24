namespace Estacionaville
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AtualizarCorBotao(Button btn, bool ocupada)
        {
            if (ocupada)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
            }
        }

        private void Vaga_Click(object sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;

            if (btnClicado.BackColor == Color.Red)
            {
                if (MessageBox.Show("Deseja liberar a vaga?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AtualizarCorBotao(btnClicado, false);
                    btnClicado.Text = btnClicado.Text.Split('\n')[0];
                }
            }
            else
            {
                FormCadastro cadastro = new FormCadastro();

                // Se o usuário clicar em "Salvar" no cadastro:
                if (cadastro.ShowDialog() == DialogResult.OK)
                {
                    string placa = cadastro.PlacaDigitada;

                    AtualizarCorBotao(btnClicado, true); // Muda a cor para Red
                    btnClicado.Text = btnClicado.Text + "\n" + placa; // Atualiza o texto
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Percorre todos os controles dentro do FlowLayoutPanel
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Button btn)
                {
                    // Define todas como verdes ao iniciar
                    AtualizarCorBotao(btn, false);
                }
            }
        }
    }
}
