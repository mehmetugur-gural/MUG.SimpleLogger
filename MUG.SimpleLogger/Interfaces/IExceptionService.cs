using MUG.SimpleLogger.Entities.Abstract;
using System.Collections.Generic;

namespace MUG.SimpleLogger.Interfaces
{
    public interface IExceptionService
    {
        void Execute(ExceptionDetail exceptionMessage, List<IPublisher> publishers);
        void ExecuteWithFailOver(ExceptionDetail exceptionMessage, List<IPublisher> publishers);
    }
}
