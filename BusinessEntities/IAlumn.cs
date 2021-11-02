using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IAlumn
    {
        ICollection<Aktivitet> Aktiviter { get; set; }
        int AlumnId { get; set; }
        string Program { get; set; }
        ICollection<Utskick> Utskicks { get; set; }
    }
}