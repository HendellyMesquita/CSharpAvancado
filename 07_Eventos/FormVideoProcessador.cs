using _00_Biblioteca;

namespace _07_Eventos
{
    public partial class FormVideoProcessador : Form
    {
        public FormVideoProcessador()
        {
            InitializeComponent();
            CriarMenu();

        }

        private void CriarMenu()
        {
            var menuDeMeioDePagamento = new ContextMenuStrip();

            btnEnviarVideo.ContextMenuStrip = menuDeMeioDePagamento;

            var menuEventoClick = btnEnviarVideo.ContextMenuStrip;

            var menuItemEventoClickComEncode = menuEventoClick.Items.Add("Encode");
            menuItemEventoClickComEncode.Click += EventoClickComEncode;

            var menuItemEventoClickComEncodeEventArgs = menuEventoClick.Items.Add("EventArgs");
            menuItemEventoClickComEncodeEventArgs.Click += EventoClickComEncodeEventArgs;

            btnEnviarVideo.ContextMenuStrip = menuEventoClick;

            btnEnviarVideo.Click += delegate (object sender, EventArgs e) { MessageBox.Show("Ola teste"); };
        }

        private void EventoClickComEncodeEventArgs(object sender, EventArgs e)
        {
            Videos videos = new Videos() { Titulo = "Minecraft.webm", Formato = ".webm", NomeCliente = "Viniccios" };

            VideosEncode _videosEncode = new VideosEncode();

            _videosEncode.EncodedEventArgs += new ServicoEnviarMensagem().EnviarMensagemArgs;
            _videosEncode.EncodeEventArgs(videos);
        }

        public void EventoClickComEncode(object sender, EventArgs e)
        {
            Videos videos = new Videos() { Titulo = "Video.Mp4", Formato = "Mp4", NomeCliente = "Luciano" };

            VideosEncode _videosEncode = new VideosEncode();

            _videosEncode.Encoded += new ServicoEnviarMensagem().EnviarMensagem;
            _videosEncode.Encode(videos);


        }

    }
}