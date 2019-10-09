using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.ViewModel
{
    public class PenjadwalanUndanganViewModel
    {
        public long id { get; set; }

        public long? schedule_type_id { get; set; }

        public DateTime? invitation_date { get; set; }

        public string invitation_code { get; set; }

        public string time { get; set; }
        public long? ro { get; set; }

        public long? tro { get; set; }

        public string other_ro_tro { get; set; }

        public string location { get; set; }

        public string status { get; set; }

        public long biodata_id { get; set; }
        public long user_id { get; set; }

        public string Fullname { get; set; }

        public string SchoolName { get; set; }

        public string Major { get; set; }


        public string schedule_type_name { get; set; }


        public string notes { get; set; }

        public string ro_name { get; set; }

        public string tro_name { get; set; }

        public string date_string { get; set; }
    }
}
