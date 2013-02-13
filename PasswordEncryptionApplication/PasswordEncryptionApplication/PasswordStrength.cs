
//Contains method for determining password strength.
// Method is called on AddEditForm passes string entered in 
// textbox3 into CheckThePasswordStrength returns int score based
// on the following parameters : length,contains a number, contains both
// an upper and a lowercase letter, contains a special character
// Its pretty freaking genius.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PasswordEncryptionApplication.Model
{
  public class PasswordStrength
    {

        public static int checkStrength(string password)
        {
            int score = 1;
            
            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //both, lower and upper case
                score++;
            if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
                score++;
            return score;

            

        }
    }
}
