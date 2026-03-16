using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Citas_Médicas
{
    internal class Cita
    {
        int idDoctor;
        int idPaciente;
        DateTime fechaCita;
        int horaCita;

        public Cita(int id, object dPI, DateTime fecha, string hora)
        {
        }

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public int HoraCita { get => horaCita; set => horaCita = value; }
    }
}
