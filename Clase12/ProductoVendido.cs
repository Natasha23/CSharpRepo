using Clase12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega
{
    internal class ProductoVendido
    {
        private long id;
        private int stock;
        private long idProducto;
        private long idVenta;

        public ProductoVendido(long id, int stock, long idProducto, long idVenta)
        {
            this.Id = id;
            this.Stock = stock;
            this.IdProducto = idProducto;
            this.IdVenta = idVenta;
        }

        public long Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public long IdVenta { get => idVenta; set => idVenta = value; }

        public override string ToString()
        {
            return $"{Id}.Stock: {Stock}, IdProducto: {IdProducto}, IdVenta: {IdVenta}";
        }
    }
}
