﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryPersistence
{
    public class DBProviderFactory
    {
        public SqlConnection connection {get;set;}

         public DBProviderFactory()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\Directory.mdf';Integrated Security=True;");
             connection.Open();
        }
    }
}