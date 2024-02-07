using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ArgeProjeleri
    {
        public int ID { get; set; }
        public string TamamlanmaDurumu { get; set; }
        public int ProjeKodu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime ProjeBitisTarihi { get; set; }
        public float OzKaynaklar {  get; set; }
        public int ToplamButce {  get; set; }
        public int ProjeYurutucusuID { get; set; } // ayrı tablosu olmalı
        public string DestekDurumu { get; set; } //ayrı tabloda tut?
    }
}
