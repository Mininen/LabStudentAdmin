using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Personal : Person
    {
        public int PersonalId { get; set; }

        public Personal(string namn, string email, string användarnamn, string lösenord) //Används inte
        {
            Namn = namn;
            Email = email;
            Användarnamn = användarnamn;
            Lösenord = lösenord;
        }

        public Personal()
        {
        }
    }
}
