namespace OmniCodedUITest.UIMaps.VideoCallTextChatUIMapClasses
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

    
    public partial class VideoCallTextChatUIMap
    {
        #region Video Text Chat Controls
        public WpfEdit textChatEdit;
        public WpfButton textChatUploadButton;
        public WpfButton textChatConversationButton;       
        #endregion
        #region Constructor
        public VideoCallTextChatUIMap()
        {
            textChatEdit = UITextChatDialog.UITextChatForm.UITextChatEdit;
            textChatUploadButton = UITextChatDialog.UITextChatForm.UIUploadfileButton;
            textChatConversationButton = UITextChatDialog.UITextChatForm.UIConversationButton;            
        }
        #endregion
    }
}
