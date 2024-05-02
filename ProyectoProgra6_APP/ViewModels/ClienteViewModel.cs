using ProyectoProgra6_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.ViewModels
{
    public class ClienteViewModel : BaseViewModel
    {
        public ClientePost MyClienteToPost { get; set; }

        public ClienteViewModel() 
        {
            MyClienteToPost = new ClientePost();
        }
    }
}
