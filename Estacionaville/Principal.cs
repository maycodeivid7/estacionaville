using System.Data.SQLite;
using System.Linq;

namespace Estacionaville
{
    public partial class Principal : Form
    {
        public Principal()
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

        private void CarregarVagasDoBanco()
        {
            using (var conn = Conexao.GetConexao())
            {
                conn.Open();
                string sql = "SELECT NumeroVaga, Placa FROM Vagas WHERE Status = 'Ocupada'";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int numVaga = reader.GetInt32(0);
                        string placa = reader.GetString(1);

                        // Procura o botão correspondente no Form1
                        Button btn = this.Controls.Find("btnVaga" + numVaga, true).FirstOrDefault() as Button;
                        if (btn != null)
                        {
                            AtualizarCorBotao(btn, true);
                            btn.Text = "Vaga " + numVaga.ToString("D2") + "\n" + placa;
                        }
                    }
                }
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
                    string placa = cadastro.PlacaDigitada;
                    string nomeBotao = btnClicado.Name;
                    int numVaga = int.Parse(nomeBotao.Replace("btnVaga", ""));

                    // Usando parâmetros para evitar erros e injeções SQL
                    string sql = "INSERT OR REPLACE INTO Vagas (NumeroVaga, Placa, Status) VALUES (@num, @placa, 'Ocupada')";

                    using (var conn = Conexao.GetConexao())
                    {
                        conn.Open();
                        using (var cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@num", numVaga);
                            cmd.Parameters.AddWithValue("@placa", placa);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Atualiza a UI
                    AtualizarCorBotao(btnClicado, true);
                    btnClicado.Text = $"Vaga {numVaga:D2}\n{placa}";
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Define todas como verdes inicialmente
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Button btn) AtualizarCorBotao(btn, false);
            }

            // Carrega o estado atual da base de dados
            CarregarVagasDoBanco();
        }

        private void btnVisualizaDados_Click(object sender, EventArgs e)
        {
            VisualizaDados visualiza_dados = new VisualizaDados();
            visualiza_dados.ShowDialog();
        }
    }
}
