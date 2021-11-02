using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public abstract class Person : IPerson
    {
        public string Namn { get; set; }
        public string Email { get; set; }
        public string Användarnamn { get; set; }
        public string Lösenord { get; set; }
        public bool Inloggad { get; set; } 

        public Person() //Används inte
        {
            Inloggad = false;
        }
        
    }
}
