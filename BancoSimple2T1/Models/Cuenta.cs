using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple2T1.Models
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; } = true;
<<<<<<< HEAD

        public int ClienteId { get; set; }
        public Cliente cliente { get; set; }

        // Nombre de propiedad capitalizacion por convencion
=======
        public int ClienteId { get; set; }
        public Cliente cliente { get; set; }

>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
    }
}
          
