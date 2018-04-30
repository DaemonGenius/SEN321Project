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

            SHSdb2 db = new SHSdb2("Data Source=.;Initial Catalog=SHSdb2;Integrated Security=True");

            var personQuery =
                from per in db.People
                where per.p_FirstName == "Christian" 
                select per;

            var addressQuery =
                from ad in db.Address
                where ad.adr_Country == " South Africa"
                select ad;


            //Console.WriteLine( personQuery);
            foreach (var item in addressQuery)
            {
                Console.WriteLine("FirstNAme = {0} ", item.adr_City);
            }




















            #region SqlTest1
            //DataContext db = new DataContext("Data Source=.;Initial Catalog=SHSdb2;Integrated Security=True");
            //Table<Person> Person = db.GetTable<Person>();

            //db.Log = Console.Out;
            //IQueryable<Person> perQuery =
            //                               from Per in Person
            //                               where Per.p_FirstName == "Christian"
            //                               where Per.Department.dept_ID == Per.ID


            //                               select Per;

            //foreach (Person item in perQuery)
            //{
            //    Console.WriteLine("ID = {0}, FName = {1}, LName = {2}, DepartmentType = {3}", item.ID, item.p_FirstName, item.p_LastName, item.Department.dept_Type);
            //}
            #endregion





            //Table<Department> department = db.GetTable<Department>();
            //IQueryable<Department> depQuery = from dep in department
            //                                  where dep.dept_ID == 1
            //                                  select dep;

            //foreach (Department item in depQuery)
            //{
            //    Console.WriteLine("ID = {0}, DepType = {1}", item.dept_ID, item.dept_Type);
            //}

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
