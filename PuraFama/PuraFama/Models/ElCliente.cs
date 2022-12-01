using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuraFama.Models
{
    public class ElCliente
    {
        public int rut { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public int gastos { get; set; }
    }
}