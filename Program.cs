using System;

/*Consigna: Desarrollar un sistema que permita administrar personas de una org voluntaria, 
debe existir voluntarios y coordinadores. 
Los voluntarios deberan mostrar la cantidad de horas trabajadas 
y los coordinadores las areas asignadas y la cantidad de personas a cargo. 
debemos usar obligatoriamente: herencia, polimorfismo, abstraccion modularidad y encapsulamiento git github.*/

class Program
{
    static List<Voluntario> voluntarios = new List<Voluntario>();
    static List<Coordinador> coordinadores = new List<Coordinador>();
    static List<Persona> personas = new List<Persona>();
    static void Main()
    {
        int eleccion;

        do
        {
            Console.WriteLine("Bienvenido al sistema, por favor ingrese una opcion: ");
            Console.WriteLine("");
            Console.WriteLine("1. Agregar Voluntario");
            Console.WriteLine("2. Agregar Coordinador");
            Console.WriteLine("3. Mostrar Voluntarios");
            Console.WriteLine("4. Mostrar Coordinadores");
            Console.WriteLine("5. Salir");
            eleccion = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (eleccion)
            {
                case 1:
                    AgregarVoluntario(voluntarios);
                    break;

                case 2:
                    AgregarCoordinador(coordinadores);
                    break;

                case 3:
                    MostrarVoluntarios();
                    break;

                case 4:
                    MostrarCoordinadores();
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
        Console.WriteLine("");
        Console.WriteLine("Ingrese el documento del voluntario");
        string documentoVoluntario = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese las horas trabajadas del voluntario");
        int horasTrabajadas = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        Voluntario persona = new Voluntario(nombreVoluntario, documentoVoluntario, horasTrabajadas);
        voluntarios.Add(persona);
        personas.Add(persona);
    }
    static void AgregarCoordinador(List<Coordinador> coordinadores)
    {
        Console.WriteLine("Ingrese el nombre del coordinador");
        string nombreCoordinador = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Ingrese el documento del coordinador");
        string documentoCoordinador = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Ingrese el área asignada del coordinador");
        string areaAsignada = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Ingrese la cantidad de personas a cargo del coordinador");
        int personasACargo = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        Coordinador persona = new Coordinador(nombreCoordinador, documentoCoordinador, areaAsignada, personasACargo);
        coordinadores.Add(persona);
        personas.Add(persona);
    }
    static void MostrarVoluntarios()
    {
        if(personas.Count == 0)
        {
            Console.WriteLine("Debes ingresar voluntarios primero.");
            Console.WriteLine("");
            return;
        }

        Console.WriteLine("--- Voluntarios ---");
        Console.WriteLine("");

        foreach(Persona p in voluntarios)
        {
            p.MostrarInfo();
        }
    }
    static void MostrarCoordinadores()
    {
        if(personas.Count == 0)
        {
            Console.WriteLine("Debes ingresar coordinadores primero.");
            Console.WriteLine("");
            return;
        }

        Console.WriteLine("--- Coordinadores ---");
        Console.WriteLine("");

        foreach(Persona p in coordinadores)
        {
            p.MostrarInfo();
        }
    }
}


