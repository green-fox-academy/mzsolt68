using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTApiTest.Model;
using RESTApiTest.Repository;

namespace RESTApiTest.Services
{
    public class LogService : ILog
    {
        private LogDbContext logContext;

        public LogService(LogDbContext context)
        {
            logContext = context;
        }

        public List<Log> GetLogEntries()
        {
            return logContext.Logs.ToList();
        }

        public void WriteToLog(Log newEntry)
        {
            logContext.Logs.Add(newEntry);
            logContext.SaveChanges();
        }
    }
}
