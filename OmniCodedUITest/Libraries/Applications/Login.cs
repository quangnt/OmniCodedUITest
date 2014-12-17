using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniCodedUITest.Libraries
{
    class Login
    {
        public static void EnterUsername(string sname)
        { 
            //Personify.LoginUI
        }
        public static void login(string sname, string spass)
        {
            //mainLogin.PersonifyLogin(sname, spass);
        }

        // Perform login with Personify account
        public void PersonifyLogin(string sname, string spass)
        {
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIUsernameEdit.Text = sname;
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIPasswordEdit.Text = spass;
            //Mouse.Click(this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UISignInButton);
        }

        public static void login(Boolean signedGoogle, string type, string sname, string spass)
        {
            //switch (type)
            //{
            //    case "personify":
            //        mainLogin.PersonifyLogin(sname, spass);
            //        break;
            //    case "google":
            //        googleLogin.GoogleLogin(signedGoogle, sname, spass);
            //        break;
            //}

            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIWarning.GetProperty("IsOffscreen");
        }

        public void GoogleLogin(Boolean signedGoogle, string email, string spass)
        {
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIUsernameEdit.Text = email;
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIPasswordEdit.Text = spass;
            //Mouse.Click(this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UISignInButton);
        }
    }
}
