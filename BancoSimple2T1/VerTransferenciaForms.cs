using BancoSimple2T1.Data;
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
    public partial class VerTransferenciaForms : Form
    {
        //Aqui ocurre lo mismo, el objeto "con" por si solo no nos dice nada al igual que antes
        //Por ello lo cambiaremos y utlizaremos el mismo nombre para llevar la misma logica que antes y asi no confundirnos por palabras sin relación
<<<<<<< HEAD
        //private readonly BancoSimpleContext _con = new BancoSimpleContext(); aqui tambien se usa para que el usuario no pueda modificar el saldo
        private readonly BancoSimpleContext _dbcontext= new BancoSimpleContext();
=======
        private BancoSimpleContext _dbcontext= new BancoSimpleContext();
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
        public VerTransferenciaForms()
        {
            InitializeComponent();
            CargarTransferencias();
        }

        private void CargarTransferencias()
        {
            //así que lo cambiamos a una con la que ya estamos realcionado
            dgvTransferencias.DataSource = _dbcontext.Transacciones.ToList();
        }
    }
}
