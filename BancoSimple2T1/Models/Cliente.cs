using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple2T1.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
<<<<<<< HEAD

        // Relacion uno a muchos con cuentas
=======
>>>>>>> 0bd72ef ( Primero modificacion:Se modifico el nombre del objeto con el cual se accede a BancoSSimpleContext, para evitar confusiones y que se maneje un termino al momento de usar BancoSimpleContext)
        public List <Cuenta> Cuentas { get; set;} = new List<Cuenta>();
    }
}
