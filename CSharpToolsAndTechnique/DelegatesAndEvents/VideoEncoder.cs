using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToolsAndTechnique.DelegatesAndEvents;

public class VideoEncoder
{

    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

    public event VideoEncodedEventHandler VideoEncoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding Video......");
        Thread.Sleep(3000);

        onVideoEncoded(video);
    }

    protected virtual void onVideoEncoded(Video video)
    {
        if (VideoEncoded is not null)
            VideoEncoded(this, new VideoEventArgs() { video=video});
    }
}

public class Video
{
    public string Title { get; set; }
}

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: Sending an Email......." + e.video.Title);
    }

}

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("Message Services: Sending a Text Message......." + e.video.Title);
    }
}

public class VideoEventArgs: EventArgs
{
    public Video video { get; set; }
}

public class VideoEncoderImplementation
{
    public void Implementation()
    {
        var video = new Video() { Title="Video 1"};

        var videoEncoder = new VideoEncoder(); // Publisher

        var mailservice= new MailService(); // Subscriber

        var messageservice= new MessageService(); // Subscriber

        videoEncoder.VideoEncoded += mailservice.OnVideoEncoded;

        videoEncoder.VideoEncoded += messageservice.OnVideoEncoded;

        videoEncoder.Encode(video);
    }
}
