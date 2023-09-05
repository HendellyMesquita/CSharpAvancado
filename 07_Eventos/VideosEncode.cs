using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Eventos
{
    public class VideosEncode
    {
        public delegate void VideosEncodeHandler(Videos video);
        public event VideosEncodeHandler Encoded;
        public event EventHandler<VideoEventArgs> EncodedEventArgs;

        public void Encode(Videos video)
        {
            Console.WriteLine("Convertendo ...");
            Thread.Sleep(2000);
            Console.WriteLine("Sucesso ...");
            Encoded(video);
        }

        public void EncodeEventArgs(Videos video)
        {
            Console.WriteLine("Convertendo ...");
            Thread.Sleep(2000);
            Console.WriteLine("Sucesso ...");
            EncodedEventArgs(this, new VideoEventArgs() { Video = video});
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Videos Video { get; set; }
    }
}
