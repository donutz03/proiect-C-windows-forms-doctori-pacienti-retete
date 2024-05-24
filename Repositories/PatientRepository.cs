using System;
using System.Collections.Generic;
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

                string sql = $"SELECT * FROM PACIENTI ORDER BY ID DESC OFFSET :skip ROWS " +
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

        public void AddPatient(Patient newPatient)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "INSERT INTO PACIENTI (ID, NAME, DateOfBirth) VALUES (:id, :name, :dateOfBirth)";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = newPatient.Id;
                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = newPatient.Name;
                    cmd.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = newPatient.DateOfBirth;

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

        public void UpdatePatient(Patient patient)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "UPDATE PACIENTI SET NAME = :name, DateOfBirth = :dateOfBirth WHERE ID = :id";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = patient.Name;
                    cmd.Parameters.Add("dateOfBirth", OracleDbType.Date).Value = patient.DateOfBirth;
                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = patient.Id;

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

        public void DeletePatient(Patient patient)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "DELETE FROM PACIENTI WHERE ID = :id";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = patient.Id;

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
