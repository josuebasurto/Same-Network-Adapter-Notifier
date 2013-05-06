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
            this.cmsMenuTooltip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrNotifica = new System.Windows.Forms.Timer(this.components);
            this.tmrInicial = new System.Windows.Forms.Timer(this.components);
            this.cmsMenuTooltip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManual.Location = new System.Drawing.Point(240, 235);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(57, 23);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Verificar";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // lbNetworks
            // 
            this.lbNetworks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNetworks.FormattingEnabled = true;
            this.lbNetworks.Location = new System.Drawing.Point(12, 54);
            this.lbNetworks.Name = "lbNetworks";
            this.lbNetworks.Size = new System.Drawing.Size(338, 173);
            this.lbNetworks.TabIndex = 1;
            // 
            // cbNotify
            // 
            this.cbNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbNotify.AutoSize = true;
            this.cbNotify.Checked = true;
            this.cbNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotify.Location = new System.Drawing.Point(12, 241);
            this.cbNotify.Name = "cbNotify";
            this.cbNotify.Size = new System.Drawing.Size(200, 17);
            this.cbNotify.TabIndex = 2;
            this.cbNotify.Text = "Notifica al haber 2 o mas conexiones";
            this.cbNotify.UseVisualStyleBackColor = true;
            // 
            // btnToTray
            // 
            this.btnToTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToTray.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnToTray.Location = new System.Drawing.Point(303, 235);
            this.btnToTray.Name = "btnToTray";
            this.btnToTray.Size = new System.Drawing.Size(47, 23);
            this.btnToTray.TabIndex = 3;
            this.btnToTray.Text = "Ocultar";
            this.btnToTray.UseVisualStyleBackColor = true;
            this.btnToTray.Click += new System.EventHandler(this.btnToTray_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.cmsMenuTooltip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // cmsMenuTooltip
            // 
            this.cmsMenuTooltip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmsMenuTooltip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsMenuTooltip.Name = "cmsMenuTooltip";
            this.cmsMenuTooltip.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conexiones";
            // 
            // tmrNotifica
            // 
            this.tmrNotifica.Interval = 60000;
            this.tmrNotifica.Tick += new System.EventHandler(this.tmrNotifica_Tick);
            // 
            // tmrInicial
            // 
            this.tmrInicial.Enabled = true;
            this.tmrInicial.Tick += new System.EventHandler(this.tmrInicial_Tick);
            // 
            // Principal
            // 
            this.AcceptButton = this.btnToTray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnToTray;
            this.ClientSize = new System.Drawing.Size(362, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToTray);
            this.Controls.Add(this.cbNotify);
            this.Controls.Add(this.lbNetworks);
            this.Controls.Add(this.btnManual);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selbig Same Network IP Notifier";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.LocationChanged += new System.EventHandler(this.Principal_LocationChanged);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Principal_DragEnter);
            this.cmsMenuTooltip.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsMenuTooltip;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

