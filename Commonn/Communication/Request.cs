using System;

namespace Commonn.Communication
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object Argument { get; set; }

        public Request() { }
        public Request(Operation operation, object argument)
        {
            Operation = operation;
            Argument = argument;
        }
    }
}
