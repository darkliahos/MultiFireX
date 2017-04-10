using System;
using System.Configuration;
using System.Windows.Forms;
using Skybound.Gecko;

namespace MultiFireX
{
    public partial class frmGeckoBrowser : Form
    {
        public string Home { get; set; }

        public frmGeckoBrowser()
        {
            Home = ConfigurationSettings.AppSettings["HomePage"];
            //        public const string xulrunnerPath = @"C:\Program Files\Mozilla XULRunner\";
            Skybound.Gecko.Xpcom.Initialize(ConfigurationSettings.AppSettings["XULRunnerPath"]);
            InitializeComponent();
            
        }

        private void geckoWebBrowser1_Navigating(object sender, GeckoNavigatingEventArgs e)
        {
            prgpageload.Visible = true;
            prgpageload.Value = 0;
            prgpageload.Minimum = 0;
            prgpageload.Maximum = 100;
            prgpageload.Step = 10;
            prgpageload.PerformStep();
            
        }

        private void geckoWebBrowser1_Navigated(object sender, GeckoNavigatedEventArgs e)
        {
            prgpageload.Value = 70;
        }

        private void geckoWebBrowser1_DocumentCompleted(object sender, EventArgs e)
        {
            prgpageload.Step = 10;
            prgpageload.PerformStep();
            prgpageload.Visible = false;
        }

        private GeckoWebBrowser getCurrentBrowser()
            {
                return (GeckoWebBrowser)tabwindow.SelectedTab.Controls[0];
            }

        private void addNewTab()
        {
            var tpage = new TabPage {BorderStyle = BorderStyle.None};
            tabwindow.TabPages.Insert(
                tabwindow.TabCount - 1, tpage);
            var browser = new GeckoWebBrowser();
            tpage.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            tabwindow.SelectTab(tpage);
        }

        private void RemoveTab()
        {
            tabwindow.TabPages.Remove(tabwindow.SelectedTab);
        }

        private void NavigateNewPage()
        {
            getCurrentBrowser().Navigate(txtnavigate.Text);
            tabwindow.SelectedTab.Text = txtnavigate.Text;
        }


        private void back_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoForward();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            NavigateNewPage();
        }

        private void txtnavigate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NavigateNewPage();
            }
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Go_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void forward_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Go_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void forward_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Refresh();
        }

        private void refresh_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void refresh_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void home_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Navigate(Home);
        }

        private void gohome_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void gohome_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Stop();
        }

        private void Stop_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Stop_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void addtab_Click(object sender, EventArgs e)
        {
            addNewTab();
        }

        private void addtab_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void addtab_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void killtab_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }





        
    }
}
