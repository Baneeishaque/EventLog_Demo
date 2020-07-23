using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EventLog_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sSource;
            string sLog;
            string sEvent;

            sSource = "dotNET Sample App";
            sLog = "Application";
            sEvent = "Sample Event";

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent);
            EventLog.WriteEntry(sSource, sEvent,EventLogEntryType.Warning, 234);
        }
    }
}
