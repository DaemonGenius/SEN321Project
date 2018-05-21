using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public static class AdminProcesses
    {
        public static async Task<People> GetAllEmployees()
        {
            using (var db = new SHSdb())
            {
                People person = (People)db.peoples.Select((x => x.EmailAddress == "Employee"));
                return person;                

            }
        }
        public static async Task<People> UpdatePerson(People person)
        {
            using (var db = new SHSdb())
            {
                People existing =  db.peoples.FirstOrDefault(x => x.ID == person.ID);
                if (existing == null) { throw new KeyNotFoundException(); }
                existing.ID = person.ID;
                existing.FirstName = person.FirstName;
                existing.LastName = person.LastName;
                existing.Gender = person.Gender;
                existing.DOB = person.DOB;
                existing.Address.City = person.Address.City;
                existing.Address.Country = person.Address.Country;
                existing.Address.Zipcode = person.Address.Zipcode;
                existing.Address.StreetNum = person.Address.StreetNum;
                existing.Address.Street = person.Address.Street;
                existing.Address.Province = person.Address.Province;
                existing.Billinginfoes = (from Bilinfo in person.Billinginfoes
                                          select new Billinginfoe
                                          {
                                              CardName = Bilinfo.CardName,
                                              CardNum = Bilinfo.CardNum,
                                              CardCVV = Bilinfo.CardCVV,
                                              CardExpireDate = Bilinfo.CardExpireDate,
                                              CardType = Bilinfo.CardType,
                                          }).ToEntitySet();


                db.SubmitChanges();
                return existing;
            }
        }
    }
}
