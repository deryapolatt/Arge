using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ArgePersoneliDisaridaGecirilenSureler
    {
        public int Id { get; set; }
        public string ProjeAdi {  get; set; }
        public string Personel {  get; set; } // ayrı bir personel tablon olmalı
        public DateTime CikisTarihi { get; set; }
        public string Yer {  get; set; }
        public string GorevAdi { get; set; }

    }
}
