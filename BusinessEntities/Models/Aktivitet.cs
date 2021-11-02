using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Aktivitet : IAktivitet
    {
        private Aktivitet aktivitet;

        public int AktivitetId { get; set; }
        public string Aktivitetsnamn { get; set; }
        public string Beskrivning { get; set; }

        public virtual ICollection<Alumn> Alumns { get; set; }

        public Aktivitet(string aktivitetsnamn, string beskrivning) //Används inte
        {
            this.Aktivitetsnamn = aktivitetsnamn;
            this.Beskrivning = beskrivning;
        }

        public Aktivitet()
        {

        }


       
    }
}
