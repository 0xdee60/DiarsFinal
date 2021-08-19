using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Models
{
    public class EtiquetaNota
    {
        public int idEtiquetaNota { get; set; }
        public int idNota { get; set; }
        public int idEtiqueta { get; set; }

        public Etiqueta etiqueta { get; set; }
        public Nota nota { get; set; }
    }
}
