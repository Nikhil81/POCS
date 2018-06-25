using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class DatabseCall
    {
        //private readonly Database _database;

        //public DatabseCall()
        //{
        //    _database = DatabaseFactory.CreateDatabase("XS_STOREDB");
        //}
        public void GetEmployeeById(int id)
        {
            SqlConnection PubsConn = new SqlConnection("Persist Security Info=False;User ID=sa;password=Global@123;Initial Catalog=EmployeeDB;Data Source=.");
            SqlCommand testCMD = new SqlCommand("GetEmpByID", PubsConn);

            testCMD.CommandType = CommandType.StoredProcedure;

            //SqlParameter RetVal = testCMD.Parameters.Add("RetVal", SqlDbType.Int);
            //RetVal.Direction = ParameterDirection.ReturnValue;
            SqlParameter IdIn = testCMD.Parameters.Add("@empid", SqlDbType.Int,1);
            IdIn.Direction = ParameterDirection.Input;
            //SqlParameter NumTitles = testCMD.Parameters.Add("@numtitlesout", SqlDbType.VarChar, 11);
            //NumTitles.Direction = ParameterDirection.Output;

            IdIn.Value = "213468915";
            PubsConn.Open();

            SqlDataReader myReader = testCMD.ExecuteReader();
            Console.WriteLine("Book Titles for this Author:");
            while (myReader.Read())
            {
                var a = myReader["FirstName"].ToString();
            };
            myReader.Close();
            Console.WriteLine("Number of Rows: ");
           // Console.WriteLine("Return Value: " + RetVal.Value);
        }
    }
}
