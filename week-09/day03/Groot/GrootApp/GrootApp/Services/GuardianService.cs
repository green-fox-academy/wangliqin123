using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using GrootApp.Models;

namespace GrootApp.Services
{
    public class GuardianService
    {
        internal IGuardian CheckGroot(string message)
        {
            if (message == null)
            {
                return new ErrorMessage();
            }
            else
            {
                return new OkMessage() { Received = message };
            }
        }
    }
}
