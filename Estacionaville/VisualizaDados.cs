using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Estacionaville
{
    public partial class VisualizaDados : Form
    {
        public VisualizaDados()
        {
            InitializeComponent();

            // Faz com que as colunas preencham todo o espaço do DataGridView
            dgVisualizaVagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Se quiser que as linhas sejam criadas automaticamente, já é o padrão:
            dgVisualizaVagas.AllowUserToAddRows = false;
            dgVisualizaVagas.ReadOnly = true;
        }

        private void VisualizaDados_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void CarregarDados()
        {
            try
            {
                using (var conn = Conexao.GetConexao())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Vagas ORDER BY NumeroVaga";

                    using (var da = new SQLiteDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt); // Preenche o DataTable com os dados do banco

                        dgVisualizaVagas.DataSource = dt; // Exibe no DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}
