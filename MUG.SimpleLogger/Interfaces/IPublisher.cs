using MUG.SimpleLogger.Entities.Abstract;

namespace MUG.SimpleLogger.Interfaces
{
    public interface IPublisher
    {
        void Publish(ExceptionDetail exceptionMessage);
    }
}
