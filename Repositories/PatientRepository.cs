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
    public class PatientRepository
    {
        public int GetTotalCount()
        {
            int count;
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var sql = "SELECT COUNT(*) FROM PACIENTI";
                using (var command = new OracleCommand(sql, conn))
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }

                conn.Close();
            }

            return count;
        }

        public List<Patient> FetchData(int currentPage, int pageSize)
        {
            var data = new List<Patient>();

            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var skip = (currentPage - 1) * pageSize;
                var take = pageSize;

                string sql = $"SELECT * FROM PACIENTI ORDER BY NAME OFFSET :skip ROWS " +
                    $"FETCH NEXT :take ROWS ONLY";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("skip", OracleDbType.Int32).Value = skip;
                    cmd.Parameters.Add("take", OracleDbType.Int32).Value = take;

                    OracleDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Patient Pacient = new Patient();
                        Pacient.Id = int.Parse(dataReader["ID"].ToString());
                        Pacient.Name = dataReader["NAME"].ToString();
                        Pacient.DateOfBirth = (DateTime)dataReader["DateOfBirth"];
                        data.Add(Pacient);
                    }
                }
                conn.Close();
            }
            return data;
        }

        internal void AddPatient(Patient newPatient)
        {
            throw new NotImplementedException();
        }
    }
}
