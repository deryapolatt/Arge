using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GuncelBilgiYonetimi
    {
        public int ID { get; set; }
        public DateOnly Tarih { get; set; }
        public int ProjeKodu { get; set; }
        public string ProjeAdi { get; set; }
        public string ProjeGuncellemeDetayları { get; set; }
    }
}
