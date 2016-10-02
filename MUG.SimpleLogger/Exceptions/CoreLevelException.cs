using MUG.SimpleLogger.Entities.Abstract;
using MUG.SimpleLogger.Interfaces;
using MUG.SimpleLogger.Publishers;
using System;
using System.Collections.Generic;

namespace MUG.SimpleLogger.Exceptions
{
    public class CoreLevelException : IException
    {
        /// <summary>
        /// Core Level Exception Logic Handler
        /// </summary>
        /// <param name="exceptionMessage"></param>
        public void LogException(ExceptionDetail exceptionMessage, IExceptionService exceptionService)
        {
            var publishers = new List<IPublisher>();
            publishers.Add(new DBPublisher());
            publishers.Add(new FilePublisher());
            publishers.Add(new MailPublisher());
            publishers.Add(new EventLogPublisher());

            exceptionService.Execute(exceptionMessage, publishers);
        }

    }
}
