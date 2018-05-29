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
        public static async Task<Schedule> GetTechSche(string name)
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.FirstName == name));
                Schedule schedule = dbe.schedules.FirstOrDefault(x => x.TechnicianEmp.Person_ID == person.ID);

                return new Schedule()
                {
                   InsDateStart = schedule.InsDateStart,
                   MainDateStart = schedule.MainDateStart,
                   TechnicianEmp = new TechnicianEmp
                   {
                       People = new People {
                           FirstName = schedule.TechnicianEmp.People.FirstName,
                           LastName = schedule.TechnicianEmp.People.LastName
                       }
                   }
                };
            }
        }
    }
}
