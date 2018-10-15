namespace _02_VillainNames
{
    using System;
    using System.Data.SqlClient;

    public class StartUp
    {
        public static void Main()
        {
            string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=MinionsDB;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sqlString = "SELECT v.Name, COUNT(*) AS MinionsCount FROM Villains AS v JOIN MinionsVillains AS mv ON v.Id = mv.VillainId GROUP BY v.Name HAVING COUNT(*) >= 2 ORDER BY MinionsCount DESC";

                using (SqlCommand cmd = new SqlCommand(sqlString,connection))
                {
                    using (SqlDataReader reader =  cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string villainName = (string)reader["Name"];
                            int minionsCount = (int)reader["MinionsCount"];

                            Console.WriteLine($"{villainName} - {minionsCount}");
                        }

                    }
                }


                connection.Close();
            }
        }
    }
}