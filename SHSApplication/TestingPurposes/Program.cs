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
            string fname = "awed";
            string lname = "awed";
            int streetnum  = 15;
            string email = "asd";
            string pass = "asd";
            string ssid = "sdf";
            string Country = "fdssfd";

            SHSdb2 db = new SHSdb2("Data Source=.;Initial Catalog=SHSdb2;Integrated Security=True");

            var personQuery =
                from per in db.People
                where per.p_FirstName == "Christian" 
                select per.Department;

          

      
            foreach (var item in personQuery)
            {
                Console.WriteLine("FirstName = {0} ", item.dept_Type);
            }

            Person person = new Person();
            person.p_FirstName = fname;
            person.p_LastName = lname;
            person.p_EmailAddress = email;
            person.p_DOB = "1996/07/25";
            person.p_Password = pass;
            person.p_SSID = ssid;


            db.People.InsertOnSubmit(person);
            db.SubmitChanges();


            Person personUp = db.People.Single(Person => Person.ID == 1);
            personUp.p_FirstName = "Christian Martin";
            db.SubmitChanges();



            Person personDel = db.People.Single(Person => person.p_FirstName == "Christian");
            db.People.DeleteOnSubmit(personDel);
            db.SubmitChanges();





















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
