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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Placa do Veículo:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(118, 6);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(152, 23);
            txtPlaca.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(103, 53);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Ocupar vaga";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 53);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 189);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtPlaca);
            Controls.Add(label1);
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