using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneDb.Entities
{
    [Table("Hastalar")]
    public   class Hastalar : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tckn { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }
        public List<Muayeneler> Muayenelers { get; set; }
        [ForeignKey("AileHekimleri")]
        public int AileHekimleriId{ get; set; }
        public AileHekimleri AileHekimleri { get; set; }
        public override string ToString()
        {
            return Name + ' ' + Surname ;
        }
    }
}
