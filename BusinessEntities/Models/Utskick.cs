using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Utskick : IUtskick
    {
        public int UtskickId { get; set; }
        public string Utskicksnamn { get; set; }
        public string Innehåll { get; set; }

        public virtual ICollection<Alumn> Alumns { get; set; }

        public Utskick(string utskicksNamn, string innehåll, List<Alumn> mottagare) //Används inte
        {
            Utskicksnamn = utskicksNamn;
            Innehåll = innehåll;
            Alumns = mottagare;
        }

        public Utskick()
        {
        }
    }
}
