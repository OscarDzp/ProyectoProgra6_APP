using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoProgra6_APP.Models;

namespace ProyectoProgra6_APP.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public UserPost MyUserToPost {  get; set; }

        public UserViewModel() 
        {
        MyUserToPost = new UserPost();
        }


    }
}
