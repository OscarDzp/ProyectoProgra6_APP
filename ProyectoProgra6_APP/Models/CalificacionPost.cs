using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.Models
{
    public class CalificacionPost
    {
        public string? Calificacion { get; set; }

        public string? Comentario { get; set; }

        public string? FechaCalificacion { get; set; }

        public string? UsuarioRealizóCalificación { get; set; }

        public int VehiculoId { get; set; }
    }
}
