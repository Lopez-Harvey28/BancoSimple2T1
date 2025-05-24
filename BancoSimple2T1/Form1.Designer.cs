namespace BancoSimple2T1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            btnAgregarCliente = new Button();
            dgvCuentas = new DataGridView();
            btnAgregarCuenta = new Button();
            label1 = new Label();
            label2 = new Label();
            btnTransferencia = new Button();
            btnBuscarCleinte = new Button();
            txtBuscarCliente = new TextBox();
            btnVerTrans = new Button();
            btnDesactivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvClientes.Location = new Point(53, 99);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(410, 215);
=======
            dgvClientes.Location = new Point(72, 160);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(469, 287);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            dgvClientes.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
<<<<<<< HEAD
            btnAgregarCliente.Location = new Point(63, 352);
            btnAgregarCliente.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(125, 43);
=======
            btnAgregarCliente.Location = new Point(72, 470);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(143, 57);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "AgregarCliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvCuentas.Location = new Point(520, 99);
            dgvCuentas.Margin = new Padding(3, 2, 3, 2);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(410, 215);
=======
            dgvCuentas.Location = new Point(594, 160);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(469, 287);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            dgvCuentas.TabIndex = 2;
            // 
            // btnAgregarCuenta
            // 
<<<<<<< HEAD
            btnAgregarCuenta.Location = new Point(520, 335);
            btnAgregarCuenta.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(125, 43);
=======
            btnAgregarCuenta.Location = new Point(594, 470);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(143, 57);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnAgregarCuenta.TabIndex = 3;
            btnAgregarCuenta.Text = "AgregarCuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += btnAgregarCuenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(212, 69);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
=======
            label1.Location = new Point(72, 118);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(692, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
=======
            label2.Location = new Point(594, 118);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            label2.TabIndex = 5;
            label2.Text = "Cuenta";
            // 
            // btnTransferencia
            // 
<<<<<<< HEAD
            btnTransferencia.Location = new Point(665, 335);
            btnTransferencia.Margin = new Padding(3, 2, 3, 2);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(125, 43);
=======
            btnTransferencia.Location = new Point(761, 470);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(143, 57);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnTransferencia.TabIndex = 6;
            btnTransferencia.Text = "Transferencia";
            btnTransferencia.UseVisualStyleBackColor = true;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // btnBuscarCleinte
            // 
<<<<<<< HEAD
            btnBuscarCleinte.Location = new Point(85, 20);
            btnBuscarCleinte.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCleinte.Name = "btnBuscarCleinte";
            btnBuscarCleinte.Size = new Size(127, 26);
=======
            btnBuscarCleinte.Location = new Point(29, 74);
            btnBuscarCleinte.Name = "btnBuscarCleinte";
            btnBuscarCleinte.Size = new Size(145, 34);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnBuscarCleinte.TabIndex = 7;
            btnBuscarCleinte.Text = "Buscar Cliente";
            btnBuscarCleinte.UseVisualStyleBackColor = true;
            btnBuscarCleinte.Click += btnBuscarCleinte_Click;
            // 
            // txtBuscarCliente
            // 
<<<<<<< HEAD
            txtBuscarCliente.Location = new Point(232, 20);
            txtBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(446, 23);
=======
            txtBuscarCliente.Location = new Point(234, 74);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(216, 27);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            txtBuscarCliente.TabIndex = 8;
            // 
            // btnVerTrans
            // 
<<<<<<< HEAD
            btnVerTrans.Location = new Point(805, 335);
            btnVerTrans.Margin = new Padding(3, 2, 3, 2);
            btnVerTrans.Name = "btnVerTrans";
            btnVerTrans.Size = new Size(125, 43);
=======
            btnVerTrans.Location = new Point(920, 470);
            btnVerTrans.Name = "btnVerTrans";
            btnVerTrans.Size = new Size(143, 57);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnVerTrans.TabIndex = 9;
            btnVerTrans.Text = "Ver Transferencia";
            btnVerTrans.UseVisualStyleBackColor = true;
            btnVerTrans.Click += btnVerTrans_Click;
            // 
            // btnDesactivar
            // 
<<<<<<< HEAD
            btnDesactivar.Location = new Point(665, 389);
            btnDesactivar.Margin = new Padding(3, 2, 3, 2);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(125, 43);
=======
            btnDesactivar.Location = new Point(594, 533);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(143, 57);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnDesactivar.TabIndex = 10;
            btnDesactivar.Text = "Desactivar Cuenta";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // Form1
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 443);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 591);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Controls.Add(btnDesactivar);
            Controls.Add(btnVerTrans);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnBuscarCleinte);
            Controls.Add(btnTransferencia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(dgvCuentas);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dgvClientes);
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnAgregarCliente;
        private DataGridView dgvCuentas;
        private Button btnAgregarCuenta;
        private Label label1;
        private Label label2;
        private Button btnTransferencia;
        private Button btnBuscarCleinte;
        private TextBox txtBuscarCliente;
        private Button btnVerTrans;
        private Button btnDesactivar;
    }
}
