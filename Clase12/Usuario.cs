using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    internal class Usuario
    {
        private long id;
        private string nombre;
        private string apellido;
        private string nombreDeUsuario;
        private string contraseña;
        private string mail;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Mail { get => mail; set => mail = value; }

        public Usuario(long id, string nombre, string apellido, string nombreDeUsuario, string contraseña, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreDeUsuario = nombreDeUsuario;
            this.contraseña = contraseña;
            this.mail = mail;
        }

        public override string ToString()
        {
            return $"{Id}.Nombre: {Nombre}, Apellido: {Apellido}, NombreDeUsuario:{NombreDeUsuario}, Mail: {Mail}";
        }
    }
}
