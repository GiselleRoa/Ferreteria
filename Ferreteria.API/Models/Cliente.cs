using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.API.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string rut { get; set; }
        public string direccion { get; set; }
    }
}
