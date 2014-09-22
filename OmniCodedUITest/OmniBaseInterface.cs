namespace OmniCodedUITest
{
    public class OmniBaseInterface
    {
        public OmniBaseInterface()
        {
            mainWindow = new UIMaps.LoginUIMapClasses.LoginUIMap();
        }

        #region Control map object for all UIMaps
        // Main Login Dialog
        private OmniCodedUITest.UIMaps.LoginUIMapClasses.LoginUIMap mainWindow = null;
        public OmniCodedUITest.UIMaps.LoginUIMapClasses.LoginUIMap MainLoginObject
        {
            get
            {
                return mainWindow;
            }
            set
            {
                mainWindow = value;
            }
        }

        // Google Login Dialog
        private OmniCodedUITest.UIMaps.GoogleSignInUIMapClasses.GoogleSignInUIMap googleLogin = null;
        public OmniCodedUITest.UIMaps.GoogleSignInUIMapClasses.GoogleSignInUIMap GoogleLoginObject
        {
            get
            {
                if (googleLogin == null)
                {
                    googleLogin = new UIMaps.GoogleSignInUIMapClasses.GoogleSignInUIMap();
                    //googleLogin
                }
                return googleLogin;
            }
            set
            {
                mainWindow = value;
            }
        }

    }

}
