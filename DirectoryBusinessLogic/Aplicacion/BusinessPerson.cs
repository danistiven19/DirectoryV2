using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryRepository.Interfaces;
using DirectoryRepository.Implementations;
using DirectoryPersistence.Entities; //...Difference between DTO and Model?

namespace DirectoryBusinessLogic.Aplicacion
{
   public class BusinessPerson
    {
        private  IPersonRepository _personRepo;

        public BusinessPerson()
        {
            _personRepo = new PersonRepository();
        }

        public IEnumerable<Person> getAllPersons()
        {
            return (IEnumerable<Person>) _personRepo.getAllPersons();
        }
    }
}
