using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Citas_Médicas
{
    internal class Doctores
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Especialidad { get; set; }

        public Doctores(int id, string nombreCompleto, string especialidad)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            Especialidad = especialidad;
        }
    }
}
