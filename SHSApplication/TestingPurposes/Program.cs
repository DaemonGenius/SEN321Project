using DATALAYER.DataHandler;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPurposes
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext("Data Source=.;Initial Catalog=SHSdb2;Integrated Security=True");
            Table<Person> Person = db.GetTable<Person>();
            db.Log = Console.Out;
            IQueryable<Person> perQuery =
                                           from Per in Person
                                           where Per.p_FirstName == "Christian"

                                           select Per;

            foreach (Person item in perQuery)
            {
                Console.WriteLine("ID = {0}, FName = {1}, LName = {2}", item.PersonID, item.p_FirstName, item.p_LastName);
            }

            #region Example
            //SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=SHSdb2;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();

            //cmd.CommandText = "Select * FROM People";
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Connection = sqlConnection;
            //sqlConnection.Open();
            //using (SqlDataReader reader = cmd.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        for (int i = 0; i < reader.FieldCount; i++)
            //        {
            //            Console.WriteLine(reader.GetValue(i));
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //sqlConnection.Close();
            #endregion


            //"C:\\Program Files\\Microsoft SQL Server\\MSSQL14.MSSQLSERVER\\MSSQL\\DATA\\SHSdb2.mdf"

            Console.ReadKey();
        }
    }
}
