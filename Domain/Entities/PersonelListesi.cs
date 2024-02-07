using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonelListesi
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string AdSoyad {  get; set; }
        public string Mail { get; set; }
        public string Durum { get; set; } // rol tanımı araştırmacı vs
    }
}
