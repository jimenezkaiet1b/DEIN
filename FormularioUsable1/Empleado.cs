using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioUsable1
{
    class Empleado
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }

        public Empleado() { }
        public Empleado(string nombre, string apellidos, string email, string telefono)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
        }


    }
}
