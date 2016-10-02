using MUG.SimpleLogger.Entities.Abstract;
using MUG.SimpleLogger.Interfaces;
using MUG.SimpleLogger.Publishers;
using System;
using System.Collections.Generic;

namespace MUG.SimpleLogger.Exceptions
{
    public class CriticalUserLevelException : IException
    {
        /// <summary>
        /// CriticalUserLevel Exception Logic Handler
        /// </summary>
        /// <param name="exceptionMessage"></param>
        public void LogException(ExceptionDetail exceptionMessage, IExceptionService exceptionService)
        {
            var publishers = new List<IPublisher>();
            publishers.Add(new MailPublisher());
            publishers.Add(new FilePublisher());
            publishers.Add(new EventLogPublisher());

            exceptionService.ExecuteWithFailOver(exceptionMessage, publishers);
        }
    }
}