﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
namespace AgileConfig.UIApiClient
{
    public class PublishLogVM
    {
        [JsonPropertyName("appId")]
        public string AppId { get; set; }

        [JsonPropertyName("log")]
        public string Log { get; set; }

    }
}