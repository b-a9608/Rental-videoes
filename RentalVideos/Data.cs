﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideos
{
   public class Data
    {
        public String appsetting = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ToString();
        SqlConnection sqlConnection = new SqlConnection();
        /// <summary>
        /// sql connection from web config
        /// </summary>
        /// <returns></returns>
        public SqlConnection SQLConnection()
        {
            sqlConnection = new SqlConnection(appsetting);
            return sqlConnection;

        }
        public void SqlOpen()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {

            }


        }
        public void SqlClose()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
