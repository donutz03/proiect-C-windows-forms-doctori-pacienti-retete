
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
    public class PrescriptionRepository
    {
        public int GetTotalCount()
        {
            int count;
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var sql = "SELECT COUNT(*) FROM RETETE";
                using (var command = new OracleCommand(sql, conn))
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }

                conn.Close();
            }

            return count;
        }

        public BindingList<Prescription> FetchData(int currentPage, int pageSize)
        {
            var data = new BindingList<Prescription>();

            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var skip = (currentPage - 1) * pageSize;
                var take = pageSize;

                string sql = $"SELECT * FROM RETETE ORDER BY ID OFFSET :skip ROWS " +
                    $"FETCH NEXT :take ROWS ONLY";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("skip", OracleDbType.Int32).Value = skip;
                    cmd.Parameters.Add("take", OracleDbType.Int32).Value = take;

                    OracleDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Prescription prescription = new Prescription();
                        prescription.Id = int.Parse(dataReader["ID"].ToString());
                        prescription.Description = dataReader["Description"].ToString();
                        prescription.IdPacient = int.Parse(dataReader["id_pacient"].ToString());
                        prescription.Pacient = dataReader["pacientNume"].ToString();
                        prescription.IdDoctor = int.Parse(dataReader["id_doctor"].ToString());
                        prescription.Doctor = dataReader["doctorNume"].ToString();
                        data.Add(prescription);
                    }
                }
                conn.Close();//
            }
            return data;
        }

        public List<Patient> GetPatientsByDoctorId(Doctor doctor)
        {
            var patients = new List<Patient>();
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();
                string sql = @"SELECT DISTINCT P.ID, P.NAME, P.DATEOFBIRTH
                               FROM PACIENTI P
                               JOIN RETETE RET ON P.ID = RET.ID_PACIENT
                               WHERE RET.ID_DOCTOR = :doctorId";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("doctorId", OracleDbType.Int32).Value = doctor.Id;
                    OracleDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Patient patient = new Patient
                        {
                            Id = int.Parse(dataReader["ID"].ToString()),
                            Name = dataReader["NAME"].ToString(),
                            DateOfBirth = (DateTime)dataReader["DATEOFBIRTH"]
                        };
                        patients.Add(patient);
                    }
                }
                conn.Close();
            }
            return patients;
        }

        public void AddPrescription(Prescription prescription)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "INSERT INTO RETETE (ID, DESCRIPTION, ID_PACIENT, ID_DOCTOR) VALUES (:id, :description, :idPacient, :idDoctor)";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = prescription.Id;
                    cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = prescription.Description;
                    cmd.Parameters.Add("idPacient", OracleDbType.Int32).Value = prescription.IdPacient;
                    cmd.Parameters.Add("idDoctor", OracleDbType.Int32).Value = prescription.IdDoctor;

                    cmd.ExecuteNonQuery();
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

                conn.Close();
            }
        }

        public void UpdatePrescription(Prescription prescription)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "UPDATE RETETE SET DESCRIPTION = :description, ID_PACIENT = :idPacient, ID_DOCTOR = :idDoctor WHERE ID = :id";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = prescription.Description;
                    cmd.Parameters.Add("idPacient", OracleDbType.Int32).Value = prescription.IdPacient;
                    cmd.Parameters.Add("idDoctor", OracleDbType.Int32).Value = prescription.IdDoctor;
                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = prescription.Id;

                    cmd.ExecuteNonQuery();
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

                conn.Close();
            }
        }

        public void DeletePrescription(Prescription prescription)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "DELETE FROM RETETE WHERE ID = :id";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = prescription.Id;

                    cmd.ExecuteNonQuery();
                }

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

                conn.Close();
            }
        }

    }
}
