using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVerifier.Types
{
    public struct Log
    {
        string logtext;
        byte logType;

        public Log(string logtext, byte logType)
        {
            if (logtext.Length > 128)
                logtext.Remove(127, logtext.Length - 128);
            this.logtext = logtext;
            this.logType = logType;
        }
    }
}
