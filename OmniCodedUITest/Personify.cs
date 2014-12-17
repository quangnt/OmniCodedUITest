using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniCodedUITest.UIMaps.InstallerUIMapClasses;
using OmniCodedUITest.UIMaps.GoogleSignInUIMapClasses;
using OmniCodedUITest.UIMaps.LoginUIMapClasses;
using OmniCodedUITest.UIMaps.MainControlPanelClasses;
using OmniCodedUITest.UIMaps.SignUpUIMapClasses;
using OmniCodedUITest.UIMaps.VideoCallTextChatUIMapClasses;
using OmniCodedUITest.UIMaps.VideoCallUIMapClasses;

namespace OmniCodedUITest
{
    public class Personify
    {
        #region Personify controls
        private static InstallerUIMap installerUI;
        private static GoogleSignInUIMap googleSignInUI;
        private static MainControlPanel mainControlPanelUI;
        private static SignUpUIMap signUpUI;
        private static VideoCallTextChatUIMap videoCallTextChatUI;
        private static VideoCallUIMap videoCallUI;
        private static LoginUIMap loginUI;
        #endregion
        #region Constructor
        // Initialize Installer Dialog
        public static InstallerUIMap InstallerUI
        {
            get
            {
                if (installerUI == null)
                {
                    installerUI = new InstallerUIMap();
                }
                return installerUI;
            }
            set
            {
                Personify.installerUI = value;
            }
        }

        // Initialize Google Login Dialog
        public static GoogleSignInUIMap GoogleSignInUI
        {
            get
            {
                if (googleSignInUI == null)
                {
                    googleSignInUI = new GoogleSignInUIMap();
                }
                return googleSignInUI;
            }
            set
            {
                Personify.googleSignInUI = value;
            }
        }

        // Initialize Personify Main Control Panel
        public static MainControlPanel MainControlPanelUI
        {
            get
            {
                if (mainControlPanelUI == null)
                {
                    mainControlPanelUI = new MainControlPanel();
                }
                return mainControlPanelUI;
            }
            set
            {
                Personify.mainControlPanelUI = value;
            }
        }

        // Initialize Personify SignUp Dialog
        public static SignUpUIMap SignUpUI
        {
            get
            {
                if (signUpUI == null)
                {
                    signUpUI = new SignUpUIMap();
                }
                return signUpUI;
            }
            set
            {
                Personify.signUpUI = value;
            }
        }

        // Initialize Login Dialog
        public static LoginUIMap LoginUI
        {
            get
            {
                if (loginUI == null)
                {
                    return new LoginUIMap();
                }
                return loginUI;
            }
            set
            {
                Personify.loginUI = value;
            }
        }

        // Initialize Personify Video Call Text Chat Dialog
        public static VideoCallTextChatUIMap VideoCallTextChatUI
        {
            get
            {
                if (videoCallTextChatUI == null)
                {
                    videoCallTextChatUI = new VideoCallTextChatUIMap();
                }
                return videoCallTextChatUI;
            }
            set
            {
                Personify.videoCallTextChatUI = value;
            }
        }

        // Initialize Personify Video Call Dialog
        public static VideoCallUIMap VideoCallUI
        {
            get
            {
                if (videoCallUI == null)
                {
                    videoCallUI = new VideoCallUIMap();
                }
                return videoCallUI;
            }
            set
            {
                Personify.videoCallUI = value;
            }

        }
        #endregion
    }
}
