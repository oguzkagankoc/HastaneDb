using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneDb.Entities
{
    [Table("Hastaliklar")]
    public class Hastaliklar : BaseEntity
    {

        public string HastalikAdi { get; set; }
        public string ICD10 { get; set; }
        public List<MuayeneHastaliklar> MuayeneHastaliklars { get; set; }

        public override string ToString()
        {
            return HastalikAdi; 
        }

    }
}
