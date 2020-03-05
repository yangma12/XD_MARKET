using System;
using System.Collections.Generic;
using System.Text;
using xiaodingmarket_Domain_core.Events;

namespace xiaodingmarket_Domain_core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        //public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        //public abstract bool IsValid();
    }
}
