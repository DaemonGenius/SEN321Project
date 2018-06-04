using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class PersonUpdateApp
    {
        public async Task<People> UpdatePerson(People person)
        {
            return await BusinessLogic.AdminProcesses.UpdatePerson(person);

        }

        public async Task<Billinginfoe> UpdateBil(Billinginfoe billinginfoe)
        {
            return await BusinessLogic.AdminProcesses.UpdateBillinginfoe(billinginfoe);
        }
    }
}
