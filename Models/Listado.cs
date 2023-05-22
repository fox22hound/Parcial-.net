using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Parcial2.Models
{
    public class Listado
    {
        public string CondIva { get; set; }
        public UInt64 Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string CondVenta { get; set; }



    }
}

