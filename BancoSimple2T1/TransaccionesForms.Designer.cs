namespace BancoSimple2T1
{
    partial class TransaccionesForms
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
            lblOrigen = new Label();
            btnAceptar = new Button();
            lblMonto = new Label();
            lblDestino = new Label();
            btnCancelar = new Button();
            lblDisponible = new Label();
            txtSaldo = new TextBox();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(38, 36);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(38, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "label1";
            lblOrigen.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(38, 171);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 41);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(38, 74);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(38, 111);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(38, 15);
            lblDestino.TabIndex = 4;
            lblDestino.Text = "label3";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(246, 171);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 41);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Location = new Point(233, 75);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(43, 15);
            lblDisponible.TabIndex = 6;
            lblDisponible.Text = "Monto";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(106, 72);
            txtSaldo.Margin = new Padding(3, 2, 3, 2);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(92, 23);
            txtSaldo.TabIndex = 7;
            // 
            // TransaccionesForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 238);
            Controls.Add(txtSaldo);
            Controls.Add(lblDisponible);
            Controls.Add(btnCancelar);
            Controls.Add(lblDestino);
            Controls.Add(lblMonto);
            Controls.Add(btnAceptar);
            Controls.Add(lblOrigen);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransaccionesForms";
            Text = "TransaccionesForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrigen;
        private Button btnAceptar;
        private Label lblMonto;
        private Label lblDestino;
        private Button btnCancelar;
        private Label lblDisponible;
        private TextBox txtSaldo;
    }
}