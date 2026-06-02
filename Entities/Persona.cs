public abstract class Persona
{
    private string nombre;
    
    private string documento;

    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string Documento { get { return documento; } set { documento = value; } }

    public Persona(string nombre, string documento)
    {
        this.Nombre = nombre;
        this.Documento = documento;
    }
    
}