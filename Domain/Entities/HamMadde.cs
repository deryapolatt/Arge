using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HamMadde
    {
        public int Id { get; set; }
        public string Tedarikçi { get; set; } // ayrı tabloda tutsan mı?
        public string KatkiAdi { get; set; }
        public DateTime Tarih {  get; set; }
        public int ArGeStok { get; set; }
        public int İsletmeStok { get; set; }
        public int Dozaj {  get; set; }
        public float Fiyat {  get; set; }
        public int ParaBirimiID { get; set; }// fakrlşı tablo olabilir
        public int KullanımDurumuID { get; set; }//  farklı tablo olabilir

    }
}
