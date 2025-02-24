using projet0001.Vues;

namespace projet0001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VueProduit();
        }
    }
}
