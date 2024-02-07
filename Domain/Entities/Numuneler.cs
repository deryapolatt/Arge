using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Numuneler
    {
        public int ID { get; set; }
        public string NumuneAdi { get; set; }
        public  string MusteriFirma { get; set; }
        public DateOnly HatilatmaTarihi { get; set; }
        public string PartiKodu { get; set; }
        public int Miktar { get; set; }
        public string IlgiliKisi { get; set; } // ONEMLİ İLGİLİKİŞİPERSONEL LİSTESİNDEN Mİ GELİYOR 
        public string Iletisim { get; set; }
    }
}
