namespace _03_MinionNames
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

                int villainId = int.Parse(Console.ReadLine());


                string takeVillainName = "SELECT Name FROM Villains WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(takeVillainName,connection))
                {
                    cmd.Parameters.AddWithValue("@id", villainId);

                    var villainName = (string)cmd.ExecuteScalar();
                    if (villainName == null)
                    {
                        Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                        connection.Close();
                        return;
                    }

                    Console.WriteLine($"Villain: {villainName}");

                }



                var takeMinionsSqlString = "SELECT m.Name, m.Age, ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum FROM MinionsVillains AS mv JOIN Minions As m ON mv.MinionId = m.Id WHERE mv.VillainId = @id ORDER BY m.Name";

                using (SqlCommand cmd = new SqlCommand(takeMinionsSqlString, connection))
                {
                    cmd.Parameters.AddWithValue("@id", villainId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("(no minions)");
                            reader.Close();
                            connection.Close();
                            return;
                        }

                        while (reader.Read())
                        {
                            string minionName = (string)reader["Name"];
                            long rowNum = (long)reader["RowNum"];
                            int minionAge = (int)reader["Age"];

                            Console.WriteLine($"{rowNum}. {minionName} {minionAge}");
                        }

                    }
                }

                connection.Close();
            }
        }
    }
}