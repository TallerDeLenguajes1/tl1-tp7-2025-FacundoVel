namespace EspacioEmpleado{

    enum cargos {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaDeIngreso;
        private double sueldoBasico;
        private cargos cargo; 

        public string Nombre{
            get => nombre;
            set => nombre = value;
        }
        public string Apellido{
            get => apellido;
            set => apellido = value;
        }
        public DateTime FechaNacimiento{
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public char EstadoCivil{
            get => estadoCivil;
            set => estadoCivil = value;
        }
        public DateTime FechaDeIngreso{
            get => fechaDeIngreso;
            set => fechaDeIngreso = value;
        }
        public double SueldoBasico{
            get => sueldoBasico;
            set => sueldoBasico = value;
        }
        public cargos Cargo{
            get => cargo;
            set => cargo = value;
        }

    }

    public int ObtenerAntiguedad()
    {
        DateTime hoy = DateTime.Today;
        int antiguedad = hoy.Year - fechaDeIngreso.Year;
        return antiguedad;
    }

    public int ObtenerEdad()
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento.Year;
        return edad;
    }

    public int AñosParaJubilacion()
    {
        int edadActual = ObtenerEdad();
        int edadJubilacion = 65;
        int añosParaJubilacion = edadJubilacion - edadActual;
        return añosParaJubilacion;
    }
}