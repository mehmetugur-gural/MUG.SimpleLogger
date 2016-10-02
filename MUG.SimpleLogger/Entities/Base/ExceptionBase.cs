using System;

namespace MUG.SimpleLogger.Entities.Base
{
    public abstract class ExceptionBase
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
