using System.Collections.Generic;
using  Data.Entity;

namespace MVCGenericRepositoryPettern.Models
{
    public class UserViewModel
    {
        public IList<Users> Userslist { get; set; }
        public Users Users { get; set; }
    }
}