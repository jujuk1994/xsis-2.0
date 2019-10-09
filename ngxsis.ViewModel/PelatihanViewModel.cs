using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.ViewModel
{
    public class PelatihanViewModel
    {
        //FIELD riwayat Proyek
        public long id { get; set; }
        public string training_name { get; set; }
        public string organizer { get; set; }
        public string training_year { get; set; }
        public string training_month { get; set; }
        public Nullable<int> training_duration { get; set; }
        public Nullable<long> time_period_id { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string notes { get; set; }

        //FIELD time period
        public string time_period_name { get; set; }
    }
}
