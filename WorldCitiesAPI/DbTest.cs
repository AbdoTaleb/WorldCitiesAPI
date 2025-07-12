using System;
using System.Data.SqlClient;

namespace WorldCitiesAPI
{
    public class DbTest
    {
        public static void TestConnection()
        {
            var connectionString = "Server=DESKTOP-4DVTTSS\\Abdot;Database=WorldCities;Trusted_Connection=True;";
            using var connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("✅ Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Connection failed:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
