using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class FileTreatMentException : Exception
    {
        public FileTreatMentException()
        { }

        public FileTreatMentException(string msg)
            : base(msg)
        { }
    }
}
