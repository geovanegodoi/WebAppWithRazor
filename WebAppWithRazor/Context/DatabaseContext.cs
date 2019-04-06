using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppWithRazor.Models;

namespace WebAppWithRazor.Context
{
    public class DatabaseContext
    {
        public IEnumerable<UserModel> Users { get; }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }

        private DatabaseContext()
        {
            this.Users = SeedUsers();
        }

        private IEnumerable<UserModel> SeedUsers()
        {
            return new HashSet<UserModel>
            {
                new UserModel { Id = 1, Name = "Tiger Nixon"    , Position = "System Architect"           , Office = "Tokyo"        , Age = 33, StartDate = new DateTime(2009, 11, 01), Salary = 162.800f },
                new UserModel { Id = 2, Name = "Garrett Winters", Position = "Senior Javascript Developer", Office = "London"       , Age = 47, StartDate = new DateTime(2010, 08, 12), Salary = 320.800f },
                new UserModel { Id = 3, Name = "Ashton Cox"     , Position = "Software Engineer"          , Office = "San Francisco", Age = 66, StartDate = new DateTime(2011, 06, 23), Salary = 86.800f },
                new UserModel { Id = 4, Name = "Tiger Nixon"    , Position = "Support Lead"               , Office = "London"       , Age = 41, StartDate = new DateTime(2012, 04, 18), Salary = 206.800f },
                new UserModel { Id = 5, Name = "Dai Rios"       , Position = "Personnel Lead"             , Office = "Edinburgh"    , Age = 28, StartDate = new DateTime(2013, 02, 07), Salary = 433.800f },
            };
        }
    }
}
