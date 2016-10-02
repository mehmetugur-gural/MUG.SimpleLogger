using MUG.SimpleLogger.Entities.Abstract;
using MUG.SimpleLogger.Exceptions;
using MUG.SimpleLogger.Service;
using System;

namespace MUG.SimpleLogger.Test
{
    public class CoreLevelExceptionTest
    {
        public void RunTest()
        {
            ExceptionDetail exceptionMessage = new ExceptionDetail()
            {
                CreatedDate = DateTime.Now,
                ID = new Random().Next(1, 100),
                Message = "CoreLevelException Message",
                FriendlyDescription = "CoreLevelException Description",
                StackTrace = "CoreLevelException StackTrace"
            };

            var coreLevelException = new CoreLevelException();
            coreLevelException.LogException(exceptionMessage, new ExceptionService());
        }
    }
}