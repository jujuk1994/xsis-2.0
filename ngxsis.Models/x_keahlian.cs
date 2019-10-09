using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Models
{
    [Table("x_keahlian")]
    public class x_keahlian
    {
        
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long id { get; set; }

            public long created_by { get; set; }

            public DateTime created_on { get; set; }

            public long? modified_by { get; set; }

            public DateTime? modified_on { get; set; }

            public long? deleted_by { get; set; }

            public DateTime? deleted_on { get; set; }

            public bool is_delete { get; set; }

            public long biodata_id { get; set; }

            [StringLength(100)]
            public string skill_name { get; set; }

            public long? skill_level_id { get; set; }

            [StringLength(1000)]
            public string notes { get; set; }

            //public virtual x_biodata x_biodata { get; set; }

            //public virtual x_skill_level x_skill_level { get; set; }
        
    }
}
