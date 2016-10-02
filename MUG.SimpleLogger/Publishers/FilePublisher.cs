using System;
using MUG.SimpleLogger.Entities.Abstract;
using MUG.SimpleLogger.Interfaces;

namespace MUG.SimpleLogger.Publishers
{
    public class FilePublisher : IPublisher
    {
        public void Publish(ExceptionDetail exceptionMessage)
        {
            //Publish Logic Added Here.
            throw new NotImplementedException();
        }
    }
}