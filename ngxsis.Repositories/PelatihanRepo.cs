using ngxsis.Models;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repositories
{
    public class PelatihanRepo
    {
        //Get All
        public List<PelatihanViewModel> GetAllPelatihan()
        {
            List<PelatihanViewModel> result = new List<PelatihanViewModel>();
            using (var db = new DataContext())
            {
                result = (from a in db.x_riwayat_pelatihan
                          join b in db.x_time_period on a.time_period_id equals b.id

                          where a.is_delete == false
                          select new PelatihanViewModel
                          { //linkq

                              // Field x_riwayat_pelatihan a
                              id = a.id,
                              training_name = a.training_name,
                              organizer = a.organizer,
                              training_month = a.training_month,
                              training_year = a.training_year,
                              training_duration = a.training_duration,
                              time_period_id = a.time_period_id,
                              city = a.city,
                              country = a.country,
                              notes = a.notes,

                              //FIELD time period b
                              time_period_name = b.name,

                          }).ToList();
            }
            return result;
        }
        public bool Save(x_riwayat_pelatihan x_riwayat_pelatihan)
        {
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    dataContext.x_riwayat_pelatihan.Add(x_riwayat_pelatihan);
                    dataContext.SaveChanges();

                };
                return true;
            }
            //catch (Exception e)
            catch (Exception)
            {
                return false;

                //throw;
            }
        }

        public static bool SaveAddPelatihan(x_riwayat_pelatihan entity)
        {
            try
            {
                x_riwayat_pelatihan pelatihan = new x_riwayat_pelatihan();
                using (var db = new DataContext())
                {
                    pelatihan.created_by = 1;
                    pelatihan.created_on = DateTime.Now;
                    pelatihan.modified_by = 1;
                    pelatihan.modified_on = DateTime.Now;
                    pelatihan.deleted_by = 1;
                    pelatihan.deleted_on = DateTime.Now;
                    pelatihan.is_delete = false;
                    pelatihan.biodata_id = 1;

                    pelatihan.training_name = entity.training_name;
                    pelatihan.organizer = entity.organizer;
                    pelatihan.training_year = entity.training_year;
                    pelatihan.training_month = entity.training_month;
                    pelatihan.training_duration = entity.training_duration;
                    pelatihan.time_period_id = entity.time_period_id;
                    pelatihan.city = entity.city;
                    pelatihan.country = entity.country;
                    pelatihan.notes = entity.notes;
                    db.x_riwayat_pelatihan.Add(pelatihan);
                    db.SaveChanges();
                }

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool SaveEdit(x_riwayat_pelatihan pelatihan)
        {
            try
            {
                List<PelatihanViewModel> result = new List<PelatihanViewModel>();
                using (var db = new DataContext())
                {
                    db.Entry(pelatihan).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
                //throw;
            }
        }

        public static bool Delete(x_riwayat_pelatihan pelatihan)
        {
            try
            {
                List<PelatihanViewModel> result = new List<PelatihanViewModel>();
                using (var db = new DataContext())
                {
                    db.Entry(pelatihan).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
    }
}
