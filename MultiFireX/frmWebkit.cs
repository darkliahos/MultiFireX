using System;
using System.Configuration;
using System.Windows.Forms;

namespace MultiFireX
{
    public partial class frmWebkit : Form
    {
        public string HomePage { get; set; }

        public frmWebkit()
        {
            InitializeComponent();
            HomePage = ConfigurationSettings.AppSettings["HomePage"];
            this.Load += new EventHandler(frmWebkit_Load);
            this.webKitBrowser1.Navigated +=
                new WebBrowserNavigatedEventHandler(webKitBrowser1_Navigated);
        }

        private void Go_Click(object sender, System.EventArgs e)
        {
            webKitBrowser1.Navigate(txtnavigate.Text);
        }

        void frmWebkit_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate(HomePage);
        }

        void webKitBrowser1_Navigated(object sender,
            WebBrowserNavigatedEventArgs e)
        {
            if (webKitBrowser1.Url != null)
            {
                txtnavigate.Text = webKitBrowser1.Url.ToString();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            webKitBrowser1.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webKitBrowser1.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Refresh();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Stop();
        }

        private void txtnavigate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webKitBrowser1.Navigate(txtnavigate.Text);
            }
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate(HomePage);
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
