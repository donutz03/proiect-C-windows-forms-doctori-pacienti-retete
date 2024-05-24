using System;
using System.ComponentModel;
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

        public BindingList<Doctor> FetchData(int currentPage, int pageSize)
        {
            var data = new BindingList<Doctor>();

            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                var skip = (currentPage - 1) * pageSize;
                var take = pageSize;

                string sql = $"SELECT * FROM DOCTORS ORDER BY ID DESC OFFSET :skip ROWS " +
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
        public void AddDoctor(Doctor doctor)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "INSERT INTO DOCTORS (ID, NAME, POSITION, DEPARTMENT) VALUES (:id, :name, :position, :department)";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = doctor.Id;
                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = doctor.Name;
                    cmd.Parameters.Add("position", OracleDbType.Varchar2).Value = doctor.Position;
                    cmd.Parameters.Add("department", OracleDbType.Varchar2).Value = doctor.Department;

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

        public void UpdateDoctor(Doctor doctor)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "UPDATE DOCTORS SET NAME = :name, POSITION = :position, DEPARTMENT = :department WHERE ID = :id";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = doctor.Name;
                    cmd.Parameters.Add("position", OracleDbType.Varchar2).Value = doctor.Position;
                    cmd.Parameters.Add("department", OracleDbType.Varchar2).Value = doctor.Department;
                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = doctor.Id;

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

        public void DeleteDoctor(Doctor doctor)
        {
            using (OracleConnection conn = new OracleConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (OracleCommand cmd = conn.CreateCommand())
                {
                    var sql = "DELETE FROM DOCTORS WHERE ID = :id";
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = doctor.Id;

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
