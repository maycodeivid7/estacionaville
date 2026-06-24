using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Estacionaville
{
    public partial class FormCadastro : Form
    {
        // O Designer irá ignorar esta propriedade com esses atributos
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // Esta propriedade guarda o texto digitado
        public string PlacaDigitada { get; set; }

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Por favor, digite a placa.");
                return;
            }

            PlacaDigitada = txtPlaca.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Define o resultado como Cancel e fecha
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
