﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using com.stcs.spa.vo;
using Newtonsoft.Json.Linq;

namespace STCS_SPA2.Services
{
    public interface SPServices
    {
         void handleEvent(string EventStr);
         bool? validateUser(long? userId);
         void processEvent(object data);
    }

   
}