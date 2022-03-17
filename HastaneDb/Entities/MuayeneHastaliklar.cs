using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneDb.Entities
{
    [Table("MuayeneHastaliklar")]
    public    class MuayeneHastaliklar
    {
        [Key]
        [Column(Order = 0)]
      
        public int MuayenelerId { get; set; }
        public Muayeneler Muayeneler { get; set; }

        [Key]
        [Column(Order = 1)]
     
        public int HastaliklarId { get; set; }
        public Hastaliklar Hastaliklar { get; set; }

      


    }
}
