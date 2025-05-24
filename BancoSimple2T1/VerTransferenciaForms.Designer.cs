namespace BancoSimple2T1
{
    partial class VerTransferenciaForms
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
            dgvTransferencias = new DataGridView();
<<<<<<< HEAD
            label1 = new Label();
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).BeginInit();
            SuspendLayout();
            // 
            // dgvTransferencias
            // 
            dgvTransferencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvTransferencias.Location = new Point(75, 82);
            dgvTransferencias.Margin = new Padding(3, 2, 3, 2);
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.RowHeadersWidth = 51;
            dgvTransferencias.Size = new Size(536, 227);
            dgvTransferencias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 44);
            label1.Name = "label1";
            label1.Size = new Size(314, 17);
            label1.TabIndex = 1;
            label1.Text = "Historial de Transferencia que se han realizado";
            // 
            // VerTransferenciaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(dgvTransferencias);
            Margin = new Padding(3, 2, 3, 2);
=======
            dgvTransferencias.Location = new Point(70, 49);
            dgvTransferencias.Name = "dgvTransferencias";
            dgvTransferencias.RowHeadersWidth = 51;
            dgvTransferencias.Size = new Size(612, 332);
            dgvTransferencias.TabIndex = 0;
            // 
            // VerTransferenciaForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTransferencias);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Name = "VerTransferenciaForms";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvTransferencias).EndInit();
            ResumeLayout(false);
<<<<<<< HEAD
            PerformLayout();
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
        }

        #endregion

        private DataGridView dgvTransferencias;
<<<<<<< HEAD
        private Label label1;
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
    }
}