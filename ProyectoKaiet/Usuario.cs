using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoKaiet
{
    class Usuario
    {
        public string email { get; set; }
        public string telefono { get; set; }
        public string Titulo { get; set; }
        public string asunto { get; set; }

        public Usuario() { }
        public Usuario(string email, string telefono, string Titulo, string asunto)
        {
            this.email = email;
            this.telefono = telefono;
            this.Titulo = Titulo;
            this.asunto = asunto;
        }

    }
}
