using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DirectoryPersistence.Entities;
using DirectoryBusinessLogic.Aplicacion;

namespace DirectoryExternalServices.Controllers
{
    public class PersonController : ApiController
    {
        private static BusinessPerson _businessPerson;

        public PersonController()
        {
            _businessPerson = new BusinessPerson();
        }

        public IEnumerable<Person> GetAllPerson()
        {
            return _businessPerson.getAllPersons();
        }
    }
}
