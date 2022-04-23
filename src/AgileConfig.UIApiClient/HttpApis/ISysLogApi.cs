﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;
namespace AgileConfig.UIApiClient
{
    [LoggingFilter]
    public interface ISysLogApi : IHttpApi
    {
        [HttpGet("SysLog/Search")]
        Task Search3Async(string appId, SysLogType? logType, System.DateTimeOffset? startTime, System.DateTimeOffset? endTime, int current, int pageSize, CancellationToken cancellationToken = default);

    }
}