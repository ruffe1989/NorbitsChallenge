using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NorbitsChallenge.Bll;

namespace NorbitsChallenge.Dal
{
    public class CarDb
    {
        private readonly IConfiguration _config;

        public CarDb(IConfiguration config)
        {
            _config = config;
        }

        public int GetTireCount(int companyId, string licensePlate)
        {
            int result = 0;

            var connectionString = _config.GetSection("ConnectionString").Value;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand {Connection = connection, CommandType = CommandType.Text})
                {
                    command.CommandText = $"select * from car where companyId = {companyId} and licenseplate = '{licensePlate}'";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = (int) reader["tireCount"];
                        }
                    }
                }
            }

            return result;
        }

        public List<Car> GetCars(int companyId)
        {
            var cars = new List<Car>();

            var connectionString = _config.GetSection("ConnectionString").Value;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand { Connection = connection, CommandType = CommandType.Text })
                {
                    command.CommandText = $"select * from car where companyId = {companyId}";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Car car;
                        while (reader.Read())
                        {
                            car = new Car();
                            car.LicensePlate = reader["LicensePlate"].ToString();
                            car.Description = reader["Description"].ToString();
                            car.Model = reader["Model"].ToString();
                            car.Brand = reader["Brand"].ToString();
                            car.TireCount = (int)reader["TireCount"];
                            car.CompanyId = (int)reader["CompanyId"];
                            cars.Add(car);                        

                        }
                    }
                }
            }

            return cars;
          
        }

        public List<Car> GetOneCar(string LicensePlate)
        {
            var cars = new List<Car>();

            var connectionString = _config.GetSection("ConnectionString").Value;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand { Connection = connection, CommandType = CommandType.Text })
                {
                    command.CommandText = $"select * from car where LicensePlate = '{LicensePlate}'";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Car car;
                        if (reader.HasRows)
                        {
                            reader.Read();
                            car = new Car();
                            car.LicensePlate = LicensePlate;
                            car.Description = reader["Description"].ToString();
                            car.Model = reader["Model"].ToString();
                            car.Brand = reader["Brand"].ToString();
                            car.TireCount = (int)reader["TireCount"];
                            car.CompanyId = (int)reader["CompanyId"];
                            cars.Add(car);

                        }
                    }
                }
            }

            return cars;

        }
        public void RemoveCar(string licensePlate)
        {
            var connectionString = _config.GetSection("ConnectionString").Value;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand { Connection = connection, CommandType = CommandType.Text })
                {
                    command.CommandText = $"delete from car where Licenseplate = '{licensePlate}'";

                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
