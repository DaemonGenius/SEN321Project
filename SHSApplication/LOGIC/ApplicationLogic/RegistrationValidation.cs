using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class RegistrationValidation
    {
        public RegistrationValidation() { }

        public void validateRegister()
        {
            // regex for cell (\+27|0)((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})
            // regex for names ^[\p{L}\s'.-]+$
            // regex ID        ^\d{13}$
            // regex DOB       ^\d{4}$|^\d{4}-((0?\d)|(1[012]))-(((0?|[12])\d)|3[01])$
            // regex card Num  \d{4}-?\d{4}-?\d{4}-?\d{4}
            // card type       ^[\d{4}\s'.-]+$
            // CVC              ^\d{3}$
        }
    }
}
