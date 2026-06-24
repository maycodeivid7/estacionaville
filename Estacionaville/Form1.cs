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
                // Lógica de liberar
                if (MessageBox.Show("Deseja liberar a vaga?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AtualizarCorBotao(btnClicado, false);
                    // Reseta para o texto original (ex: "Vaga 01")
                    // Certifique-se de que o texto do botão no design comece com "Vaga"
                    string numeroVaga = btnClicado.Text.Split('\n')[0];
                    btnClicado.Text = numeroVaga;
                }
            }
            else
            {
                // Lógica de ocupar
                FormCadastro cadastro = new FormCadastro();
                if (cadastro.ShowDialog() == DialogResult.OK)
                {
                    // AQUI ESTAVA FALTANDO A LÓGICA DE ATUALIZAÇÃO:
                    string placa = cadastro.PlacaDigitada;

                    // 1. Muda a cor para vermelho
                    AtualizarCorBotao(btnClicado, true);

                    // 2. Atualiza o texto: "Vaga X" + a placa
                    string numeroVaga = btnClicado.Text.Split('\n')[0];
                    btnClicado.Text = numeroVaga + "\n" + placa;
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
