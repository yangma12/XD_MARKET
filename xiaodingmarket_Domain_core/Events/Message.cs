using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace xiaodingmarket_Domain_core.Events
{
    //IRequest来抽象单播消息,子类为消息请求
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
