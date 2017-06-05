using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndEvent
{    
    public class VideoEncoder
    {
        //1- define a delegate
        //2- define an event based on that delegate
        //3- raise event
        public delegate void VideoEncodeEventHandler(object source, EventArgs args);
        public event VideoEncodeEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine($"{video.Title} encoding...");
            Thread.Sleep(3000);
            Console.WriteLine($"{video.Title} done");
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
