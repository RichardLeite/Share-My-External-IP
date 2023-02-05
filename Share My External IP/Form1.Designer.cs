namespace Share_My_External_IP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.UseWaitCursor = true;
            this.button_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            resources.ApplyResources(this.btn_minimize, "btn_minimize");
            this.btn_minimize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.UseWaitCursor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.UseWaitCursor = true;
            // 
            // text
            // 
            resources.ApplyResources(this.text, "text");
            this.text.Name = "text";
            this.text.UseWaitCursor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.UseWaitCursor = true;
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseClick);
            // 
            // button_minimize
            // 
            resources.ApplyResources(this.button_minimize, "button_minimize");
            this.button_minimize.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.ForeColor = System.Drawing.Color.White;
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.UseWaitCursor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.button_close);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_close;
        private Button btn_minimize;
        private Label title;
        private Label text;
        public LinkLabel linkLabel1;
        private Button button_minimize;
        public NotifyIcon notifyIcon;
    }
}