using System;
using System.Linq;
using System.Windows.Forms;

namespace EasySleepForMacro
{
    class Program
    {
        static void Main(string[] args)
        {
            var  newLine          = Environment.NewLine;
            bool SleeporHibernate = true; //Set For sleep
            bool WakeEvent        = true; //Disable Software Wake Event
            bool ForceEvent       = true; //Force Sleep Despite Software Interupt

            //Default Operations allows for Software Wake, and Forces Sleep Mode
            if (args == null)
            {
                WakeEvent = false;
            }
            //Help For those who stumble uppon this
                if (args.Contains("Help", StringComparer.OrdinalIgnoreCase))
                {
                    Console.WriteLine(newLine 
                                      + "This is the Help Menu For Peter Bustraan's Easy Sleep Application for Keyboard Macro Usage"
                                      + newLine + "Default Usage forces sleep mode and allows for software wake event"
                                      + newLine + "Sleep:     forces sleep mode and allows software wake event"
                                      + newLine + "Hibernate: forces hybernate and allows for software wake event"
                                      + newLine + "NoWake:    disables software wake event"
                                      + newLine + "Nice:      disables forced power state change"
                                      + newLine + newLine + "Press Any Key to exit");
                    Console.ReadKey();   //Press Any Key
                    Environment.Exit(0); //Close Application
                }
            //Set Options
                if (args.Contains("Sleep", StringComparer.OrdinalIgnoreCase))
                {
                    SleeporHibernate = true;
                    WakeEvent = false;
                }
                if (args.Contains("Hibernate", StringComparer.OrdinalIgnoreCase))
                {
                    SleeporHibernate = false;
                    WakeEvent = false;
                }
                if (args.Contains("NoWake", StringComparer.OrdinalIgnoreCase))
                {
                    WakeEvent = true;
                }
                if (args.Contains("Nice", StringComparer.OrdinalIgnoreCase))
                {
                    ForceEvent = false;
                }
            //Execute Command
                if (SleeporHibernate)
                {
                    Application.SetSuspendState(PowerState.Suspend, ForceEvent, WakeEvent);
                }
                else
                {
                    Application.SetSuspendState(PowerState.Hibernate, ForceEvent, WakeEvent);
                }
        }
    }
}
