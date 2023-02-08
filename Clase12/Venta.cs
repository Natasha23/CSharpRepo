using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class Venta
    {
        private long id;
        private string comentarios;
        private long idUsuario;
        public Venta(long id, string comentarios, long idDeUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idDeUsuario;
        }

        public long Id { get => id; set => id = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }

        public override string ToString()
        {
            return $"{Id}.Comentarios: {Comentarios}, IdUsuario: {IdUsuario}";
        }
    }
}
