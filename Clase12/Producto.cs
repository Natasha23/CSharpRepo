using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    internal class Producto
    {
        private long id;
        private string descripcion;
        private decimal costo;
        private decimal precioDeVenta;
        private int stock;
        private long idDeUsuario;
        public Producto(long id, string descripcion, decimal costo, decimal precioDeVenta, int stock, long idDeUsuario)
        {
            this.Id = id;
            this.Descripcion= descripcion;
            this.Costo = costo;
            this.PrecioDeVenta = precioDeVenta;
            this.Stock = stock;
            this.IdDeUsuario = idDeUsuario;
        }

        public long Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal PrecioDeVenta { get => precioDeVenta; set => precioDeVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdDeUsuario { get => idDeUsuario; set => idDeUsuario = value; }

        public override string ToString()
        {
            return $"{Id}.Descripcion: {Descripcion}, Costo: {Costo}, Precio de venta: {precioDeVenta}, Stock: {Stock}, Id de usuario: {idDeUsuario}";
        }
    }
}
