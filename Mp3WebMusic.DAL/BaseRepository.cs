using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Mp3WebMusic.DAL
{
    public class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository()
        {
            string connectionString = @"Data Source=RICE\SQLEXPRESS;Initial Catalog=Mp3Project;Integrated Security=True";
            //string connectionString = @"workstation id=Mp3WebMusic.mssql.somee.com;packet size=4096;user id=Mp3Web_SQLLogin_1;pwd=cwr1m1b89i;data source=Mp3WebMusic.mssql.somee.com;persist security info=False;initial catalog=Mp3WebMusic";
            connection = new SqlConnection(connectionString);
           
         
        }
    }
}
