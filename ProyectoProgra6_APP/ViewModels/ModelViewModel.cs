using ProyectoProgra6_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.ViewModels
{
    internal class ModelViewModel :BaseViewModel
    {

        public ModeloPost MyModelToPost { get; set; }



        public ModelViewModel() 
        {
            MyModelToPost = new ModeloPost();
        
        } 

    }
}
