﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryPersistence.Entities;

namespace DirectoryPersistence.Entities
{
    public class City
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public string country { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
