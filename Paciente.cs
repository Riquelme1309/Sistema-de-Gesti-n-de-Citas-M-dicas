using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Citas_Médicas
{
    internal class Paciente
    {
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Paciente(string dpi, string nombre, string telefono)
        {
            Dpi = dpi;
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
