using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjeDenemeIstegi
    {
        public int ID { get; set; }
        public int  ProjeKodu { get; set; }
        public DateOnly Tarih { get; set; }
        public string Katkı { get; set; }
    
        public string KesitTipi { get; set; }
        public string Chips { get; set; }
        public int Dozaj { get; set; } //ONEMLİ FLOAT MI OLACAK INT Mİ
        public string PoyDtex { get; set; }
        public int PoyMiktar { get; set; }
        public string PoyReferans { get; set; }
    
    
    
    }
}
