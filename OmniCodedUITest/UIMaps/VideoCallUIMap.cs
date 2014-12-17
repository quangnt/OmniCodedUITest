namespace OmniCodedUITest.UIMaps.VideoCallUIMapClasses
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
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

    
    public partial class VideoCallUIMap
    {
        #region Video Text Chat Controls
        public WpfToggleButton videoCallMenu;
        public WpfToggleButton textChatButton;
        public WpfButton shareWindowButton;
        public WpfButton muteVideoButton;
        public WpfToggleButton addMemberButton;
        public WpfButton stopVideoCallButton;    
        #endregion
        #region Constructor
        public VideoCallUIMap()
        {
            videoCallMenu = UIVideoCallControlPanelWindow.UIVideoCallControlPanelMenu;
            textChatButton = UIVideoCallControlPanelWindow.UITextChatButton;
            shareWindowButton = UIVideoCallControlPanelWindow.UIShareWindowButton;
            muteVideoButton = UIVideoCallControlPanelWindow.UIMuteVideoButton;
            addMemberButton = UIVideoCallControlPanelWindow.UIAddMemberButton;
            stopVideoCallButton = UIVideoCallControlPanelWindow.UIStopVideoCallButton;              
        }
        #endregion
    }
}
