using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;

namespace OmniCodedUITest
{
    public class OmniBaseInterface
    {
        public OmniBaseInterface()
        {
            mainLogin = new UIMaps.LoginUIMapClasses.LoginUIMap();
        }

        #region Control map object for all UIMaps

        // Initialize Google Login Dialog
        private OmniCodedUITest.UIMaps.GoogleSignInUIMapClasses.GoogleSignInUIMap googleLogin = null;
        public OmniCodedUITest.UIMaps.GoogleSignInUIMapClasses.GoogleSignInUIMap GoogleLoginObject
        {
            get
            {
                if (googleLogin == null)
                {
                    googleLogin = new UIMaps.GoogleSignInUIMapClasses.GoogleSignInUIMap();
                }
                return googleLogin;
            }
            set
            {
                googleLogin = value;
            }
        }

        // Initialize Installer Dialog
        private OmniCodedUITest.UIMaps.InstallerUIMapClasses.InstallerUIMap personifyInstaller = null;
        public OmniCodedUITest.UIMaps.InstallerUIMapClasses.InstallerUIMap personifyInstallerObject
        {
            get
            {
                if (personifyInstaller == null)
                {
                    personifyInstaller = new UIMaps.InstallerUIMapClasses.InstallerUIMap();
                }
                return personifyInstaller;
            }
            set
            {
                personifyInstaller = value;
            }
        }

        // Initialize Main Login Dialog
        private OmniCodedUITest.UIMaps.LoginUIMapClasses.LoginUIMap mainLogin = null;
        public OmniCodedUITest.UIMaps.LoginUIMapClasses.LoginUIMap MainLoginWindowObject
        {
            get
            {
                return mainLogin;
            }
            set
            {
                mainLogin = value;
            }
        }
                

        // Initialize Personify Main Control Panel
        private OmniCodedUITest.UIMaps.MainControlPanelClasses.MainControlPanel personifyMainControlPanel = null;
        public OmniCodedUITest.UIMaps.MainControlPanelClasses.MainControlPanel personifyMainControlPanelObject
        {
            get
            {
                if (personifyMainControlPanel == null)
                {
                    personifyMainControlPanel = new UIMaps.MainControlPanelClasses.MainControlPanel();
                }
                return personifyMainControlPanel;
            }
            set
            {
                personifyMainControlPanel = value;
            }
        }

        // Initialize Personify SignUp Dialog
        private OmniCodedUITest.UIMaps.SignUpUIMapClasses.SignUpUIMap personifySignup = null;
        public OmniCodedUITest.UIMaps.SignUpUIMapClasses.SignUpUIMap PersonifySignupObject
        {
            get
            {
                if (personifySignup == null)
                {
                    personifySignup = new UIMaps.SignUpUIMapClasses.SignUpUIMap();
                }
                return personifySignup;
            }
            set
            {
                personifySignup = value;
            }
        }

        // Initialize Personify Video Call Text Chat Dialog
        private OmniCodedUITest.UIMaps.VideoCallTextChatUIMapClasses.VideoCallTextChatUIMap videoCallTextChat = null;
        public OmniCodedUITest.UIMaps.VideoCallTextChatUIMapClasses.VideoCallTextChatUIMap videoCallTextChatObject
        {
            get
            {
                if (videoCallTextChat == null)
                {
                    videoCallTextChat = new UIMaps.VideoCallTextChatUIMapClasses.VideoCallTextChatUIMap();
                }
                return videoCallTextChat;
            }
            set
            {
                videoCallTextChat = value;
            }
        }

        // Initialize Personify Video Call Dialog
        private OmniCodedUITest.UIMaps.VideoCallUIMapClasses.VideoCallUIMap videoCallControlPanel = null;
        public OmniCodedUITest.UIMaps.VideoCallUIMapClasses.VideoCallUIMap videoCallControlPanelObject
        {
            get
            {
                if (videoCallControlPanel == null)
                {
                    videoCallControlPanel = new UIMaps.VideoCallUIMapClasses.VideoCallUIMap();
                }
                return videoCallControlPanel;
            }
            set
            {
                videoCallControlPanel = value;
            }
        }
        #endregion


        #region Helper methods
        public void login(string sname, string spass)
        {
            mainLogin.Login(sname, spass);
        }
        public void chat()
        {
            personifyMainControlPanelObject.Chat("adfbsd");

        }
        #endregion

    }
}
