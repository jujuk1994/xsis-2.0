using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=ngxsisConn")
        {
            Database.SetInitializer<DataContext>(null);
        }

        public virtual DbSet<x_keahlian> x_keahlian { get; set; }
        public virtual DbSet<x_biodata> x_biodata { get; set; }
        public virtual DbSet<x_keluarga> x_keluarga { get; set; }
        public virtual DbSet<x_riwayat_pendidikan> x_riwayat_pendidikan { get; set; }
        public virtual DbSet<x_education_level> x_education_level { get; set; }
        public virtual DbSet<x_riwayat_pelatihan> x_riwayat_pelatihan { get; set; }
        public virtual DbSet<x_time_period> x_time_period { get; set; }
        public virtual DbSet<x_rencana_jadwal> x_rencana_jadwal { get; set; }
        public virtual DbSet<x_rencana_jadwal_detail> x_rencana_jadwal_detail { get; set; }
        public virtual DbSet<x_undangan> x_undangan { get; set; }
        public virtual DbSet<x_undangan_detail> x_undangan_detail { get; set; }
        public virtual DbSet<x_schedule_type> x_schedule_type { get; set; }
        public virtual DbSet<x_address> x_address { get; set; }
        public virtual DbSet<x_religion> x_Religion { get; set; }
        public virtual DbSet<x_identity_type> x_identity_type { set; get; }
        public virtual DbSet<x_marital_status> x_marital_status { set; get; }
        public virtual DbSet<x_catatan> x_catatan { get; set; }
        public virtual DbSet<x_note_type> x_note_type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }   
    }
}
