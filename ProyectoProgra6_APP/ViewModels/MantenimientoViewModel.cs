using ProyectoProgra6_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.ViewModels
{
    public class MantenimientoViewModel : BaseViewModel
    {
        public MantenimientoPost MyMantenimientoPost { get; set; }

        public MantenimientoViewModel()
        {
            MyMantenimientoPost = new MantenimientoPost();
        }
    }
}