using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneDb.Entities
{
    [Table("Muayeneler")]
    public  class Muayeneler:BaseEntity
    {
        public DateTime MuayeneTarihi { get; set; }

        public List<MuayeneHastaliklar> MuayeneHastaliklars { get; set; }
        public Hastalar Hastalar { get; set; }
        public int? HastalarId { get; set; }
        public AileHekimleri AileHekimleri { get; set; }
        public int AileHekimleriId { get; set; }

    }
}
