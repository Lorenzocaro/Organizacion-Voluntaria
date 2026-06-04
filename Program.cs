using System;

/*Consigna: Desarrollar un sistema que permita administrar personas de una org voluntaria, 
debe existir voluntarios y coordinadores. 
Los voluntarios deberan mostrar la cantidad de horas trabajadas 
y los coordinadores las areas asignadas y la cantidad de personas a cargo. 
debemos usar obligatoriamente: herencia, polimorfismo, abstraccion modularidad y encapsulamiento git github.*/

class Program
{
    static void Main()
    {
        List<Voluntario> voluntarios = new List<Voluntario>();
        List<Coordinador> coordinadores = new List<Coordinador>();
        int eleccion;

        do
        {
            Console.WriteLine("Bienvenido al sistema, por favor ingrese una opcion: ");
            Console.WriteLine("1. Agregar Voluntario");
            Console.WriteLine("2. Agregar Coordinador");
            Console.WriteLine("3. Mostrar Voluntarios");
            Console.WriteLine("4. Mostrar Coordinadores");
            Console.WriteLine("5. Salir");
            eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    AgregarVoluntario(voluntarios);
                    break;
                case 2:
                    AgregarCoordinador(coordinadores);
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Por favor ingrese una opcion valida");
                    break;
            }
        } while (eleccion != 5);
    }

    static void AgregarVoluntario(List<Voluntario> voluntarios)
    {
        Console.WriteLine("Ingrese el nombre del voluntario");
        string nombreVoluntario = Console.ReadLine();
        Console.WriteLine("Ingrese el documento del voluntario");
        string documentoVoluntario = Console.ReadLine();
        Console.WriteLine("Ingrese las horas trabajadas del voluntario");
        int horasTrabajadas = int.Parse(Console.ReadLine());

        voluntarios.Add(new Voluntario(nombreVoluntario, documentoVoluntario, horasTrabajadas));
    }

    static void AgregarCoordinador(List<Coordinador> coordinadores)
    {
        Console.WriteLine("Ingrese el nombre del coordinador");
        string nombreCoordinador = Console.ReadLine();
        Console.WriteLine("Ingrese el documento del coordinador");
        string documentoCoordinador = Console.ReadLine();
        Console.WriteLine("Ingrese el área asignada del coordinador");
        string areaAsignada = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad de personas a cargo del coordinador");
        int personasACargo = int.Parse(Console.ReadLine());

        coordinadores.Add(new Coordinador(nombreCoordinador, documentoCoordinador, areaAsignada, personasACargo));
    }

}


