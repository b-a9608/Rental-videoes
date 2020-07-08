using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVideos
{
    public class Biz
    {
        Data dataLayer = new Data();

        /// <summary>
        /// get data table after executing SP with parameter
        /// </summary>
        /// <param name="SPName"></param>
        /// <param name="SP"></param>
        /// <returns></returns>
        public DataTable geDataTableWithParamter(string SPName, SqlParameter[] SP)
        {
            SqlCommand cmd = new SqlCommand(SPName, dataLayer.SQLConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SPName;
            cmd.CommandTimeout = 600;
            foreach (SqlParameter sp in SP)
            {
                cmd.Parameters.Add(sp);
            }



            try
            {
                dataLayer.SqlOpen();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataLayer.SqlClose();

            }
            catch (Exception e)
            {
                // Response.Write(" <script>alert('"+e.ToString()+"')</script>");

            }
            finally
            {
                cmd.Dispose();
                dataLayer.SqlClose();
            }
            return dt;


        }
        /// <summary>
        /// get data from datatable after exceuting SP without parameter
        /// </summary>
        /// <param name="SPName"></param>
        /// <returns></returns>
        public DataTable getDataTableWithoutParamter(string SPName)
        {
            SqlCommand cmd = new SqlCommand(SPName, dataLayer.SQLConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SPName;
            cmd.CommandTimeout = 600;
            try
            {
                dataLayer.SqlOpen();
                da.SelectCommand = cmd;
                da.Fill(dt);
                dataLayer.SqlClose();

            }
            catch { }
            finally
            {
                cmd.Dispose();
                dataLayer.SqlClose();
            }
            return dt;


        }
    }
}
