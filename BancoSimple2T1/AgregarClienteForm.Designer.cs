namespace BancoSimple2T1
{
    partial class AgregarClienteForm
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
            txtNombre = new TextBox();
            btnAceptar = new Button();
            txtIdentificacion = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
=======
            label1.Location = new Point(25, 13);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
<<<<<<< HEAD
            txtNombre.Location = new Point(82, 28);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
=======
            txtNombre.Location = new Point(172, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
<<<<<<< HEAD
            btnAceptar.Location = new Point(99, 72);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 38);
=======
            btnAceptar.Location = new Point(47, 113);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 50);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtIdentificacion
            // 
<<<<<<< HEAD
            txtIdentificacion.Location = new Point(353, 28);
            txtIdentificacion.Margin = new Padding(3, 2, 3, 2);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(152, 23);
=======
            txtIdentificacion.Location = new Point(172, 72);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(173, 27);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            txtIdentificacion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(257, 33);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
=======
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            label2.TabIndex = 3;
            label2.Text = "Identificacion";
            // 
            // btnCancelar
            // 
<<<<<<< HEAD
            btnCancelar.Location = new Point(376, 72);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 38);
=======
            btnCancelar.Location = new Point(367, 113);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 50);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarClienteForm
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 140);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 187);
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Controls.Add(btnCancelar);
            Controls.Add(txtIdentificacion);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
<<<<<<< HEAD
            Margin = new Padding(3, 2, 3, 2);
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
            Name = "AgregarClienteForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnAceptar;
        private TextBox txtIdentificacion;
        private Label label2;
        private Button btnCancelar;
    }
}