using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class RegisterValidation
    {
        public RegisterValidation() { }
        BusinessLogic.LoginProcess LoginProcess = new BusinessLogic.LoginProcess();
        
        // Name        ^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$
        // ID          ^\d{13}$
        // DOB         ^\d{1,2}\/\d{1,2}\/\d{4}$
        
        // cell         0((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})
        // ZipCode      \d{4}
        // StreetNum    \d{4}
        // CardName     ^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$
        // CardNum     \d{4}-?\d{4}-?\d{4}-?\d{4}
        public bool EmailValidation(string Email, string pass)
        {
            Regex r = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            if (r.IsMatch(Email))
            {
                LoginProcess.Login(Email,pass);
                DepartmentType();
                return true;
            }
            else
                
            return false;
        }

        public string DepartmentType()
        {
            string Department = null;
            
            if (LoginProcess.PortalType() == "Client")
            {
                Department = "Client";
            }
            else if (LoginProcess.PortalType() == "Admin")
            {
                Department = "Admin";
            }
            else if (LoginProcess.PortalType() == "Employee")
            {
                Department = "Employee";
            }

            return Department;
        }
    }
}
