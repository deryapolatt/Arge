using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjeDenemeleri
    {
        public int ID { get; set; }
        public string DenemeAdi { get; set; }
        public DateOnly Tarih { get; set; }
        public string ProjeKodu { get; set; }
        public string PoyFdyLot { get; set; }// ONEMLİ
        public string TekstureLot { get; set; }
        public string BükümLot { get; set; }
        public string HavaTekstureLot { get; set; }
    }
}
