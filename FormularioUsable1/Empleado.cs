public class Empleado
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Empleado(string nombre, string apellidos, string email, string telefono)
    {
        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Telefono = telefono;
    }
}

