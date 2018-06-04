using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public static class WarrentyLoad
    {
        public static List<string> Warrenty()
        {
            using (var dbe = new SHSdb())
            {
                return dbe.warrenties.Select(x => x.Duration).ToList();
            }
        }

        public async static Task<Warrenty> GetWarrentyAsync(string Duration)
        {
            using (var dbe = new SHSdb())
            {
                Warrenty warrenty = dbe.warrenties.FirstOrDefault((x => x.Duration == Duration));
                return new Warrenty()
                {
                    ID = warrenty.ID,
                    Discription = warrenty.Discription,
                    Duration = warrenty.Duration,
                    Type = warrenty.Type,
                };
            }
        }
    }
}
