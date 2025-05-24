﻿using BancoSimple2T1.Models;
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
        // Maneja el evento de clic del botón Aceptar y crea la cuenta si los datos son válidos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroCuenta.Text))
            {
                MessageBox.Show("El numero de cuenta es requerido");
                return;
            }

            NuevaCuenta = new Cuenta
            {
                NumeroCuenta = txtNumeroCuenta.Text.Trim(),
                Saldo = numSaldoInicial.Value,
                ClienteId = _clienteId,
                Activa = true
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
