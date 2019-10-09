using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.ViewModel
{
    public class CatatanViewModel
    {
        //=============Dari tabel x_catatan====================//
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [StringLength(100)]
        public string title { get; set; }
        public long note_type_id { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public long biodata_id { get; set; }

        [StringLength(1000)]
        public string notes { get; set; }

        //==========dari table note_type=====================//
        [Required]
        [StringLength(50)]
        public string type_notes { get; set; }
    }
}
