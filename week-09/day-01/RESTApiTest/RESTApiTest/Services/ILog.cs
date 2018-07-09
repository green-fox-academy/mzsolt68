using RESTApiTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiTest.Services
{
    public interface ILog
    {
        void WriteToLog(Log newEntry);
        List<Log> GetLogEntries();
    }
}
