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
        #region Business Methods
        BusinessLogic.LoginProcess LoginProcess = new BusinessLogic.LoginProcess();
        BusinessLogic.RegistrationProcess RegistrationProcess = new BusinessLogic.RegistrationProcess();
        #endregion

        // Name        @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"@
        // ID          @^\d{13}$
        // DOB         @"^\d{1,2}\/\d{1,2}\/\d{4}$"

        // cell         @"0((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})
        // ZipCode      @"\d{4}"
        // StreetNum    @"\d{4}"
        // CardName     @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"
        // CardNum     @"\d{4}-?\d{4}-?\d{4}-?\d{4}"

        #region Login Validation and Login Rules
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
        #endregion

        #region Regex Register Validation
        public bool EmailRegister(string Email, string pass)
        {
            Regex r = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            if (r.IsMatch(Email))
            {
                LoginProcess.Login(Email, pass);
                DepartmentType();
                return true;
            }
            else

                return false;
        }
        public bool FLNameRegister(string Fname, string Lname)
        {
            Regex r = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
            if (r.IsMatch(Fname) && r.IsMatch(Lname))
            {
                RegisterUser();
                return true;
            }
            else

                return false;
        }
        public bool DOBRegister(string DOB)
        {
            Regex r = new Regex(@"^\d{1,2}\/\d{1,2}\/\d{4}$");
            if (r.IsMatch(DOB))
            {

                return true;
            }
            else

                return false;

        }
        public bool IDRegister(string SSID)
        {
            Regex r = new Regex(@"^\d{ 13 }$");
            if (r.IsMatch(SSID))
            {

                return true;
            }
            else
                return false;
        }
        public bool CellRegister(string cell)
        {
            Regex r = new Regex(@"0((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})");
            if (r.IsMatch(cell))
            {

                return true;
            }
            else
                return false;
        }
        public bool ZipCodeRegister(string Zip)
        {
            Regex r = new Regex(@"\d{4}");
            if (r.IsMatch(Zip))
            {

                return true;
            }
            else
                return false;
        }
        public bool StreetNumRegis(string streetNum)
        {
            Regex r = new Regex(@"\d{4}");
            if (r.IsMatch(streetNum))
            {

                return true;
            }
            else
                return false;
        }
        public bool CardNameRegi(string cardname)
        {
            Regex r = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
            if (r.IsMatch(cardname))
            {

                return true;
            }
            else
                return false;
        }
        public bool CardNumReg(string cardNum)
        {
            Regex r = new Regex(@"\d{4}-?\d{4}-?\d{4}-?\d{4}");
            if (r.IsMatch(cardNum))
            {

                return true;
            }
            else
                return false;
        }
        #endregion

        #region Register User
        public bool RegisterUser()
        {
            string fname, lname, email, cell, pass, DOB, ssid, StreetName, Zipcode, City, Province, Country, cardNum, cardName, cardCVC, cardType, cardExpiryDate;
                int StreetNum;
                                  
            

        }
        #endregion





    }
}
