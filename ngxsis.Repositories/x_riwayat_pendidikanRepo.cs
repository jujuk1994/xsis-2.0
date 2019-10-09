using ngxsis.Models;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repositories
{
    public class x_riwayat_pendidikanRepo
    {
        public DataContext db = new DataContext();
        public List<PendidikanViewModel> GetAll()
        {
            List<x_riwayat_pendidikan> result = new List<x_riwayat_pendidikan>();
            List<x_education_level> resultEductionLevel = new List<x_education_level>();
            List<x_biodata> resultBiodata = new List<x_biodata>();
            List<PendidikanViewModel> resultComplete = new List<PendidikanViewModel>();

            long idEductionLevel = 0;
            long idBiodata = 0;
            var namaEduction = "";
            result = db.x_riwayat_pendidikan.ToList();
            resultEductionLevel = db.x_education_level.ToList();
            resultBiodata = db.x_biodata.ToList();

            foreach (var item in result)
            {
                idEductionLevel = item.education_level_id;
                idBiodata = item.biodata_id;
                foreach (var itemEducation in resultEductionLevel)
                {
                    namaEduction = resultEductionLevel.Find(b => b.id == idEductionLevel).name;
                    if (itemEducation.id == idEductionLevel)
                    {
                        if (item.is_delete == false)
                        {
                            PendidikanViewModel resultKomplit = new PendidikanViewModel();
                            resultKomplit.id = item.id;
                            resultKomplit.biodata_id = item.biodata_id;
                            resultKomplit.education_level_id = item.education_level_id;
                            resultKomplit.school_name = item.school_name;
                            resultKomplit.city = item.city;
                            resultKomplit.country = item.country;
                            resultKomplit.educationName = namaEduction;
                            resultKomplit.entry_year = item.entry_year;
                            resultKomplit.graduation_year = item.graduation_year;
                            resultKomplit.major = item.major;
                            resultKomplit.notes = item.notes;
                            resultKomplit.gpa = item.gpa;
                            resultKomplit.is_delete = item.is_delete;
                            resultKomplit.create_by = item.create_by;
                            resultKomplit.create_on = item.create_on;
                            //resultKomplit.user_id = item.user_id;

                            resultComplete.Add(resultKomplit);
                        }
                    }
                }
            }
            return resultComplete;
        }
        public bool Save(x_riwayat_pendidikan x_riwayat_pendidikan)
        {
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    dataContext.x_riwayat_pendidikan.Add(x_riwayat_pendidikan);
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
        public bool SaveEdit(x_riwayat_pendidikan x_riwayat_pendidikan)
        {
            try
            {
                using (DataContext datacontext = new DataContext())
                {
                    datacontext.Entry(x_riwayat_pendidikan).State = System.Data.Entity.EntityState.Modified;
                    datacontext.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
                //throw;
            }
        }

        public bool Delete(x_riwayat_pendidikan x_riwayat_pendidikan)
        {
            try
            {
                using (DataContext datacontext = new DataContext())
                {
                    datacontext.Entry(x_riwayat_pendidikan).State = System.Data.Entity.EntityState.Modified;
                    datacontext.SaveChanges();
                }
                return true;

            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }
        public bool delete2(isDeletedOrNOt getForDelete)
        {
            List<x_riwayat_pendidikan> riwayat = new List<x_riwayat_pendidikan>();
            x_riwayat_pendidikan kosong = new x_riwayat_pendidikan();
            try
            {
                riwayat = db.x_riwayat_pendidikan.ToList();
                using (DataContext context = new DataContext())
                {
                    foreach (var item in riwayat)
                    {
                        if (item.id == getForDelete.id)
                        {
                            kosong.id = item.id;
                            kosong.is_delete = getForDelete.is_delete;
                            kosong.create_by = item.create_by;
                            kosong.create_on = item.create_on;
                            kosong.modified_by = item.modified_by;
                            kosong.modified_on = item.modified_on;
                            kosong.delete_by = item.delete_by;
                            kosong.delete_on = item.delete_on;
                            kosong.biodata_id = item.biodata_id;
                            kosong.school_name = item.school_name;
                            kosong.city = item.city;
                            kosong.country = item.country;
                            kosong.education_level_id = item.education_level_id;
                            kosong.entry_year = item.entry_year;
                            kosong.graduation_year = item.graduation_year;
                            kosong.major = item.major;
                            kosong.gpa = item.gpa;
                            kosong.notes = item.notes;
                            kosong.order = item.order;
                            kosong.judul_ta = item.judul_ta;
                            kosong.deskripsi_ta = item.deskripsi_ta;
                            context.Entry(kosong).State = System.Data.Entity.EntityState.Modified;
                            context.SaveChanges();
                        }
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
    public class isDeletedOrNOt
    {
        public long id { get; set; }
        public bool? is_delete { get; set; }
    }
}