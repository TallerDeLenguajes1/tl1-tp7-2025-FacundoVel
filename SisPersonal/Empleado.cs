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
        private DateTime fechaNacmiento;
        private char estadoCivil;
        private DateTime fechaDeIngreso;
        private double SueldoBasico;
        private cargos Cargo; 

        
    }
}