﻿using DATALAYER;
using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
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
            string cell = "4560515616";
            string email = "asd";
            string pass = "asd";
            string ssid = "sdf";
            string DOB = "sdf";

            #region Select Christian
            DataContext db = new DataContext("Data Source=.;Initial Catalog=SHSdb3;Integrated Security=True;");
           
            Table<Persons> People = db.GetTable<Persons>();

            


            IQueryable<Persons> perQuery =
                from p in People
                where p.p_FirstName == "Christian"
                select p;


            foreach (Persons item in perQuery)
            {
                Console.WriteLine("Customer Name: {0}", item.p_FirstName);
            }

            #endregion

            #region Insert Someone
            Persons persons = new Persons
            {
                ID = 3,
                p_FirstName = fname,
                p_LastName = lname,
                p_EmailAddress = lname,
                p_CellNumber = cell,
                p_Password = pass,
                p_DOB = DOB,
                p_SSID = ssid
            };

            People.InsertOnSubmit(persons);
            db.SubmitChanges();
            #endregion

            #region Update
            var query =
                from p in People
                where p.ID == 2
                select p;
            
            foreach (Persons item in query)
            {
                item.p_FirstName = "Christian Martin";
                
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            #endregion

            #region Delete
            var deleteUser =
                from p in People
                where p.ID == 2
                select p;

            foreach (var Person in deleteUser)
            {
                People.DeleteOnSubmit(Person);
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
            #endregion

            Console.ReadKey();
        }
    }
}
