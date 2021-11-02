using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IAktivitet
    {
        int AktivitetId { get; set; }
        string Aktivitetsnamn { get; set; }
        ICollection<Alumn> Alumns { get; set; }
        string Beskrivning { get; set; }
    }
}