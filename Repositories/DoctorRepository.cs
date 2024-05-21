/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1056_HODOROAGA_IONUT.Repositories
{
    public class MedicRepository
    {
        public void AddMedic(Medic Medic)
        {
            FakeDatabase.Medics.Add(Medic);
        }

        public BindingList<Medic> GetAllMedics()
        {
            return FakeDatabase.Medics;
        }

        public void UpdateMedic(Medic Medic)
        {
            var existing = FakeDatabase.Medics.First(x => x.Id == Medic.Id);
            existing.Name = Medic.Name;
            existing.Description = Medic.Description;
            existing.NetPrice = Medic.NetPrice;
            existing.IsFoodItem = Medic.IsFoodItem;
            FakeDatabase.Medics.ResetBindings();
        }

        public void DeleteMedic(Medic Medic)
        {
            FakeDatabase.Medics.Remove(Medic);
        }

        public void ResetDatabaseWith(List<Medic> Medics)
        {
            FakeDatabase.Medics.Clear();
            foreach (var Medic in Medics)
            {
                FakeDatabase.Medics.Add(Medic);
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_1056_HODOROAGA_IONUT.Entities;
using Oracle.ManagedDataAccess.Client;

namespace _2_1056_HODOROAGA_IONUT.Repositories
{
    public class DoctorRepository
    {
        public int GetTotalCount()
        {
            int count;
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var sql = "SELECT COUNT(*) FROM DOCTORS";
                using (var command = new OracleCommand(sql, conn))
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }

                conn.Close();
            }

            return count;
        }

        public List<Doctor> FetchData(int currentPage, int pageSize)
        {
            var data = new List<Doctor>();

            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var skip = (currentPage - 1) * pageSize;
                var take = pageSize;

                string sql = $"SELECT * FROM DOCTORS ORDER BY NAME OFFSET :skip ROWS " +
                    $"FETCH NEXT :take ROWS ONLY";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("skip", OracleDbType.Int32).Value = skip;
                    cmd.Parameters.Add("take", OracleDbType.Int32).Value = take;

                    OracleDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Doctor doctor = new Doctor();
                        doctor.Id = int.Parse(dataReader["ID"].ToString());
                        doctor.Name = dataReader["NAME"].ToString();
                        doctor.Position = dataReader["Position"].ToString();
                        doctor.Department = dataReader["Department"].ToString();
                        data.Add(doctor);
                    }
                }
                conn.Close();
            }
            return data;
        }
    }
}
