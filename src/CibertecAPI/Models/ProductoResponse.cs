using Cibertec.Models;
using System.Collections.Generic;

namespace CibertecAPI.Models
{
    public class ProductoResponse
    {
        public IEnumerable<Producto> Items { get; set; }
    }
}
