namespace MultiFireX
{
    partial class frmWebkit
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
            this.Stop = new System.Windows.Forms.PictureBox();
            this.gohome = new System.Windows.Forms.PictureBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.Go = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.forward = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.txtnavigate = new System.Windows.Forms.TextBox();
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.Image = global::MultiFireX.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(178, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(35, 34);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stop.TabIndex = 32;
            this.Stop.TabStop = false;
            this.Stop.Tag = "Stop";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // gohome
            // 
            this.gohome.BackColor = System.Drawing.Color.Transparent;
            this.gohome.Image = global::MultiFireX.Properties.Resources.home;
            this.gohome.Location = new System.Drawing.Point(136, 12);
            this.gohome.Name = "gohome";
            this.gohome.Size = new System.Drawing.Size(35, 34);
            this.gohome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gohome.TabIndex = 31;
            this.gohome.TabStop = false;
            this.gohome.Tag = "Home Page";
            this.gohome.Click += new System.EventHandler(this.gohome_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Image = global::MultiFireX.Properties.Resources.view_refresh;
            this.refresh.Location = new System.Drawing.Point(94, 13);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(35, 34);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 30;
            this.refresh.TabStop = false;
            this.refresh.Tag = "Refresh";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Transparent;
            this.Go.Image = global::MultiFireX.Properties.Resources._11949946051051036285key_enter_svg_hi;
            this.Go.Location = new System.Drawing.Point(846, 12);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(35, 34);
            this.Go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Go.TabIndex = 29;
            this.Go.TabStop = false;
            this.Go.Tag = "Enter";
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::MultiFireX.Properties.Resources.standby;
            this.Exit.Location = new System.Drawing.Point(1022, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 34);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 25;
            this.Exit.TabStop = false;
            this.Exit.Tag = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.Color.Transparent;
            this.forward.Image = global::MultiFireX.Properties.Resources.wm_forward;
            this.forward.Location = new System.Drawing.Point(53, 12);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(35, 34);
            this.forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forward.TabIndex = 28;
            this.forward.TabStop = false;
            this.forward.Tag = "Forward";
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::MultiFireX.Properties.Resources.wm_back;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 34);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 27;
            this.back.TabStop = false;
            this.back.Tag = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txtnavigate
            // 
            this.txtnavigate.BackColor = System.Drawing.Color.Black;
            this.txtnavigate.ForeColor = System.Drawing.SystemColors.Info;
            this.txtnavigate.Location = new System.Drawing.Point(220, 12);
            this.txtnavigate.Name = "txtnavigate";
            this.txtnavigate.Size = new System.Drawing.Size(620, 20);
            this.txtnavigate.TabIndex = 26;
            this.txtnavigate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnavigate_KeyDown);
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Location = new System.Drawing.Point(12, 52);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Size = new System.Drawing.Size(1045, 517);
            this.webKitBrowser1.TabIndex = 33;
            this.webKitBrowser1.Url = null;
            // 
            // frmWebkit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 594);
            this.Controls.Add(this.webKitBrowser1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.gohome);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtnavigate);
            this.Name = "frmWebkit";
            this.Text = "frmWebkit";
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox gohome;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.PictureBox Go;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox forward;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.TextBox txtnavigate;
        private WebKit.WebKitBrowser webKitBrowser1;
    }
}