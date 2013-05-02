namespace Selbig
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnManual = new System.Windows.Forms.Button();
            this.lbNetworks = new System.Windows.Forms.ListBox();
            this.cbNotify = new System.Windows.Forms.CheckBox();
            this.btnToTray = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tmrNotifica = new System.Windows.Forms.Timer(this.components);
            this.tmrInicial = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManual.Location = new System.Drawing.Point(236, 12);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(80, 23);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Manual Scan";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // lbNetworks
            // 
            this.lbNetworks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNetworks.FormattingEnabled = true;
            this.lbNetworks.Location = new System.Drawing.Point(12, 41);
            this.lbNetworks.Name = "lbNetworks";
            this.lbNetworks.Size = new System.Drawing.Size(304, 290);
            this.lbNetworks.TabIndex = 1;
            // 
            // cbNotify
            // 
            this.cbNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbNotify.AutoSize = true;
            this.cbNotify.Checked = true;
            this.cbNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotify.Location = new System.Drawing.Point(12, 357);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(144, 17);
            this.cbNotify.TabIndex = 2;
            this.cbNotify.Text = "Notify on same Networks";
            this.cbNotify.UseVisualStyleBackColor = true;
            // 
            // btnToTray
            // 
            this.btnToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToTray.Location = new System.Drawing.Point(269, 351);
            this.btnToTray.Name = "btnToTray";
            this.btnToTray.Size = new System.Drawing.Size(47, 23);
            this.btnToTray.TabIndex = 3;
            this.btnToTray.Text = "Oculta";
            this.btnToTray.UseVisualStyleBackColor = true;
            this.btnToTray.Click += new System.EventHandler(this.btnToTray_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conexiones";
            // 
            // tmrNotifica
            // 
            this.tmrNotifica.Interval = 10000;
            this.tmrNotifica.Tick += new System.EventHandler(this.tmrNotifica_Tick);
            // 
            // tmrInicial
            // 
            this.tmrInicial.Enabled = true;
            this.tmrInicial.Tick += new System.EventHandler(this.tmrInicial_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToTray);
            this.Controls.Add(this.cbNotify);
            this.Controls.Add(this.lbNetworks);
            this.Controls.Add(this.btnManual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selbig Same Network IP Notifier";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.ListBox lbNetworks;
        private System.Windows.Forms.CheckBox cbNotify;
        private System.Windows.Forms.Button btnToTray;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrNotifica;
        private System.Windows.Forms.Timer tmrInicial;
    }
}

