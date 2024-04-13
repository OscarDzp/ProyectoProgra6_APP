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
        public UserPost MyUserToPost { get; set; }

        public UserRole MyUserRole { get; set; }

        public UserViewModel()
        {
            MyUserToPost = new UserPost();
            MyUserRole = new UserRole();
        }

        public async Task<List<UserRole>?> GetUserRolesAsync()

        {
            try
            {

                List<UserRole>? roles = new List<UserRole>();

                roles = await MyUserRole.GetAllUserRolesAsync();
                if (roles == null)
                {
                    return null;
                }
                return roles;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
