using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Alumn : Person, IAlumn
    {
        public int AlumnId { get; set; }
        public string Program { get; set; }

        public virtual ICollection<Aktivitet> Aktiviter { get; set; }
        public virtual ICollection<Utskick> Utskicks { get; set; }

        public Alumn(string program, string namn, string email, string användarnamn, string lösenord) //Används inte
        {
            Program = program;
            Namn = namn;
            Email = email;
            Användarnamn = användarnamn;
            Lösenord = lösenord;
        }

        public Alumn()
        {
            Aktiviter = new List<Aktivitet>();
            Utskicks = new List<Utskick>();
        }
    }
}
