using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaodingmarket_service.Controllers
{
    
    //public abstract class ApiController : ControllerBase
    //{
    //    private readonly DomainNotificationHandler _notifications;
    //    private readonly IMediatorHandler _mediator;

    //    protected ApiController(INotificationHandler<DomainNotification> notifications,
    //                            IMediatorHandler mediator)
    //    {
    //        _notifications = (DomainNotificationHandler)notifications;
    //        _mediator = mediator;
    //    }

    //    protected IEnumerable<DomainNotification> Notifications => _notifications.GetNotifications();
    //    //判断是否有效
    //    protected bool IsValidOperation()
    //    {
    //        return (!_notifications.HasNotifications());
    //    }

    //    protected new IActionResult Response(object result = null)
    //    {
    //        if (IsValidOperation())
    //        {
    //            return Ok(new
    //            {
    //                success = true,
    //                data = result
    //            });
    //        }

    //        return BadRequest(new
    //        {
    //            success = false,
    //            errors = _notifications.GetNotifications().Select(n => n.Value)
    //        });
    //    }

    //    protected void NotifyModelStateErrors()
    //    {
    //        var erros = ModelState.Values.SelectMany(v => v.Errors);
    //        foreach (var erro in erros)
    //        {
    //            var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
    //            NotifyError(string.Empty, erroMsg);
    //        }
    //    }
    //    //通知报错
    //    protected void NotifyError(string code, string message)
    //    {
    //        _mediator.RaiseEvent(new DomainNotification(code, message));
    //    }

    //    protected void AddIdentityErrors(IdentityResult result)
    //    {
    //        foreach (var error in result.Errors)
    //        {
    //            NotifyError(result.ToString(), error.Description);
    //        }
    //    }
    //}
}
