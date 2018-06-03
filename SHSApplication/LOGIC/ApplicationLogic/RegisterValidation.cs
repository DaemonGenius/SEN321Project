using DATALAYER.Controllers;
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

        #region Public Lists
        public List<DATALAYER.Controllers.People> peoplelst = new List<DATALAYER.Controllers.People>();
        public string Loggedin, fname, lname, email, cell, pass, DOB, ssid, StreetName, Zipcode, City, Province, Country, cardNum, cardName, cardCVC, cardType, cardExpiryDate;
        public int StreetNum;
        #endregion

        // Name        @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"@
        // ID          @^\d{13}$
        // DOB         @"^\d{1,2}\/\d{1,2}\/\d{4}$"

        // cell         @"^\d{ 13 }$"
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
                Loggedin = LoginProcess.fname;
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
                email = Email;
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
                fname = Fname;
                lname = Lname;
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

        #region validate user
        public bool ValidateUser(string fname, string lname, string email, string cell, string pass, string DOB, string gender, string ssid, string StreetName, string Zipcode,
            string City, string Province, string Country, string cardNum, string cardName, string cardCVC, string cardType, string cardExpiryDate, int StreetNum, string department)
        {
            Regex rEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            Regex rFLname = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
            Regex rDOB = new Regex(@"^\d{1,2}\/\d{1,2}\/\d{4}$");
            Regex rID = new Regex(@"\d{4}");
            Regex rCell = new Regex(@"0((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})");
            Regex rZip = new Regex(@"\d{4}");
            Regex rStreetNu = new Regex(@"\d{4}");
            Regex rCardName = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
            Regex rCardNum = new Regex(@"\d{4}");
            if (rEmail.IsMatch(email))
            {
                if (rFLname.IsMatch(fname) && rFLname.IsMatch(lname))
                {                    
                    if (rDOB.IsMatch(DOB))
                    {
                        if (rID.IsMatch(ssid))
                        {
                            if (rCell.IsMatch(cell))
                            {
                                if (rZip.IsMatch(Zipcode))
                                {
                                    if (rStreetNu.IsMatch(StreetNum.ToString()))
                                    {
                                        if (rCardName.IsMatch(cardName))
                                        {
                                            if (rCardNum.IsMatch(cardNum))
                                            {
                                                RegisterUser(fname,lname,email,cell,pass,DOB,gender,ssid,StreetName,Zipcode,City,Province,
                                                    Country,cardNum,cardName,cardCVC,cardType,cardExpiryDate,StreetNum,department);
                                                return true;
                                            }
                                            else
                                               
                                                return false;                                           
                                        }
                                        else
                                            return false;                                      
                                    }
                                    else
                                        return false;                                   
                                }
                                else
                                    return false;                               
                            }
                            else
                                return false;                            
                        }
                        else
                            return false;                        
                    }
                    else
                        return false;                    
                }
                else
                    return false;                
            }
            else
                return false;
        }
        #endregion

        #region Register User
        public bool RegisterUser(string fname, string lname, string email, string cell, string pass, string DOB,string gender, string ssid, string StreetName, string Zipcode,
            string City, string Province, string Country, string cardNum, string cardName, string cardCVC, string cardType, string cardExpiryDate, int StreetNum, string department)
        {
            
            Billinginfoe billinginfoe = new Billinginfoe
            {
                People = new People
                {
                    FirstName = fname,
                    LastName = lname,
                    EmailAddress = email,
                    Password = pass,
                    CellNumber = cell,
                    Department = department,
                    SSID = ssid,
                    DOB = DOB,
                    Gender = gender,
                    Address = new Address
                    {
                        Street = StreetName,
                        StreetNum = StreetNum,
                        Zipcode = Zipcode,
                        Province = Province,
                        Country = Country
                    },
                },
                CardName = cardName,
                CardNum = cardNum,
                CardCVV = cardCVC,
                CardExpireDate = cardExpiryDate,
                CardType = cardType
            };
            RegistrationProcess.RegisterUser(billinginfoe);
            if (department == "Client")
            {
                var client = new Client()
                {
                    Person_ID = billinginfoe.People.ID,                
                };
                RegistrationProcess.RegisterClient(client);
            }
            else
            if (department == "Admin")
            {
                var admin = new Admin()
                {
                    person_ID = billinginfoe.People.ID,
                };
                RegistrationProcess.RegisterAdmin(admin);
            }
            else
            if (department == "Technician")
            {
                var technician = new TechnicianEmp()
                {
                    Person_ID = billinginfoe.People.ID,
                };
                RegistrationProcess.RegisterTech(technician);
            }
            else
            if (department == "Sales")
            {
                var sales = new Sale_Emp()
                {
                    Person_ID = billinginfoe.People.ID,
                };
                RegistrationProcess.RegisterSales(sales);
            }




            return true;
        }
        #endregion





    }
}
