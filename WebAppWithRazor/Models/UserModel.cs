using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithRazor.Models
{
    public class UserModel
    {       
        public int Id { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string Office { get; set; }

        public int Age { get; set; }

        public DateTime StartDate { get; set; }

        public float Salary { get; set; }
    }

    public class UserCriteria
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public string Office { get; set; }

        public string Salary { get; set; }
    }

    public class UserViewModel
    {
        public UserModel Model { get; set; } = new UserModel();

        public UserCriteria Criteria { get; set; } = new UserCriteria();

        public ICollection<UserModel> Collection { get; set; } = new Collection<UserModel>();
    }
}
