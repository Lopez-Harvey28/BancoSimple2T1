﻿using BancoSimple2T1.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class TransaccionesForms : Form
    {
        // Se ocupa el readonly para que no se pueda modificar el monto desde fuera de la clase
        public decimal Monto { get; private set; }
        private readonly int _cuentaOrigenId;
        private readonly int _cuentaDestinoId;
        //Haremos los mismos cambios que hicimos anteriormente
        private readonly BancoSimpleContext _dbcontext;
        public TransaccionesForms(int cuentaOrigenId, int cuentaDestinoId)
        {
            InitializeComponent();
            _cuentaOrigenId = cuentaOrigenId;
            _cuentaDestinoId = cuentaDestinoId;
            //Se cambio aquí
            _dbcontext = new BancoSimpleContext();
            CargarInformacionCuenta();

        }
        // Se coloca el modificador private para que no se pueda acceder desde fuera de la clase
        private void CargarInformacionCuenta()
        {
            //Y aqui tambien 
            var cuentaOrigen = _dbcontext.Cuentas.
                Include(c => c.cliente).
                First(c => c.CuentaId == _cuentaOrigenId);

            var cuentaDestino = _dbcontext.Cuentas.
               Include(c => c.cliente).
               First(c => c.CuentaId == _cuentaDestinoId);

            lblOrigen.Text = $"Nombre: {cuentaOrigen.cliente.Nombre} cuenta {cuentaOrigen.NumeroCuenta}";
            lblDestino.Text = $"Nombre: {cuentaDestino.cliente.Nombre} cuenta {cuentaDestino.NumeroCuenta}";
            lblDisponible.Text = $"Saldo Disponible : {cuentaOrigen.Saldo:c}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSaldo.Text, out decimal monto) && monto > 0)
            {
                Monto = monto;
                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("Ingrese un monto mayor a 0");
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
