using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndEvent
{    
    public class VideoEventArgs: EventArgs
    {
        public Video video { get; set; }
    }
    public class VideoEncoder
    {
        //public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodeEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine($"{video.Title} encoding...");
            Thread.Sleep(3000);
            Console.WriteLine($"{video.Title} done");
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { video = video });
        }
    }
}
