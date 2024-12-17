using System.Windows.Forms;

namespace ProNatur_BioMarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, System.EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, System.EventArgs e)
        {

            loadingBarValue += 1;

            lblLoadingBarProgress.Text = loadingBarValue.ToString() + "%";
            loadingProgressbar.Value++;

            if(loadingBarValue >= loadingProgressbar.Maximum)
            {
                loadingbarTimer.Stop();

                //Finish loading screen
                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();

                this.Hide();
            }
        }
    }
}
