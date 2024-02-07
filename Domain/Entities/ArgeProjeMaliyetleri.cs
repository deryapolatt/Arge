using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ArgeProjeMaliyetleri
    {
        public int Id { get; set; }
        public string Firma { get; set; }
        public float KDVTutar { get; set; }
        public float NoKDVTutar { get; set; }
        public string ParaBirimi { get; set; }// istersen ayrı tabloda tut getir
        public string MaliyetTipi { get; set; }
        public int ProjeID { get; set; }// buradan adını götüreceksin projenin
        public string Aciklama { get; set; }
    }
}
