﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using xiaodingmarket_Domain_core.Commands;

namespace xiaodingmarket_Domain_core.Bus
{
    /// <summary>
    /// 中介处理程序接口
    /// 可以定义多个处理程序
    /// </summary>
    public interface IMediatorHandler
    {
        /// <summary>
        /// 发布命令，将我们的命令模型发布到中介者模块
        /// </summary>
        /// <typeparam name="T"> 泛型 </typeparam>
        /// <param name="command"> 命令模型，比如RegisterStudentCommand </param>
        /// <returns></returns>
        Task SendCommand<T>(T command) where T : Command;

    }
}
