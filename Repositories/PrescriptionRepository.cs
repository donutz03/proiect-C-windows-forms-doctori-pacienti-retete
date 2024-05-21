/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1056_HODOROAGA_IONUT.Repositories
{
    public class RecipeRepository
    {
        public void AddRecipe(Recipe Recipe)
        {
            FakeDatabase.Recipes.Add(Recipe);
        }

        public BindingList<Recipe> GetAllRecipes()
        {
            return FakeDatabase.Recipes;
        }

        public void UpdateRecipe(Recipe Recipe)
        {
            var existing = FakeDatabase.Recipes.First(x => x.Id == Recipe.Id);
            existing.Name = Recipe.Name;
            existing.Description = Recipe.Description;
            existing.NetPrice = Recipe.NetPrice;
            existing.IsFoodItem = Recipe.IsFoodItem;
            FakeDatabase.Recipes.ResetBindings();
        }

        public void DeleteRecipe(Recipe Recipe)
        {
            FakeDatabase.Recipes.Remove(Recipe);
        }

        public void ResetDatabaseWith(List<Recipe> Recipes)
        {
            FakeDatabase.Recipes.Clear();
            foreach (var Recipe in Recipes)
            {
                FakeDatabase.Recipes.Add(Recipe);
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

        public List<Prescription> FetchData(int currentPage, int pageSize)
        {
            var data = new List<Prescription>();

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
    }
}
