using System.Net;

namespace _09_Task
{
    public partial class FormDownloadWeb : Form
    {
        private  WebClient webClient = new WebClient();
        public FormDownloadWeb()
        {
            InitializeComponent();
            CriarMenu();

        }
        private void CriarMenu()
        {
            var menuDeMeioDePagamento = new ContextMenuStrip();

            btnDownload.ContextMenuStrip = menuDeMeioDePagamento;

            var menuEventoClick = btnDownload.ContextMenuStrip;

            var menuItemEventoClickComEncode = menuEventoClick.Items.Add("html Synchrono");
            menuItemEventoClickComEncode.Click += EventoClickDownloadString;

            var menuItemEventoClickComEncodeEventArgs = menuEventoClick.Items.Add("html Asynchrono");
            menuItemEventoClickComEncodeEventArgs.Click += EventoClickDownloadStringAsync;

            btnDownload.ContextMenuStrip = menuEventoClick;

        }

        private void EventoClickDownloadString(object? sender, EventArgs e)
        {
            // Metodo Synchrono :nescessita esperar o processamento para
            // permitir a continuidade ao processamento ou utilziação do sistema
            var url = txbSite.Text;

            var htmlSynchrono = webClient.DownloadString(url);
            rtbResultado.Text = htmlSynchrono;
        }

        private async void EventoClickDownloadStringAsync(object? sender, EventArgs e)
        {

            // Metodo Asynchrono: utiliza thread que permite realizar outros processos enquanto o download está em execução        }

            var url = txbSite.Text;

            var htmlAsynchrono = await webClient.DownloadStringTaskAsync(new Uri(url));
            rtbResultado.Text = htmlAsynchrono;

        }

    }
}