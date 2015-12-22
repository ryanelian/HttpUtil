﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpUtil
{
    /// <summary>
    /// Provides HTTP content based on a JSON-serialized object.
    /// </summary>
    public class JsonContent : StringContent
    {
        /// <summary>
        /// Creates a new instance of JsonContent class.
        /// </summary>
        /// <param name="payload"></param>
        public JsonContent(object payload) : base(JsonConvert.SerializeObject(payload))
        {
            this.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        }
    }
}