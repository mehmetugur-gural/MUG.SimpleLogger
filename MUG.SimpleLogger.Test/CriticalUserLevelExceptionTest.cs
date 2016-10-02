using MUG.SimpleLogger.Entities.Abstract;
using MUG.SimpleLogger.Exceptions;
using MUG.SimpleLogger.Service;
using System;

namespace MUG.SimpleLogger.Test
{
    public class CriticalUserLevelExceptionTest
    {
        public void RunTest()
        {
            ExceptionDetail exceptionMessage = new ExceptionDetail()
            {
                CreatedDate = DateTime.Now,
                ID = new Random().Next(1, 100),
                Message = "CriticalUserLevelException Message",
                FriendlyDescription = "CriticalUserLevelException Description",
                StackTrace = "CriticalUserLevelException StackTrace"
            };

            var criticalUserLevelException = new CriticalUserLevelException();
            criticalUserLevelException.LogException(exceptionMessage, new ExceptionService());
        }
    }
}