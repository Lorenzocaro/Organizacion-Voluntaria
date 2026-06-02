public class Voluntario : Persona
{
    private int horasTrabajadas;

    public int HorasTrabajadas { get { return horasTrabajadas; } set { horasTrabajadas = value; } }
    public Voluntario(string nombre, string documento, int horasTrabajadas) : base(nombre, documento)
    {
        this.HorasTrabajadas = horasTrabajadas;
    }
}