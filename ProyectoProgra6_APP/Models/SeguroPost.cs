using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.Models
{
    public class SeguroPost
    {
        public string? CompaniaSeguros { get; set; }

        public string? TipoCobertura { get; set; }

        public DateOnly? FechaInicio { get; set; }

        public DateOnly? FechaVencimiento { get; set; }
    }
}
