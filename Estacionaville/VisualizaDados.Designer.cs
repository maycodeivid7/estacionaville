namespace Estacionaville
{
    partial class VisualizaDados
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
            dgVisualizaVagas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgVisualizaVagas).BeginInit();
            SuspendLayout();
            // 
            // dgVisualizaVagas
            // 
            dgVisualizaVagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVisualizaVagas.Location = new Point(3, 3);
            dgVisualizaVagas.Name = "dgVisualizaVagas";
            dgVisualizaVagas.RowHeadersWidth = 62;
            dgVisualizaVagas.Size = new Size(771, 338);
            dgVisualizaVagas.TabIndex = 0;
            dgVisualizaVagas.Dock = DockStyle.Fill;
            // 
            // 
            // VisualizaDados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgVisualizaVagas);
            Name = "VisualizaDados";
            Text = "Visualiza Dados";
            Load += VisualizaDados_Load;
            ((System.ComponentModel.ISupportInitialize)dgVisualizaVagas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVisualizaVagas;
    }
}