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


        Empleado[] empleados = {empleado1, empleado2, empleado3};
       

        double totalSalarios = MontoTotal(empleados);
        Console.WriteLine("El monto total en salarios es: $ " + totalSalarios);
        int indice = ProximoAJubilarse(empleados);
        Console.WriteLine(indice);
        Console.WriteLine("EMPLEADO PROXIMO A JUBILARSE");
        MostrarEmpleado(empleados,indice);
// 

    }

    public static double MontoTotal(Empleado[] empleados)
    {
        double monto = 0;
        for (int i = 0; i < empleados.Length; i++)
        {
            monto = empleados[i].calcularSalario() +  monto;
        }
        return monto;
    }
    public static int ProximoAJubilarse(Empleado[] empleados)
    {
        int minimo = 100, indice=0;
        for (int i = 0; i < empleados.Length; i++)
        {
            if (empleados[i].aniosParaJubilarse() < minimo)
            {
                minimo = empleados[i].aniosParaJubilarse();
                indice = i;
                
            }
        }
        return indice;
    }

    public static void MostrarEmpleado(Empleado[] empleados, int indice)
    {
        string datosEmpleado =$"Nombre:{empleados[indice].Nombre}\nApellido:{empleados[indice].Apellido}\nFecha de Nacimiento: {empleados[indice].FechaDeNacimiento}\nEstado Civil:{empleados[indice].EstadoCivil}\nGenero: {empleados[indice].Genero}\nIngreso: {empleados[indice].FechaIngreso}\nSueldo Basico: {empleados[indice].SueldoBasico}\nCargo: {empleados[indice].Cargo}\nLa antiguedad del empleado es: {empleados[indice].calcularAntiguedad()}\nEdad: {empleados[indice].calcularEdad()}\nAnios que le faltan para jubilarse:{empleados[indice].aniosParaJubilarse()}\n";

        Console.WriteLine(datosEmpleado);

    }

}