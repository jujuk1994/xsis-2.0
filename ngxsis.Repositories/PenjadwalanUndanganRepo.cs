using ngxsis.Models;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repositories
{
    public class PenjadwalanUndanganRepo
    {
        public List<PenjadwalanUndanganViewModel> Search(string search)
        {
            List<PenjadwalanUndanganViewModel> result = new List<PenjadwalanUndanganViewModel>();
            using (var db = new DataContext())
            {
                result = db.x_undangan_detail
                    .Where(b => b.is_delete == false && (b.x_biodata.fullname.Contains(search)))

                    .Select(b => new PenjadwalanUndanganViewModel
                    { //linkq

                        id = b.id,
                        Fullname = b.x_biodata.fullname,
                        invitation_code = b.x_undangan.invitation_code,
                        invitation_date = b.x_undangan.invitation_date,
                        SchoolName = db.x_riwayat_pendidikan.Where(rp => rp.biodata_id == b.biodata_id && rp.is_delete == false)
                       .OrderByDescending(rp => rp.graduation_year)
                       .Select(rp => rp.school_name).FirstOrDefault(),
                        Major = db.x_riwayat_pendidikan.Where(rp => rp.biodata_id == b.biodata_id && rp.is_delete == false)
                       .OrderByDescending(rp => rp.graduation_year)
                       .Select(rp => rp.major)
                       .FirstOrDefault(),

                    }).ToList();
            }
            return result;
        }
    }
}