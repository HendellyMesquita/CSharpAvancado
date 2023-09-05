using _00_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Eventos
{
    public class ServicoEnviarMensagem
    {
        public void EnviarMensagem(Videos video)
        {
            EnviarSms(video);
            EnviarEmail(video);
        }
        public void EnviarSms(Videos video)
        {
            Console.WriteLine($"Sms Portando Video {video.Titulo} Com formato {video.Formato} Enviado para {video.NomeCliente}");
        }
        public void EnviarEmail(Videos video)
        {
            Console.WriteLine($"Email Portando Video {video.Titulo} Com formato {video.Formato} Enviado para {video.NomeCliente}");
        }

        public void EnviarMensagemArgs(object sender, VideoEventArgs args)
        {
            EnviarSmsArgs(sender, args) ;
            EnviarEmailArgs(sender, args);
        }

        public void EnviarSmsArgs(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"Sms Portando Video {args.Video.Titulo} Com formato {args.Video.Formato} Enviado para {args.Video.NomeCliente}");
        }
        public void EnviarEmailArgs(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"Email Portando Video {args.Video.Titulo} Com formato {args.Video.Formato} Enviado para {args.Video.NomeCliente}");
        }
    }
}
