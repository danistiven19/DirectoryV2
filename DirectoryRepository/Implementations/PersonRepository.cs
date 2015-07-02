using DirectoryPersistence;
using DirectoryPersistence.Entities;
using DirectoryRepository;
using DirectoryRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DirectoryRepository.Implementations
{
    public class PersonRepository: IPersonRepository
    {
        private readonly SqlConnection _connection;
        private DBProviderFactory _provider;

        public PersonRepository()
        {
            _provider = new DBProviderFactory();
            _connection = _provider.connection;
       
        }


         IEnumerable<Person> IPersonRepository.getAllPersons()
        {
            List<Person> result = new List<Person>();
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
            _connection.Open();
            //Create the SQL Query for returning all the articles
            string sqlQuery = String.Format("select * from Person");
            SqlCommand command = new SqlCommand(sqlQuery, _connection);

            //Create DataReader for storing the returning table into server memory
            SqlDataReader dataReader = command.ExecuteReader();

            Person person = null;

            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    person = new Person();

                    person.Id = Convert.ToInt32(dataReader["Id"]);
                    person.name = dataReader["name"].ToString();
                    person.lastname = dataReader["lastname"].ToString();
                    person.telephoneNumber = dataReader["telephoneNumber"].ToString();
                    person.email = dataReader["email"].ToString();
                    person.city = Convert.ToInt32(dataReader["city"]);

                    result.Add(person);
                }
            }
            _connection.Close();
            return result;
        }

         Person IPersonRepository.insertPerson()
        {
            throw new NotImplementedException();
        }
    }
}

