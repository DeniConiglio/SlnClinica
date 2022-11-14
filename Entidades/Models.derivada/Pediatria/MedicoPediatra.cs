using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Models.derivada;



namespace Entidades.Models.derivada
{
    public class MedicoPediatra : Medico
    {
        public MedicoPediatra(int numMatricula, string nombre, string apellido, string dni, DateTime fechaNacimiento) : base(numMatricula, nombre, apellido, dni, fechaNacimiento)
        {
            
        }
    }
}
