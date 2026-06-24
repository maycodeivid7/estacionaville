namespace Estacionaville
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPlaca = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 38);
            label1.TabIndex = 0;
            label1.Text = "Placa do Veículo:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(169, 10);
            txtPlaca.Margin = new Padding(4, 5, 4, 5);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(215, 31);
            txtPlaca.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(147, 88);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(140, 38);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Ocupar vaga";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(17, 88);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadastro
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(587, 315);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPlaca);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlaca;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}