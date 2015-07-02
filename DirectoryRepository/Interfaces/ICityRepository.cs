using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryPersistence.Entities;

namespace DirectoryRepository.Interfaces
{
    interface ICityRepository
    {
        IEnumerable<City> getAllCities();
        City insertCity();
    }
}
