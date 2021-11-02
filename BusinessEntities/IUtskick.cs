using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IUtskick
    {
        ICollection<Alumn> Alumns { get; set; }
        string Innehåll { get; set; }
        int UtskickId { get; set; }
        string Utskicksnamn { get; set; }
    }
}