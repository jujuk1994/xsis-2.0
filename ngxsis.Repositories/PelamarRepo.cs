using ngxsis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repositories
{
    public class PelamarRepo
    {
        public DataContext db = new DataContext();
        public List<x_biodata> GetAll()
        {
            return db.x_biodata.ToList();
        }

        public List<x_biodata> Search(string search)
        {
            var result = db.x_biodata.Where(sr =>
                sr.fullname.Contains(search)).ToList();
            return result;
        }

        public List<x_biodata> OrderBy(string search)
        {
            var result = db.x_biodata
                        .Where(sr => sr.fullname.Contains(search))
                        .OrderBy(sr => sr.fullname).ToList();
            return result;
        }

        public List<x_biodata> OrderByDesc(string search)
        {
            var result = db.x_biodata
                        .Where(sr => sr.fullname.Contains(search))
                        .OrderByDescending(sr => sr.fullname).ToList();
            return result;
        }
    }
}
