using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                existing.SSID = person.SSID;
                existing.DOB = person.DOB;
                existing.Address.City = person.Address.City;
                existing.Address.Country = person.Address.Country;
                existing.Address.Zipcode = person.Address.Zipcode;
                existing.Address.StreetNum = person.Address.StreetNum;
                existing.Address.Street = person.Address.Street;
                existing.Address.Province = person.Address.Province;


                db.SubmitChanges();
                MessageBox.Show("Updated");
                return existing;
            }
        }
        public static async Task<Billinginfoe> UpdateBillinginfoe(Billinginfoe billinginfoe)
        {
            using (var db = new SHSdb())
            {
                Billinginfoe existing = db.BillingInfo.FirstOrDefault(x => x.Person_ID == billinginfoe.Person_ID);
                if (existing == null) { throw new KeyNotFoundException(); }
                //existing.ID = billinginfoe.ID;
                existing.CardName = billinginfoe.CardName;
                existing.CardCVV = billinginfoe.CardCVV;
                existing.CardExpireDate = billinginfoe.CardExpireDate;
                existing.CardType = billinginfoe.CardType;
                existing.Person_ID = billinginfoe.Person_ID;
                db.SubmitChanges();
                return existing;
            }
        }
    }
}
