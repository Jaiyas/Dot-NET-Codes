using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace Console_jaishri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Server=LAPTOP-MKHQB0TN\\MSSQLSERVER1;database=EMPdb;user id=sa;password=user123;Trusted_Connection=True;TrustServerCertificate=True";

                //Console.WriteLine("Connection successful");
                //calling getallemployee
                GetAllEmployees(connectionString);
                //calling getemployeebyid
                int EmployeeID = 1;
                GetEmployeeByID(connectionString, EmployeeID);
                //calling CreateEmployeeWithAddress
                string firstName = "Ramesh";
                string lastName = "Sharma";
                string email = "ramesh@example.com";
                string street = "123 Patia";
                string city = "BBSR";
                string states = "India";
                string postalCode = "755019";

                CreateEmployeeWithAddress(connectionString, firstName, lastName, email, street, city, states, postalCode);

                //calling UpdateEmployeeWithAddress
                int employeeId = 3;
                firstName = "Rakesh";
                lastName = "Sharma";
                email = "rakesh@example.com";
                street = "3456 Patia";
                city = "CTC";
                states = "India";
                postalCode = "755024";
                int addressId= 3;

                UpdateEmployeeWithAddress(connectionString, employeeId, firstName, lastName, email, street, city, states, postalCode, addressId);

                //calling
                employeeId = 3;
                DeleteEmployee(connectionString, employeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong:{ex.Message}");
            }
        }

        static void GetAllEmployees(string connectionString)
        {
            Console.WriteLine("GetAllEmployees Store Procedure Called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeId: {reader["EmployeeId"]},FirstNamee:{reader["FirstName"]},LastName:{reader["Lastname"]}, Email: {reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},City:{reader["City"]},StateS:{reader["States"]},PostalCode:{reader["PostalCode"]}\n");
                }
                reader.Close();
                connection.Close();
            }
        }


        static void GetEmployeeByID(string connectionString, int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID Stored Procedure Called");
                SqlCommand command = new SqlCommand("GetallEmployeeId", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", EmployeeId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Employee:{reader["FirstName"]} {reader["LastName"]} Email:{reader["Email"]}");
                    Console.WriteLine($"Address:{reader["Street"]},{reader["City"]},{reader["States"]},{reader["PostalCode"]}");
                }
                reader.Close();
                connection.Close();
            }
        }


        static void CreateEmployeeWithAddress(string connectionString, string firstName, string lastName, string email, string street, string city, string state, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("CreateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("CreateEmployeeWithAddresses", connection);
                command.CommandType = CommandType.StoredProcedure;
                //Add parameter for Employee and address
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@StateS", state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Address created successfully.");
                connection.Close();
            }
        }


        static void UpdateEmployeeWithAddress(string connectionString, int EmployeeId, string firstName, string lastName, string email, string street, string city, string states, string postalCode, int AddressId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("UpdateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for Employee and address
                command.Parameters.AddWithValue("@EmployeeID", EmployeeId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@StateS", states);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@addressID", AddressId); // Corrected parameter name
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Addresses updated successfully,");
                connection.Close();
            }
        }
  

        static void DeleteEmployee(string connectionString, int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("DeleteEmployee Stored Procedure Called");
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeId
                command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine(value: "Employee and their Address deleted successfully.");
                }
                else
                {
                    Console.WriteLine(value: "Employee not found.");
                }
                connection.Close();

            }
        }
    }
}
            
                
               
        







    