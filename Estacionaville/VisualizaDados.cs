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
                    string sql = "SELECT * FROM Vagas";

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
