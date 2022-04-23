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
    public interface IRemoteOPApi : IHttpApi
    {
        [HttpPost("RemoteOP/AllClientsDoAction")]
        Task AllClientsDoActionAsync([JsonContent] WebsocketAction body, CancellationToken cancellationToken = default);

        [HttpPost("RemoteOP/AppClientsDoAction")]
        Task AppClientsDoActionAsync(string appId, string env, [JsonContent] WebsocketAction body, CancellationToken cancellationToken = default);

        [HttpPost("RemoteOP/OneClientDoAction")]
        Task OneClientDoActionAsync(string clientId, [JsonContent] WebsocketAction body, CancellationToken cancellationToken = default);

        [HttpPost("RemoteOP/ClearConfigServiceCache")]
        Task ClearConfigServiceCacheAsync(CancellationToken cancellationToken = default);

        [HttpPost("RemoteOP/ClearServiceInfoCache")]
        Task ClearServiceInfoCacheAsync(CancellationToken cancellationToken = default);

    }
}