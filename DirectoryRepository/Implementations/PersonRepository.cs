using DirectoryPersistence;
using DirectoryRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryPersistence.EntPerson;

namespace DirectoryRepositoryInterfaces.Implementations
{
    class PersonRepository: IPersonRepository
    {
        private readonly SqlConnection _connection;
       

        PersonRepository()
        {
            _connection = new DBProviderFactory().connection;
        }

        IEnumerable<Person> getAllPersons()
        {
            List<Person> result = new List<Person>();

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
    }
}
