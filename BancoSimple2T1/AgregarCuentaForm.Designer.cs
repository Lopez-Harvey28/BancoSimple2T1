namespace BancoSimple2T1
{
    partial class AgregarCuentaForm
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
            label2 = new Label();
            txtNumeroCuenta = new TextBox();
            numSaldoInicial = new NumericUpDown();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)numSaldoInicial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
=======
            label1.Location = new Point(8, 26);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            label1.TabIndex = 0;
            label1.Text = "Numero de cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(37, 53);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
=======
            label2.Location = new Point(8, 74);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            label2.TabIndex = 1;
            label2.Text = "Saldo Inicial";
            // 
            // txtNumeroCuenta
            // 
<<<<<<< HEAD
            txtNumeroCuenta.Location = new Point(191, 17);
            txtNumeroCuenta.Margin = new Padding(3, 2, 3, 2);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(123, 23);
=======
            txtNumeroCuenta.Location = new Point(249, 26);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(140, 27);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            txtNumeroCuenta.TabIndex = 2;
            // 
            // numSaldoInicial
            // 
<<<<<<< HEAD
            numSaldoInicial.Location = new Point(192, 53);
            numSaldoInicial.Margin = new Padding(3, 2, 3, 2);
            numSaldoInicial.Name = "numSaldoInicial";
            numSaldoInicial.Size = new Size(122, 23);
=======
            numSaldoInicial.Location = new Point(250, 83);
            numSaldoInicial.Name = "numSaldoInicial";
            numSaldoInicial.Size = new Size(139, 27);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            numSaldoInicial.TabIndex = 3;
            // 
            // btnAceptar
            // 
<<<<<<< HEAD
            btnAceptar.Location = new Point(134, 101);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 27);
=======
            btnAceptar.Location = new Point(125, 138);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 36);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // AgregarCuentaForm
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 139);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 185);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Controls.Add(btnAceptar);
            Controls.Add(numSaldoInicial);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label2);
            Controls.Add(label1);
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Name = "AgregarCuentaForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numSaldoInicial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumeroCuenta;
        private NumericUpDown numSaldoInicial;
        private Button btnAceptar;
    }
}