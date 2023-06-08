using EspacioCalculadora;
using EspacioEmpleado;



internal class Program
{
    private static void Main(string[] args)
    {
        // int opcion, escape = 1;
        // double numero;
        // var c1 = new Calculadora();
        // c1.Resultado = 10;


        // while (escape == 1)
        // {

        //     Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Limpiar\nIngrese la opcion: ");
        //     bool conversion = int.TryParse(Console.ReadLine(), out opcion);
        //     Console.WriteLine("Ingrese un valor");
        //     bool conversionNum = double.TryParse(Console.ReadLine(), out numero);
        //     if (conversion && conversionNum)
        //     {
        //         switch (opcion)
        //         {
        //             case 1:
        //                 c1.Sumar(numero);
        //                 break;
        //             case 2:
        //                 c1.Restar(numero);
        //                 break;
        //             case 3:
        //                 c1.Multiplicar(numero);
        //                 break;
        //             case 4:
        //                 c1.Dividir(numero);
        //                 break;
        //             case 5:
        //                 c1.Limpiar();
        //                 break;

        //         }
        //     }
        //     Console.WriteLine(c1.Resultado);

        //     do
        //     {
        //         Console.WriteLine("Seguir?");
        //         conversion = int.TryParse(Console.ReadLine(), out escape);
        //     } while (!conversion);

        // }


        Empleado empleado1 = new Empleado();
        Empleado empleado2 = new Empleado();
        Empleado empleado3 = new Empleado();


        //carga
        empleado1.Nombre = "Julieta";
        empleado1.Apellido = "Colque";
        empleado1.FechaDeNacimiento = new DateTime(2000, 4, 8);
        empleado1.EstadoCivil = "soltera";
        empleado1.Genero = "femenino";
        empleado1.FechaIngreso = new DateTime(2008, 5, 10);
        empleado1.SueldoBasico = 65000;
        empleado1.Cargo = cargos.Auxiliar;

        empleado2.Nombre = "Julian";
        empleado2.Apellido = "Colque";
        empleado2.FechaDeNacimiento = new DateTime(1990, 7, 4);
        empleado2.EstadoCivil = "soltero";
        empleado2.Genero = "masculino";
        empleado2.FechaIngreso = new DateTime(2020, 5, 10);
        empleado2.SueldoBasico = 165000;
        empleado2.Cargo = cargos.Especialista;


        empleado3.Nombre = "Perry";
        empleado3.Apellido = "Perez";
        empleado3.FechaDeNacimiento = new DateTime(2020, 10, 8);
        empleado3.EstadoCivil = "soltera";
        empleado3.Genero = "femenino";
        empleado3.FechaIngreso = new DateTime(2023, 5, 10);
        empleado3.SueldoBasico = 9000;
        empleado3.Cargo = cargos.Auxiliar;


        // Empleado[] empleados = { empleado1, empleado2, empleado3 };
        var ListaEmpleados = new List<Empleado>();

        ListaEmpleados.Add(empleado1);
        ListaEmpleados.Add(empleado2);
        ListaEmpleados.Add(empleado3);


        double totalSalarios = MontoTotal(ListaEmpleados);
        Console.WriteLine("El monto total en salarios es: $ " + totalSalarios);


        Console.WriteLine("EMPLEADO PROXIMO A JUBILARSE");
        Empleado proximoAJubilarse = ProximoAJubilarse(ListaEmpleados);
        MostrarEmpleado(proximoAJubilarse);

        Console.WriteLine("LISTA EMPLEADOS");
        foreach (var empleado in ListaEmpleados)
        {
            MostrarEmpleado(empleado);
        }


    }

    public static double MontoTotal(List<Empleado> ListaEmpleados)
    {
        double monto = 0;

        foreach (var empleado in ListaEmpleados)
        {
            monto = empleado.calcularSalario() + monto;
        }
        return monto;
    }
    public static Empleado ProximoAJubilarse(List<Empleado> ListaEmpleados)
    {
        Empleado empleadoAux = null;
        int minimo = 100;
        for (int i = 0; i < ListaEmpleados.Count; i++)
        {
            if (ListaEmpleados[i].aniosParaJubilarse() < minimo)
            {

                minimo = ListaEmpleados[i].aniosParaJubilarse();
                empleadoAux = ListaEmpleados[i];

            }
        }
        return empleadoAux;
    }

    public static void MostrarEmpleado(Empleado empleado)
    {
        string datosEmpleado = $"Nombre:{empleado.Nombre}\nApellido:{empleado.Apellido}\nFecha de Nacimiento: {empleado.FechaDeNacimiento}\nEstado Civil:{empleado.EstadoCivil}\nGenero: {empleado.Genero}\nIngreso: {empleado.FechaIngreso}\nSueldo Basico: {empleado.SueldoBasico}\nCargo: {empleado.Cargo}\nLa antiguedad del empleado es: {empleado.calcularAntiguedad()}\nEdad: {empleado.calcularEdad()}\nAnios que le faltan para jubilarse:{empleado.aniosParaJubilarse()}\n";

        Console.WriteLine(datosEmpleado);

    }

}