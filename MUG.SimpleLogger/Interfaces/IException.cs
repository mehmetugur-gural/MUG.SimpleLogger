using MUG.SimpleLogger.Entities.Abstract;

namespace MUG.SimpleLogger.Interfaces
{
    interface IException
    {
        void LogException(ExceptionDetail exception, IExceptionService exceptionService);
    }
}
