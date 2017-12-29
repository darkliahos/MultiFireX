namespace MultiFireX
{
    partial class frmGeckoBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtnavigate = new System.Windows.Forms.TextBox();
            this.tabwindow = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addtab = new System.Windows.Forms.PictureBox();
            this.cmsBrowser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Stop = new System.Windows.Forms.PictureBox();
            this.gohome = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.Go = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.forward = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.prgpageload = new System.Windows.Forms.ProgressBar();
            this.killtab = new System.Windows.Forms.PictureBox();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.tabwindow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addtab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killtab)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnavigate
            // 
            this.txtnavigate.BackColor = System.Drawing.Color.Black;
            this.txtnavigate.ForeColor = System.Drawing.SystemColors.Info;
            this.txtnavigate.Location = new System.Drawing.Point(221, 11);
            this.txtnavigate.Name = "txtnavigate";
            this.txtnavigate.Size = new System.Drawing.Size(620, 20);
            this.txtnavigate.TabIndex = 2;
            this.txtnavigate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnavigate_KeyDown);
            // 
            // tabwindow
            // 
            this.tabwindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabwindow.Controls.Add(this.tabPage1);
            this.tabwindow.Location = new System.Drawing.Point(12, 51);
            this.tabwindow.Name = "tabwindow";
            this.tabwindow.SelectedIndex = 0;
            this.tabwindow.Size = new System.Drawing.Size(1050, 517);
            this.tabwindow.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.geckoWebBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addtab
            // 
            this.addtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addtab.BackColor = System.Drawing.Color.Transparent;
            this.addtab.Image = global::MultiFireX.Properties.Resources.Button_Add_icon;
            this.addtab.Location = new System.Drawing.Point(969, 567);
            this.addtab.Name = "addtab";
            this.addtab.Size = new System.Drawing.Size(30, 30);
            this.addtab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addtab.TabIndex = 2;
            this.addtab.TabStop = false;
            this.addtab.Click += new System.EventHandler(this.addtab_Click);
            this.addtab.MouseLeave += new System.EventHandler(this.addtab_MouseLeave);
            this.addtab.MouseHover += new System.EventHandler(this.addtab_MouseHover);
            // 
            // cmsBrowser
            // 
            this.cmsBrowser.Name = "cmsBrowser";
            this.cmsBrowser.Size = new System.Drawing.Size(61, 4);
            this.cmsBrowser.Text = "Cut";
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.Image = global::MultiFireX.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(179, 11);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(35, 34);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stop.TabIndex = 24;
            this.Stop.TabStop = false;
            this.Stop.Tag = "Stop";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            this.Stop.MouseLeave += new System.EventHandler(this.Stop_MouseLeave);
            this.Stop.MouseHover += new System.EventHandler(this.Stop_MouseHover);
            // 
            // gohome
            // 
            this.gohome.BackColor = System.Drawing.Color.Transparent;
            this.gohome.Image = global::MultiFireX.Properties.Resources.home;
            this.gohome.Location = new System.Drawing.Point(137, 11);
            this.gohome.Name = "gohome";
            this.gohome.Size = new System.Drawing.Size(35, 34);
            this.gohome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gohome.TabIndex = 23;
            this.gohome.TabStop = false;
            this.gohome.Tag = "Home Page";
            this.gohome.Click += new System.EventHandler(this.home_Click);
            this.gohome.MouseLeave += new System.EventHandler(this.gohome_MouseLeave);
            this.gohome.MouseHover += new System.EventHandler(this.gohome_MouseHover);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Image = global::MultiFireX.Properties.Resources.view_refresh;
            this.refresh.Location = new System.Drawing.Point(95, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(35, 34);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 22;
            this.refresh.TabStop = false;
            this.refresh.Tag = "Refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.MouseLeave += new System.EventHandler(this.refresh_MouseLeave);
            this.refresh.MouseHover += new System.EventHandler(this.refresh_MouseHover);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Transparent;
            this.Go.Image = global::MultiFireX.Properties.Resources._11949946051051036285key_enter_svg_hi;
            this.Go.Location = new System.Drawing.Point(847, 11);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(35, 34);
            this.Go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Go.TabIndex = 21;
            this.Go.TabStop = false;
            this.Go.Tag = "Enter";
            this.Go.Click += new System.EventHandler(this.Go_Click);
            this.Go.MouseLeave += new System.EventHandler(this.Go_MouseLeave);
            this.Go.MouseHover += new System.EventHandler(this.Go_MouseHover);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::MultiFireX.Properties.Resources.standby;
            this.Exit.Location = new System.Drawing.Point(1023, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 34);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Tag = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.Color.Transparent;
            this.forward.Image = global::MultiFireX.Properties.Resources.wm_forward;
            this.forward.Location = new System.Drawing.Point(54, 11);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(35, 34);
            this.forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forward.TabIndex = 19;
            this.forward.TabStop = false;
            this.forward.Tag = "Forward";
            this.forward.Click += new System.EventHandler(this.forward_Click);
            this.forward.MouseLeave += new System.EventHandler(this.forward_MouseLeave);
            this.forward.MouseHover += new System.EventHandler(this.forward_MouseHover);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::MultiFireX.Properties.Resources.wm_back;
            this.back.Location = new System.Drawing.Point(13, 11);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 34);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 18;
            this.back.TabStop = false;
            this.back.Tag = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            this.back.MouseHover += new System.EventHandler(this.back_MouseHover);
            // 
            // prgpageload
            // 
            this.prgpageload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prgpageload.Location = new System.Drawing.Point(17, 573);
            this.prgpageload.Name = "prgpageload";
            this.prgpageload.Size = new System.Drawing.Size(129, 21);
            this.prgpageload.TabIndex = 25;
            // 
            // killtab
            // 
            this.killtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.killtab.BackColor = System.Drawing.Color.Transparent;
            this.killtab.Image = global::MultiFireX.Properties.Resources.Remove_icon;
            this.killtab.Location = new System.Drawing.Point(1013, 567);
            this.killtab.Name = "killtab";
            this.killtab.Size = new System.Drawing.Size(30, 30);
            this.killtab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.killtab.TabIndex = 26;
            this.killtab.TabStop = false;
            this.killtab.Click += new System.EventHandler(this.killtab_Click);
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(1, 6);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1041, 482);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // frmGeckoBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::MultiFireX.Properties.Resources.abstract_red_00172538;
            this.ClientSize = new System.Drawing.Size(1064, 598);
            this.Controls.Add(this.killtab);
            this.Controls.Add(this.prgpageload);
            this.Controls.Add(this.addtab);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.gohome);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tabwindow);
            this.Controls.Add(this.txtnavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmGeckoBrowser";
            this.Text = "Web Browser -Gecko";
            this.tabwindow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addtab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killtab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnavigate;
        private System.Windows.Forms.TabControl tabwindow;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip cmsBrowser;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox forward;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Go;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.PictureBox gohome;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox addtab;
        private System.Windows.Forms.ProgressBar prgpageload;
        private System.Windows.Forms.PictureBox killtab;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
    }
}

