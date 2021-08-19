using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Models
{
    public class Nota
    {
        public int idNota { get; set; }
        public string titulo { get; set; }
        public DateTime fechaMod { get; set; }
        public string contenido { get; set; }


    }
}
