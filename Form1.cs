using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_Citas_Médicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Doctores> doctores = new List<Doctores>();
        List<Paciente> pacientes = new List<Paciente>();
        List<Cita> citas = new List<Cita>();

        void CargarDoctores()
        {
            string[] lineas = File.ReadAllLines("doctores.txt");

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] datos = linea.Split(';');

                if (datos.Length < 3)
                    continue;

                Doctores doctor = new Doctores(
                    int.Parse(datos[0]),
                    datos[1],
                    datos[2]
                );

                doctores.Add(doctor);

                comboBoxDoctor.Items.Add(doctor.NombreCompleto);
            }
        }

        void CargarPacientes()
        {
            string[] lineas = File.ReadAllLines("pacientes.txt");

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] datos = linea.Split(';');

                if (datos.Length < 3)
                    continue;

                Paciente paciente = new Paciente(
                    datos[0],
                    datos[1],
                    datos[2]
                );

                pacientes.Add(paciente);

                comboBoxPaciente.Items.Add(paciente.Nombre);
            }
        }
        void CargarHoras()
        {
            comboBoxHoraCita.Items.Add("08:00");
            comboBoxHoraCita.Items.Add("09:00");
            comboBoxHoraCita.Items.Add("10:00");
            comboBoxHoraCita.Items.Add("11:00");
            comboBoxHoraCita.Items.Add("12:00");
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            Doctores doctor = doctores[comboBoxDoctor.SelectedIndex];
            Paciente paciente = pacientes[comboBoxPaciente.SelectedIndex];

            DateTime fecha = dateTimePickerFechaCita.Value;
            string hora = comboBoxHoraCita.Text;

            Cita nueva = new Cita(doctor.Id, paciente.Dpi, fecha, hora);

            citas.Add(nueva);

            string linea = doctor.Id + ";" +
                           paciente.Dpi + ";" +
                           fecha.ToString("yyyy-MM-dd") + ";" +
                           hora;

            File.AppendAllText("citas.txt", linea + Environment.NewLine);

            MessageBox.Show("Cita guardada correctamente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDoctores();
            CargarPacientes();
            CargarHoras();
        }
    }
}
