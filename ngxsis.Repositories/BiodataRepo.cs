using ngxsis.Models;
using ngxsis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repositories
{
    public class BiodataRepo
    {
        public List<BiodataViewModel> GetAll()
        {
            //berhubungan dengan model dan data context
            List<x_biodata> result = new List<x_biodata>();
            List<x_religion> resultReligion = new List<x_religion>();
            List<x_identity_type> resultIdentity = new List<x_identity_type>();
            List<x_marital_status> resultMariage = new List<x_marital_status>();
            List<x_address> resultAddress = new List<x_address>();
            List<BiodataViewModel> resultComplete = new List<BiodataViewModel>();

            long idAgama = 0;
            long idIdentity = 0;
            long idMariage = 0;
            long idBiodata = 0;
            var namaAgama = "";
            var namaIdentity = "";
            var statusMariage = "";


            using (DataContext context = new DataContext())
            {
                result = context.x_biodata.ToList();
            }
            using (DataContext context = new DataContext())
            {
                resultReligion = context.x_Religion.ToList();
            }
            using (DataContext context = new DataContext())
            {
                resultIdentity = context.x_identity_type.ToList();
            }
            using (DataContext context = new DataContext())
            {
                resultMariage = context.x_marital_status.ToList();
            }

            foreach (var item in result)
            {
                idMariage = item.marital_status_id;
                idIdentity = item.identity_type_id;
                idAgama = item.religion_id;
                idBiodata = item.id;
                BiodataViewModel resultKomplit = new BiodataViewModel();

                //inject data kedalam tabel sementaradi view model
                using (DataContext context = new DataContext())
                {
                    resultAddress = (from address in context.x_address where address.biodata_id == idBiodata select address).ToList();
                }
                //----------------------------------------------
                foreach (var itemAddress in resultAddress)
                {
                    if (item.id == itemAddress.biodata_id)
                    {
                        resultKomplit.id_Address = itemAddress.id;
                        resultKomplit.address1 = itemAddress.address1;
                        resultKomplit.address2 = itemAddress.address2;
                        resultKomplit.kecamatan1 = itemAddress.kecamatan1;
                        resultKomplit.kecamatan2 = itemAddress.kecamatan2;
                        resultKomplit.rt1 = itemAddress.rt1;
                        resultKomplit.rt2 = itemAddress.rt2;
                        resultKomplit.postal_code1 = itemAddress.postal_code1;
                        resultKomplit.postal_code2 = itemAddress.postal_code2;
                        resultKomplit.rw1 = itemAddress.rw1;
                        resultKomplit.rw2 = itemAddress.rw2;
                        resultKomplit.region1 = itemAddress.region1;
                        resultKomplit.region2 = itemAddress.region2;
                        resultKomplit.kelurahan1 = itemAddress.kelurahan1;
                        resultKomplit.kelurahan2 = itemAddress.kelurahan2;
                    }
                }

                foreach (var item2 in resultReligion)
                {
                    namaAgama = resultReligion.Find(d => d.id == idAgama).name;
                    if (item2.id == item.religion_id)
                    {
                        foreach (var itemIdentity in resultIdentity)
                        {
                            namaIdentity = resultIdentity.Find(e => e.id == idIdentity).name;
                            if (itemIdentity.id == item.identity_type_id)
                            {
                                foreach (var itemMariage in resultMariage)
                                {
                                    statusMariage = resultMariage.Find(f => f.id == idMariage).name;

                                    if (item.marital_status_id == itemMariage.id)
                                    {

                                        resultKomplit.id = item.id;
                                        resultKomplit.religion_id = item.religion_id;
                                        resultKomplit.identity_type_id = item.identity_type_id;
                                        resultKomplit.marital_status_id = item.marital_status_id;
                                        resultKomplit.id = item.id;
                                        resultKomplit.fullname = item.fullname;
                                        resultKomplit.nick_name = item.nick_name;
                                        resultKomplit.religion_name = namaAgama;
                                        resultKomplit.phone_number1 = item.phone_number1;
                                        resultKomplit.pob = item.pob;
                                        resultKomplit.dob = item.dob;
                                        resultKomplit.high = item.high;
                                        resultKomplit.weight = item.weight;
                                        resultKomplit.nationality = item.nationality;
                                        resultKomplit.ethnic = item.ethnic;
                                        resultKomplit.gender = item.gender;
                                        resultKomplit.hobby = item.hobby;
                                        resultKomplit.how_many_brothers = item.how_many_brothers;
                                        resultKomplit.marriage_year = item.marriage_year;
                                        resultKomplit.phone_number2 = item.phone_number2;
                                        resultKomplit.parent_phone_number = item.parent_phone_number;
                                        resultKomplit.identity_no = item.identity_no;
                                        resultKomplit.identity_name = namaIdentity;
                                        resultKomplit.mariage_status = statusMariage;
                                        resultKomplit.created_by = item.created_by;
                                        resultKomplit.created_on = item.created_on;
                                        resultKomplit.email = item.email;
                                        resultKomplit.religion_id = item.religion_id;
                                        resultKomplit.is_deleted = item.is_deleted;
                                        resultKomplit.child_sequence = item.child_sequence;
                                        resultKomplit.addrbook_id = item.addrbook_id;
                                        resultKomplit.company_id = item.company_id;

                                        resultComplete.Add(resultKomplit);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            return resultComplete;

        }
        public bool SaveEditBiodata(EditBiodataSplitter editDataPelamar)
        {
            try
            {
                List<x_biodata> getID = new List<x_biodata>();
                x_biodata biodataPelamar = new x_biodata();
                x_address alamatPelamar = new x_address();

                long getTheId = 0;

                foreach (var item in editDataPelamar.biodataPelamar)
                {
                    using (DataContext context = new DataContext())
                    {
                        biodataPelamar.id = item.id;
                        biodataPelamar.modified_on = DateTime.Now;
                        biodataPelamar.created_by = 1;
                        biodataPelamar.created_on = DateTime.Now;
                        biodataPelamar.is_deleted = false;
                        biodataPelamar.company_id = 1;
                        biodataPelamar.fullname = item.fullname;
                        biodataPelamar.nick_name = item.nick_name;
                        biodataPelamar.pob = item.pob;
                        biodataPelamar.dob = item.dob;
                        biodataPelamar.gender = item.gender;
                        biodataPelamar.religion_id = item.religion_id;
                        biodataPelamar.identity_type_id = item.identity_type_id;
                        biodataPelamar.identity_no = item.identity_no;
                        biodataPelamar.email = item.email;
                        biodataPelamar.phone_number1 = item.phone_number1;
                        biodataPelamar.parent_phone_number = item.parent_phone_number;
                        biodataPelamar.marital_status_id = item.marital_status_id;
                        biodataPelamar.high = item.high;
                        biodataPelamar.weight = item.weight;
                        biodataPelamar.nationality = item.nationality;
                        biodataPelamar.ethnic = item.ethnic;
                        biodataPelamar.hobby = item.hobby;
                        biodataPelamar.phone_number2 = item.phone_number2;
                        biodataPelamar.child_sequence = item.child_sequence;
                        biodataPelamar.how_many_brothers = item.how_many_brothers;
                        biodataPelamar.addrbook_id = item.addrbook_id;
                        biodataPelamar.marriage_year = item.marriage_year;

                        context.Entry(biodataPelamar).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                    }
                }
               
                foreach (var item in editDataPelamar.alamatPelamar)
                {
                    using (DataContext context = new DataContext())
                    {
                        alamatPelamar.id = item.id;
                        alamatPelamar.created_by = 1;
                        alamatPelamar.created_on = DateTime.Now;
                        alamatPelamar.modified_on = DateTime.Now;
                        alamatPelamar.is_deleted = false;
                        alamatPelamar.biodata_id = biodataPelamar.id;
                        alamatPelamar.address1 = item.address1;
                        alamatPelamar.address2 = item.address2;
                        alamatPelamar.rt1 = item.rt1;
                        alamatPelamar.rt2 = item.rt2;
                        alamatPelamar.rw1 = item.rw1;
                        alamatPelamar.rw2 = item.rw2;
                        alamatPelamar.kecamatan1 = item.kecamatan1;
                        alamatPelamar.kecamatan2 = item.kecamatan2;
                        alamatPelamar.kelurahan1 = item.kelurahan1;
                        alamatPelamar.kelurahan2 = item.kelurahan2;
                        alamatPelamar.region1 = item.region1;
                        alamatPelamar.region2 = item.region2;
                        alamatPelamar.postal_code1 = item.postal_code1;
                        alamatPelamar.postal_code2 = item.postal_code2;

                        context.Entry(alamatPelamar).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                    }
                }

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