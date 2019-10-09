using ngxsis.Models;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repositories
{
    public class CatatanRepo
    {
        public List<CatatanViewModel> GetAll()
        {
            List<CatatanViewModel> result = new List<CatatanViewModel>();
            using (var db = new DataContext())
            {
                result = (from a in db.x_catatan
                          join b in db.x_note_type
                          on a.note_type_id equals b.id
                          join c in db.x_biodata
                          on a.biodata_id equals c.id
                          where a.is_delete == false
                          select new
                          {
                              id = a.id,
                              title = a.title,
                              note_type_id = a.note_type_id,
                              type_notes = b.name,
                              created_by = c.nick_name,
                              created_on = a.created_on,
                              biodata_id = a.biodata_id,
                              notes = a.notes

                          }).ToList().Select(outdata => new CatatanViewModel
                          {
                              id = outdata.id,
                              title = outdata.title,
                              note_type_id = outdata.note_type_id,
                              type_notes = outdata.type_notes,
                              created_by = outdata.created_by,
                              created_on = outdata.created_on,
                              biodata_id = outdata.biodata_id,
                              notes = outdata.notes,

                          }).ToList();
            }
            return result;
        }

        public bool SaveCatatan(x_catatan entity)
        {

            try
            {
                x_catatan catatan = new x_catatan();
                using (var db = new DataContext())
                {

                    catatan.created_by = 1;
                    catatan.created_on = DateTime.Now;
                    catatan.modified_by = 2;
                    catatan.modified_on = DateTime.Now;
                    catatan.deleted_by = 3;
                    catatan.deleted_on = DateTime.Now;
                    catatan.is_delete = false;
                    catatan.biodata_id = 1;
                    catatan.title = entity.title;
                    catatan.note_type_id = entity.note_type_id;
                    catatan.notes = entity.notes;

                    db.x_catatan.Add(catatan);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveEditCatatan(x_catatan editCatatan)
        {
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    dataContext.Entry(editCatatan).State = System.Data.Entity.EntityState.Modified;
                    dataContext.SaveChanges();

                };
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }
        public bool DeleteEditCatatan(x_catatan deleteCatatan)
        {
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    dataContext.Entry(deleteCatatan).State = System.Data.Entity.EntityState.Modified;
                    dataContext.SaveChanges();

                };
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }
    }
}