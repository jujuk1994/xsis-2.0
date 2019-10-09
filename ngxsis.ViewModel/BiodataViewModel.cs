using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.ViewModel
{
    public class BiodataViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        public long created_by { get; set; }

        public DateTime created_on { get; set; }

        public long? modified_by { get; set; }

        public DateTime? modified_on { get; set; }

        public long? deleted_by { get; set; }

        public DateTime? deleted_on { get; set; }

        public bool is_deleted { get; set; }

        [Required]
        [StringLength(255)]
        public string fullname { get; set; }

        [Required]
        [StringLength(100)]
        public string nick_name { get; set; }

        [Required]
        [StringLength(100)]
        public string pob { get; set; }

        [Column(TypeName = "date")]
        public DateTime dob { get; set; }

        public bool gender { get; set; }

        public long religion_id { get; set; }

        public int? high { get; set; }

        public int? weight { get; set; }

        [StringLength(100)]
        public string nationality { get; set; }

        [StringLength(50)]
        public string ethnic { get; set; }

        [StringLength(25)]
        public string hobby { get; set; }

        public long identity_type_id { get; set; }

        [Required]
        [StringLength(50)]
        public string identity_no { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number1 { get; set; }

        [StringLength(50)]
        public string phone_number2 { get; set; }

        [Required]
        [StringLength(50)]
        public string parent_phone_number { get; set; }

        [StringLength(5)]
        public string child_sequence { get; set; }

        [StringLength(5)]
        public string how_many_brothers { get; set; }

        public long marital_status_id { get; set; }

        public long? addrbook_id { get; set; }

        [StringLength(10)]
        public string token { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expired_token { get; set; }

        [StringLength(50)]
        public string marriage_year { get; set; }

        public long company_id { get; set; }

        public bool? is_process { get; set; }

        public bool? is_complete { get; set; }

        public long id_religion { get; set; }
        public long id_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string religion_name { get; set; }

        public long id_identity { get; set; }
        [Required]
        [StringLength(50)]
        public string identity_name { get; set; }

        [Required]
        [StringLength(50)]
        public string mariage_status { get; set; }
        [StringLength(1000)]
        public string address1 { get; set; }

        [StringLength(20)]
        public string postal_code1 { get; set; }

        [StringLength(5)]
        public string rt1 { get; set; }

        [StringLength(5)]
        public string rw1 { get; set; }

        [StringLength(100)]
        public string kelurahan1 { get; set; }

        [StringLength(100)]
        public string kecamatan1 { get; set; }

        [StringLength(100)]
        public string region1 { get; set; }

        [StringLength(1000)]
        public string address2 { get; set; }

        [StringLength(20)]
        public string postal_code2 { get; set; }

        [StringLength(5)]
        public string rt2 { get; set; }

        [StringLength(5)]
        public string rw2 { get; set; }

        [StringLength(100)]
        public string kelurahan2 { get; set; }

        [StringLength(100)]
        public string kecamatan2 { get; set; }

        [StringLength(100)]
        public string region2 { get; set; }
        public long biodata_id { get; set; }

    }

}
