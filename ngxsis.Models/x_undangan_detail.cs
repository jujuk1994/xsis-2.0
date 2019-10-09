﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Models
{
    [Table("x_undangan_detail")]
    public class x_undangan_detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        public long create_by { get; set; }

        public DateTime create_on { get; set; }

        public long? modified_by { get; set; }

        public DateTime? modified_on { get; set; }

        public long? delete_by { get; set; }

        public DateTime? delete_on { get; set; }

        public bool is_delete { get; set; }

        public long undangan_id { get; set; }

        public long biodata_id { get; set; }

        [StringLength(1000)]
        public string notes { get; set; }

        public virtual x_biodata x_biodata { get; set; }

        public virtual x_undangan x_undangan { get; set; }
    }
}