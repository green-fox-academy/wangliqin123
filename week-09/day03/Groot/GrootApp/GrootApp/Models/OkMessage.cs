using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GrootApp.Models
{
    public class OkMessage : IGuardian
    {
        [JsonProperty("received")]
        public string Received { get; set; }
        [JsonProperty("translated")]
        public string Translated { get; set; } = "I am Groot!";
    }
}
