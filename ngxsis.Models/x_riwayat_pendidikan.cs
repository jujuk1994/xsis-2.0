using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ngxsis.Models
{
    [Table("x_riwayat_pendidikan")]
    public class x_riwayat_pendidikan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public long create_by { get; set; }
        public DateTime create_on { get; set; }
        public long? modified_by { get; set; }
        public DateTime? modified_on { get; set; }
        public long? delete_by { get; set; }
        public DateTime? delete_on { get; set; }
        public bool? is_delete { get; set; }
        public long biodata_id { get; set; }
        public string school_name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public long education_level_id { get; set; }
        public string entry_year { get; set; }
        public string graduation_year { get; set; }
        public string major { get; set; }
        public double? gpa { get; set; }
        public string notes { get; set; }
        public int? order { get; set; }
        public string judul_ta { get; set; }
        public string deskripsi_ta { get; set; }
    }
}
