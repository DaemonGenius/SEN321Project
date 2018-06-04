using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class WarrentyLoadApp
    {
        public static List<string> WarrentyLoad()
        {
            return BusinessLogic.WarrentyLoad.Warrenty();
        }

        public async Task<Warrenty> GetWarrentyDetail(string Duration)
        {
            return await BusinessLogic.WarrentyLoad.GetWarrentyAsync(Duration);
        }
    }
}
