using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryPersistence.EntPerson;


namespace DirectoryRepository
{
    interface IPersonRepository
    {
        IEnumerable<Person> getAllPersons();
        Person insertPerson();
    }
}
