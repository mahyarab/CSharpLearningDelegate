﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {            
            Console.WriteLine($"SmsService: sending sms for {e.video.Title}");
        }
    }
}
