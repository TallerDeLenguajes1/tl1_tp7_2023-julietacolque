namespace EspacioEmpleado
{
    public class Empleado
    {
        private string? nombre;
        private string? apellido;
        private DateTime fechaDeNacimiento;

        private string? estadoCivil;
        private string? genero;
        DateTime fechaIngreso;
        private double sueldoBasico;
        private cargos cargo;



        //get and set
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string? EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string? Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        internal cargos Cargo { get => cargo; set => cargo = value; }







        public int aniosParaJubilarse()
        {
            int edad = calcularEdad();

            if (genero == "mujer" && edad <= 60)
            {
                return (60 - edad);
            }
            if (genero == "hombre" && edad <= 65)
            {
                return (65 - edad);
            }
            return 0;

        }

        public int calcularEdad()
        {
            int anioActual = DateTime.Now.Year;
            int mesActual = DateTime.Now.Month;
            int diaActual = DateTime.Now.Day;
            DateTime hoy = new DateTime(anioActual,mesActual,diaActual);
            TimeSpan dif = hoy - fechaDeNacimiento;
            int diasTotales = dif.Days;

            return diasTotales/365;
        }
        public int calcularAntiguedad()
        {
            int anioActual = DateTime.Now.Year;
            return (anioActual - fechaIngreso.Year);

        }



    }

    enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador

    }

}