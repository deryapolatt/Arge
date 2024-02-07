using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjeSorumlusu
    {
        public int ID { get; set; }
        public string ProjeKonusu { get; set; }
        public string Aciklama { get; set; }
        public DateOnly Tarih { get; set; }
        public string Numuneler { get; set; }
        public string Projesorumlusu { get; set; }
    }
}
