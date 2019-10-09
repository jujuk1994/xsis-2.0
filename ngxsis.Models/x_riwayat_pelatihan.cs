using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Models
{
    [Table("x_riwayat_pelatihan")]
    public class x_riwayat_pelatihan
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
        public string training_name { get; set; }
        public string organizer { get; set; }
        public string training_year { get; set; }
        public string training_month { get; set; }
        public int training_duration { get; set; }
        public long? time_period_id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string notes { get; set; }
    }
}
