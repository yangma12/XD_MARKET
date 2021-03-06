﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using xiaodingmarket_Domain_core.Bus;
using xiaodingmarket_Domain_core.Commands;

namespace Infra_Bus
{
    /// <summary>
    /// 一个密封类，实现我们的中介记忆总线
    /// </summary>
    public sealed class InMemoryBus : IMediatorHandler
    {
        //构造函数注入
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// 实现我们在IMediatorHandler中定义的接口
        /// 没有返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);//这里要注意下 command 对象
        }

    }
}
