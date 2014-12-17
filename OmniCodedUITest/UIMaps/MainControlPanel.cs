namespace OmniCodedUITest.UIMaps.MainControlPanelClasses
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

    
    public partial class MainControlPanel
    {
        #region ControlPanel Controls
        public WpfButton xButton;
        public WpfToggleButton startCall;
        public WpfToggleButton joinCall;
        public WpfToggleButton recording;
        public WpfButton newCall;
        public WpfButton recentCall;
        public WpfText joinURL;
        public WpfButton newRecording;
        public WpfButton recentRecording;
        #endregion
        #region Constructor
        public MainControlPanel()
        {
            xButton = UIMainControlPanel.UICloseButton;
            startCall = UIMainControlPanel.UIJoinCallToggleButton;
            newCall = UIMainControlPanel.UINewCallButton;
            recentCall = UIMainControlPanel.UIRecentCallsButton;
            joinCall = UIMainControlPanel.UIJoinCallToggleButton;
            joinURL = UIMainControlPanel.UIMeetingLinkEdit;
            recording = UIMainControlPanel.UIScreenRecordingToggleButton;
            newRecording = UIMainControlPanel.UINewRecordingButton;
            recentRecording = UIMainControlPanel.UIPreviousButton;
        }
        #endregion
    }
}
