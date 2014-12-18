using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using OmniCodedUITest.Config;



namespace OmniCodedUITest.Libraries
{
    public class PersonifyInstance
    {
        #region PersonifyInstance properties
        // Instance of process
        static Process pinstance;
        public static Process PInstance
        {
            get
            {                
                return pinstance;
            }
            set
            {
                pinstance = value;
            }
        }
        #endregion
       
        #region Helper methods
        /// <summary>
        /// Close the process
        /// </summary>
        public static void Close()
        {
            pinstance.Kill();
        }              
              
        /// <summary>
        /// Check whether process with name existed in task manager
        /// </summary>
        public static bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        

        /// <summary>
        /// Find and kill process by process name
        /// </summary>
        public static bool FindAndKillProcess(string name)
        {
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                //now we're going to see if any of the running processes
                //match the currently running processes by using the StartsWith Method,
                //this prevents us from incluing the .EXE for the process we're looking for.
                //. Be sure to not
                //add the .exe to the name you provide, i.e: NOTEPAD,
                //not NOTEPAD.EXE or false is always returned even if
                //notepad is running
                if (clsProcess.ProcessName.StartsWith(name))
                {
                    //since we found the proccess we now need to use the
                    //Kill Method to kill the process. Remember, if you have
                    //the process running more than once, say IE open 4
                    //times the loop thr way it is now will close all 4,
                    //if you want it to just close the first one it finds
                    //then add a return; after the Kill
                    clsProcess.Kill();
                    //process killed, return true
                    return true;
                }
            }
            //process not found, return false
            return false;
        }

        /// <summary>
        /// Start process by execute full file name
        /// </summary>
        public static void start(string path, string filename, string processname)
        {
            if (IsProcessOpen(processname))
            {
                FindAndKillProcess(processname);
            }
            Directory.SetCurrentDirectory(path);
            pinstance = Process.Start(path + "\\" + filename);
            
        }

        
        #endregion
    }
}
