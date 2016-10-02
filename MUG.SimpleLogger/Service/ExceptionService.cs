using System.Collections.Generic;
using MUG.SimpleLogger.Interfaces;
using MUG.SimpleLogger.Entities.Abstract;

namespace MUG.SimpleLogger.Service
{
    public class ExceptionService : IExceptionService
    {
        public void Execute(ExceptionDetail exceptionMessage, List<IPublisher> publishers)
        {
            foreach (IPublisher publisherItem in publishers)
            {
                try
                {
                    publisherItem.Publish(exceptionMessage);
                }
                catch
                {
                    continue;
                }
            }
        }

        public void ExecuteWithFailOver(ExceptionDetail exceptionMessage, List<IPublisher> publishers)
        {
            foreach (IPublisher publisherItem in publishers)
            {
                try
                {
                    publisherItem.Publish(exceptionMessage);
                    break;
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
