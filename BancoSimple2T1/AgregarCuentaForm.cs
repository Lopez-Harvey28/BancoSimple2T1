using BancoSimple2T1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple2T1
{
    public partial class AgregarCuentaForm : Form
    {
        public Cuenta NuevaCuenta { get;  private set; }
        private int _clienteId;
        public AgregarCuentaForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
        }
<<<<<<< HEAD
        // Maneja el evento de clic del botón Aceptar y crea la cuenta si los datos son válidos
=======

>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroCuenta.Text))
            {
                MessageBox.Show("El numero de cuenta es requerido");
                return;
            }

            NuevaCuenta = new Cuenta
            {
<<<<<<< HEAD
                NumeroCuenta = txtNumeroCuenta.Text.Trim(),
=======
                NumeroCuenta = txtNumeroCuenta.Text,
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
                Saldo = numSaldoInicial.Value,
                ClienteId = _clienteId,
                Activa = true
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
