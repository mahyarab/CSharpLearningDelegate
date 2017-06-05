using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Video v1 = new Video() { Title = "Video 1" };
            VideoEncoder encoder = new VideoEncoder(); //Publish the event after encoded
            MailService mail = new MailService(); //Subscribe the event  
            SmsService sms = new SmsService();
            encoder.VideoEncoded += mail.OnVideoEncoded;
            encoder.VideoEncoded += sms.OnVideoEncoded;
            encoder.Encode(v1);
            Console.ReadKey();
        }
    }    
}
