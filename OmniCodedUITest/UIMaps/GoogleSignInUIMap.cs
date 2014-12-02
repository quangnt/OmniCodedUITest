namespace OmniCodedUITest.UIMaps.GoogleSignInUIMapClasses
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    public partial class GoogleSignInUIMap
    {
        public void GoogleLogin(Boolean signedGoogle, string email, string spass)
        {
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIUsernameEdit.Text = email;
            //this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UIPasswordEdit.Text = spass;
            //Mouse.Click(this.UIPersonifyMainLoginWindow.UIPersonifySignInDialog.UISignInButton);
        }
    }
}
