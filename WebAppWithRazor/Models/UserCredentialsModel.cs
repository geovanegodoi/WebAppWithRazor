using System;
namespace WebAppWithRazor.Models
{
    public class UserCredentialsModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
