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

            if (genero == "femenino" && edad <= 60)
            {
                return (60 - edad);
            }
            if (genero == "masculino" && edad <= 65)
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
            DateTime hoy = new DateTime(anioActual, mesActual, diaActual);
            TimeSpan dif = hoy - fechaDeNacimiento;
            int diasTotales = dif.Days;

            return (diasTotales / 365);
        }
        public int calcularAntiguedad()
        {
            int anioActual = DateTime.Now.Year;
            return (anioActual - fechaIngreso.Year);

        }

        private double calcularAdicional()
        {

            int antiguedad = calcularAntiguedad();
            double adicional = 0;

            if (antiguedad >= 20)
            {
                adicional = ((sueldoBasico * 25) / 100) * antiguedad;
            }
            else
            {
                adicional = (sueldoBasico / 100) * antiguedad;

            }
            if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
            {
                adicional += adicional * 0.50;
            }

            if (estadoCivil == "casado")
            {
                adicional += 15000;
            }

            return adicional;
        }
        public double calcularSalario()
        {
            return (sueldoBasico + calcularAdicional());
        }

    

    }

    public enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador

    }

}

/*
 saco el 1% del sueldo basico y lo multiplico por cada año de antiguedad hasta los 20 años
 despues de los 20 años:
 25% del sueldo basico * antiguedad.

 si es ingeniero o especialista 
 adicional + 50 %. 
 si es casado :
 adicional + 15.000

*/

/*
(numero * porcentaje) /100

*/