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
        public static async Task<Maintenance> LoadTechSche(string name)
        {
            using (var dbe = new SHSdb())
            {
                Maintenance maintenance = dbe.maintenances.FirstOrDefault((x => x.Name == name));

                return new Maintenance()
                {
                    Name = maintenance.Name,
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

        public static async Task<TechnicianEmp> GetTechMain(string name)
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.FirstName == name));
                TechnicianEmp technicianEmp = dbe.technicianEmps.FirstOrDefault(x => x.People.FirstName == person.FirstName);

                return new TechnicianEmp
                {
                    ID = technicianEmp.ID,
                    Maintenances = (from Mein in technicianEmp.Maintenances
                                    select new Maintenance
                                    {
                                        Name = Mein.Name
                                    }).ToEntitySet()
                };

            }
        }

        #region TechLoad
        public static List<string> TechNameLoad()
        {
            using (var dbe = new SHSdb())
            {

                return dbe.technicianEmps.Select(x => x.People.FirstName).ToList();

            }
        }
        #endregion

    }
}
