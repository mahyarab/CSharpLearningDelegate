using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("SmsService: sending sms");
        }
    }
}
