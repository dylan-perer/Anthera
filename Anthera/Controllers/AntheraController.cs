﻿using Anthera_API.Extension;
using Anthera_API.misc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Anthera_API.Controllers
{
    public abstract class AntheraController
    {
        public async Task Action(Func<Task<IActionResult>> action, ILogger logger, string controllerName, string actionName, string httpActionName, object requestObject)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, logger,  controllerName,  actionName,  httpActionName,  requestObject,
                    out int statusCode,
                    out object msg);

            }
        }
    }
}
