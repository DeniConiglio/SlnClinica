using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Medico: Persona
    {
        public Medico(int numMatricula,string nombre, string apellido, string dni, DateTime fechaNacimiento) : base(nombre, apellido, dni, fechaNacimiento)
        {
            NumMatricula = numMatricula;
        }

        public int NumMatricula { get; set; }
       
    }
}
