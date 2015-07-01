using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryRepository.Interfaces;
using System.Data.SqlClient;
using DirectoryPersistence;
using DirectoryPersistence.Entities;

namespace DirectoryRepository.Implementations
{
    class CityRepository: ICityRepository
    {
          private readonly SqlConnection _connection;
       

        CityRepository()
        {
            _connection = new DBProviderFactory().connection;
        }

        IEnumerable<City> getAllPersons()
        {
            List<City> result = new List<City>();

            //Create the SQL Query for returning all the articles
            string sqlQuery = String.Format("select * from City");
            SqlCommand command = new SqlCommand(sqlQuery, _connection);

            //Create DataReader for storing the returning table into server memory
            SqlDataReader dataReader = command.ExecuteReader();

            City city = null;

            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    city = new City();

                    city.cityId = Convert.ToInt32(dataReader["cityId"]);                   
                    city.cityName = dataReader["cityName"].ToString();
                    city.country = dataReader["country"].ToString();                                        
                    result.Add(city);
                }
            }
            _connection.Close();
            return result;
        }

    }
}
