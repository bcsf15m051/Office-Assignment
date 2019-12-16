using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService
{
    class DBManipulator
    {
        private SqlConnection cnConnection= null;
        private string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["ClientDB"].ConnectionString;
            }
        }
        private static DBManipulator _DBManipulator;
        private DBManipulator(string connectionString = "")
        {
            try
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                   
                    cnConnection = new SqlConnection(ConnectionString);
                }
                else
                {
                    cnConnection = new SqlConnection(connectionString);
                    OpenConnection();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void OpenConnection()
        {
            try
            {
                if (cnConnection.State == ConnectionState.Closed)
                {
                    cnConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static DBManipulator GetDBManipulator()
        {
            try
            {
                if (_DBManipulator == null)
                {
                    _DBManipulator = new DBManipulator();
                }
                return _DBManipulator;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public int CheckPath(string path)
        {
            try
            {
                OpenConnection();
                String sqlQuery = String.Format(@"select count(*) from Process where directory_path = '" + path + "'");
                SqlCommand command = new SqlCommand(sqlQuery, cnConnection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch(Exception ex)
            {
                return -1;
            }
            
        }
    }
}
