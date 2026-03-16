using System;

namespace Sistema_de_Gestión_de_Citas_Médicas
{
    internal class Cita
    {
        int idDoctor;
        string dpiPaciente;
        DateTime fechaCita;
        string horaCita;

        public Cita(int idDoctor, string dpiPaciente, DateTime fechaCita, string horaCita)
        {
            this.idDoctor = idDoctor;
            this.dpiPaciente = dpiPaciente;
            this.fechaCita = fechaCita;
            this.horaCita = horaCita;
        }

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string DpiPaciente { get => dpiPaciente; set => dpiPaciente = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public string HoraCita { get => horaCita; set => horaCita = value; }
    }
}
