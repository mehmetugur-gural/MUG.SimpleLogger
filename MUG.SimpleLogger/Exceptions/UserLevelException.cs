using MUG.SimpleLogger.Entities.Abstract;
using MUG.SimpleLogger.Interfaces;

namespace MUG.SimpleLogger.Exceptions
{
    public class UserLevelException : IException
    {
        /// <summary>
        /// User Level Exceptions Logic Handler
        /// </summary>
        /// <param name="exceptionMessage"></param>
        public void LogException(ExceptionDetail exceptionMessage, IExceptionService exceptionService)
        {

        }
    }
}
