using ProyectoProgra6_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.ViewModels
{
    public class CalifiacionViewModel : BaseViewModel
    {
        public CalificacionPost MyCalificacionPost { get; set; }

        public CalifiacionViewModel()
        {
            MyCalificacionPost = new CalificacionPost();
        }
    }
}