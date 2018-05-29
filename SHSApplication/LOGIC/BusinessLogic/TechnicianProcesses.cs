using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class TechnicianProcesses
    {
        public static async Task<Maintenance> GetTechSche(string name)
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.FirstName == name));
                Maintenance maintenance = dbe.maintenances.FirstOrDefault(x => x.TechnicianEmp.Person_ID == person.ID);

                return new Maintenance()
                {
                    DateStart = maintenance.DateStart,
                    DateEnd = maintenance.DateEnd,
                    TechnicianEmp = new TechnicianEmp
                    {
                        People = new People
                        {
                            FirstName = maintenance.TechnicianEmp.People.FirstName,
                            LastName = maintenance.TechnicianEmp.People.LastName,
                            
                        },                        
                        
                    },
                    Client = new Client
                    {
                        People = new People
                        {
                            FirstName = maintenance.Client.People.FirstName,
                            LastName = maintenance.Client.People.LastName
                        }
                    },
                    ProductSystem = new ProductSystem
                    {
                        Name = maintenance.ProductSystem.Name
                    }
                };
            }
        }
    }
}
