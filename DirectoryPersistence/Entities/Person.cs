using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryPersistence.Entities;


namespace DirectoryPersistence.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string telephoneNumber { get; set; }
        public string email { get; set; }
        public int city { get; set; }
        public virtual City City1 { get; set; }
    }

}
