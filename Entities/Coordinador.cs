class Coodinador : Persona
{
    public Coordinador(string nombre, string documento) : base(nombre, documento)
    {
        
    }
    private string areaAsignada;
    private int personasACargo;
    public string AreaAsignada {get {return areaAsignada;} set {this.areaAsignada = value;}}
    public int PersonasACargo {get {return personasACargo;} set {this.personasACargo = value;}}
    public Coodinador(string areaAsignada, int personasACargo)
    {
        this.AreaAsignada = areaAsignada;
        this.PersonasACargo = personasACargo;
    }
}