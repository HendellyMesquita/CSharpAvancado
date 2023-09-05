using _00_Biblioteca;

namespace _08_DelegatesMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            btnEnviarVideo.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Ola teste");
            };
        }

    }
}