using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //navigation property (another type of association) - associated to Make

        public Make Make { get; set; }

        //follow naming convention, name of parent class and it's id,
        //Entity framwork will know that Make and MakeId refering to same, so it will not create extra column

        public int MakeId { get; set; }

        //if we are not doing this way then we have to exlicitly mention using attribute
        //[ForeignKey("Make")]
        //public int MakeFK { get; set; }
    }
}
