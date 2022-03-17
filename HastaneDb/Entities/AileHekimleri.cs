using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneDb.Entities
{
    [Table("AileHekimleri")]
    public class AileHekimleri : BaseEntity
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Tckn { get; set; }
        public string DiplomaNo { get; set; }
        public List<Hastalar> Hastalars { get; set; }
        public List<Muayeneler> Muayenelers { get; set; }


        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}
