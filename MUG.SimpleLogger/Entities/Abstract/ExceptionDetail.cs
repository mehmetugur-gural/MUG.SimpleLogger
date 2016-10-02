using MUG.SimpleLogger.Entities.Base;

namespace MUG.SimpleLogger.Entities.Abstract
{
    public class ExceptionDetail : ExceptionBase
    {
        public string FriendlyDescription { get; set; }
        public string StackTrace { get; set; }
    }
}
