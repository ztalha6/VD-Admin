using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFramework
{
    public class DbSQLServer
    {
        //ExecuteReader, ExecuteScaler and ExecuteNoQuery
        private string _ConnString;
        public DbSQLServer(string ConnString)
        {
            _ConnString = ConnString;
        }

        public void SaveOrUpdateRecord(string stroredProcName,object obj)
        {
            using(SqlConnection conn= new SqlConnection(_ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(stroredProcName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //parameters
                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flags); 

                    foreach(var property in properties)
                    {
                        cmd.Parameters.AddWithValue("@" + property.Name,property.GetValue(obj, null));
                    }

                    //MessageBox.Show(cmd.Parameters.Count.ToString());
                    
                     cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataList(string storedProcName)
        {
            DataTable dtData = new DataTable();
            using(SqlConnection conn = new SqlConnection(_ConnString))
            {
                using(SqlCommand cmd = new SqlCommand(storedProcName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }
            return dtData;
        }

        public DataTable GetDataList(string storedProcName, DbParameters parameter)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.value);

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }
            return dtData;
        }

        public DataTable GetDataList(string storedProcName, DbParameters[] parameters)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProcName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.value);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtData.Load(reader);
                }
            }
            return dtData;
        }

        //Overloading funtion
        public object GetScalerValue(string StroeProcName)
        {
            object value = null; 
            using(SqlConnection conn = new SqlConnection(_ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(StroeProcName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    value = cmd.ExecuteScalar();

                }
            }
            return value;
        }

        public object GetScalerValue(string StroeProcName, DbParameters parameter)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(StroeProcName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.value);
                    value = cmd.ExecuteScalar();

                }
            }
            return value;
        }

        public object GetScalerValue(string StroeProcName, DbParameters[] parameters)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(StroeProcName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.value);
                    }
                    value = cmd.ExecuteScalar();

                }
            }
            return value;
        }
        public byte[] getDocument(string query)
        {
            string mquery = query;
            byte[] AssignedFile;

            using (SqlConnection conn = new SqlConnection(_ConnString))
            using (SqlCommand cm = conn.CreateCommand())
            {
                cm.CommandText = mquery; 
                //cm.CommandText = @"
                //                    SELECT AssignedFile
                //                    FROM   PlanExecute
                //                    WHERE  ExecuteID = @Id";
                //cm.Parameters.AddWithValue("@Id", mDocumentId);

                conn.Open();
                AssignedFile = cm.ExecuteScalar() as byte[];
                cm.Dispose();
                conn.Close();
                return AssignedFile;
            }
        }
        public string getExtention(string query)
        {
            string mquery = query;
            string FileEx;

            using (SqlConnection conn = new SqlConnection(_ConnString))
            using (SqlCommand cm = conn.CreateCommand())
            {
                cm.CommandText = mquery;
                //cm.CommandText = @"
                //                    SELECT AssignedFile
                //                    FROM   PlanExecute
                //                    WHERE  ExecuteID = @Id";
                //cm.Parameters.AddWithValue("@Id", mDocumentId);

                conn.Open();
                FileEx = cm.ExecuteScalar() as string;
                cm.Dispose();
                conn.Close();
                return FileEx;
            }
        }

        public void saveDocument(string query)
        {
            string mquery = query;
            //byte[] AssignedFile=doc;

            using (SqlConnection conn = new SqlConnection(_ConnString))
            using (SqlCommand cm = conn.CreateCommand())
            {
                cm.CommandText = mquery;
                //cm.CommandText = @"
                //                    SELECT AssignedFile
                //                    FROM   PlanExecute
                //                    WHERE  ExecuteID = @Id";
                //cm.Parameters.AddWithValue("@Id", mDocumentId);

                conn.Open();
                //AssignedFile = cm.ExecuteScalar() as byte[];
                cm.Dispose();
                conn.Close();
                //return AssignedFile;
            }
        }



    }
}
