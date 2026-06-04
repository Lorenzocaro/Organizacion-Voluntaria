public class Coordinador : Persona
{
    private string areaAsignada;
    private int personasACargo;
    public string AreaAsignada {get {return areaAsignada;} set {this.areaAsignada = value;}}
    public int PersonasACargo {get {return personasACargo;} set {this.personasACargo = value;}}
    
    public Coordinador(string nombre, string documento, string areaAsignada, int personasACargo) : base(nombre, documento)
    {
        this.AreaAsignada = areaAsignada;
        this.PersonasACargo = personasACargo;
    }
    public override void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"DNI: {Documento}");
        Console.WriteLine($"Areas asignadas: {AreaAsignada}");
        Console.WriteLine($"Personas a cargo: {PersonasACargo}");
        Console.WriteLine("");
    }
}