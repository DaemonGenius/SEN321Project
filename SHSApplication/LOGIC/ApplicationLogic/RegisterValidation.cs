using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class RegisterValidation
    {
        public RegisterValidation() { }
        // Name        ^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$
        // ID          ^\d{13}$
        // DOB         ^\d{1,2}\/\d{1,2}\/\d{4}$
        // Email
        // cell         0((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})
        // ZipCode      \d{4}
        // StreetNum    \d{4}
        // CardName     ^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$
        // CardNum     \d{4}-?\d{4}-?\d{4}-?\d{4}

    }
}
