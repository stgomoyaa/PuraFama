using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuraFama.Models
{
    public class ElServicio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int proveedor { get; set; }
    }
}