using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Threading.Tasks;
using OmniCodedUITest.Resources;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace OmniCodedUITest.Config
{
    class PlaybackConfig
    {
        /// <summary>
        /// Set ThinkTimeMultiplier Playback Option
        /// </summary>
        public static void SetThinkTimeMultiplier()
        {
            Playback.PlaybackSettings.ThinkTimeMultiplier = 2.0;
        }
        /// <summary>
        /// Set SmartMatchOptions Playback Option
        /// </summary>
        public static void SetSmartMatchOptions()
        {
            Playback.PlaybackSettings.SmartMatchOptions = SmartMatchOptions.None;
        }
        /// <summary>
        /// Set SearchInMinimizedWindows Playback Option
        /// </summary>
        public static void SetSearchInMinimizedWindows()
        {
            Playback.PlaybackSettings.SearchInMinimizedWindows = Convert.ToBoolean(PlaybackConfiguration.SearchInMinimizedWindows);
        }
        /// <summary>
        /// Set MatchExactHierarchy Playback Option
        /// </summary>
        public static void SetMatchExactHierarchy()
        {
            Playback.PlaybackSettings.MatchExactHierarchy = Convert.ToBoolean(PlaybackConfiguration.MatchExactHierarchy);
        }
        /// <summary>
        /// Set ContinueOnError Playback Option
        /// </summary>
        public static void SetContinueOnError()
        {
            Playback.PlaybackSettings.ContinueOnError = Convert.ToBoolean(PlaybackConfiguration.ContinueOnError);
        }

        /// <summary>
        /// Set the SearchTimeOut Playback Option
        /// </summary>
        public static void SetThinkSearchTimeOut()
        {
            Playback.PlaybackSettings.SearchTimeout = Convert.ToInt32(PlaybackConfiguration.SearchTimeOut);
        }

        
        /// <summary>
        /// Set the WaitForReadyTimeOut Playback Option
        /// </summary>
        public static void SetWaitForReadyTimeout()
        {
            Playback.PlaybackSettings.WaitForReadyTimeout = Convert.ToInt32(PlaybackConfiguration.WaitForReadyTimeOut);
        }

        /// <summary>
        /// Set the WaitForReadyLevel Playback Option
        /// </summary>
        public static void SetWaitForReadyLevel()
        {
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
        }

        /// <summary>
        /// Remove the ErrorHandler Playback Option
        /// </summary>
        public static void RemoveErrorHandler()
        {
            Playback.PlaybackError -= Playback_PlaybackError;
        }

        /// <summary>
        /// Add the ErrorHandler Playback Option
        /// </summary>
        public static void AddErrorHandler()
        {
            Playback.PlaybackError += Playback_PlaybackError;
        }

        /// <summary> 
        /// PlaybackError event handler. 
        /// </summary>
        private static void Playback_PlaybackError(object sender, PlaybackErrorEventArgs e)
        {
            // Wait a second
            System.Threading.Thread.Sleep(Convert.ToInt32(PlaybackConfiguration.SearchTimeOut));

            // Retry the failed test operation
            e.Result = PlaybackErrorOptions.Retry;
        }

        /// <summary>
        /// Set the ShouldSearchFailFast Playback Option
        /// </summary>
        public static void SetShouldSearchFailFast()
        {
            Playback.PlaybackSettings.ShouldSearchFailFast = Convert.ToBoolean(PlaybackConfiguration.ShouldSearchFailFast);            
        }

        /// <summary>
        /// Set the DelayBetweenActions Playback Option
        /// </summary>
        public static void SetDelayBetweenActions()
        {
            Playback.PlaybackSettings.DelayBetweenActions = Convert.ToInt32(PlaybackConfiguration.DelayBetweenActions);
        }

        /// <summary>
        /// Set the WaitForReadyTimeOut Playback Option
        /// </summary>
        /// <param name="timeout"></param>
        public static void SetWaitForReadyTimeoutInstaller()
        {
            Playback.PlaybackSettings.WaitForReadyTimeout = Convert.ToInt32(PlaybackConfiguration.WaitForReadyTimeOut_Installer);
        }

        /// <summary>
        /// Reset Playback Settings to Default
        /// </summary>
        public static void ResetPlaybackSettings()
        {
            Playback.PlaybackSettings.ResetToDefault();
        }

    }
}
