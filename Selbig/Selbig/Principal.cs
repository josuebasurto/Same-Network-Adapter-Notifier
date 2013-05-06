using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Selbig.Properties;
using System.Configuration;

namespace Selbig
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            Inicializa();
        }

        private void Inicializa()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            ideal = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            LoadConfigs();
        }

        private void LoadConfigs()
        {
            try
            {
                cbNotify.Enabled = Settings.Default.DisableNotification;
                tmrNotifica.Interval = Settings.Default.SecsVerify;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las configuraciones.");
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            Scan();
        }

        List<System.Net.IPAddress> validas;

        private void Scan()
        {
            ReiniciaRed();
            lbNetworks.Items.Clear();

            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netif.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    netif.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    lbNetworks.Items.Add(netif.Name);

                    IPInterfaceProperties properties = netif.GetIPProperties();
                    foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                        if (unicast.IsDnsEligible)
                        {
                            AgregaRed(unicast.Address);
                            lbNetworks.Items.Add(unicast.Address);
                        }
                }
            }

            Notifica();
        }

        private void ReiniciaRed()
        {
            if (validas != null)
                validas.Clear();
        }

        private void Notifica()
        {
            Activa(false);

            if (validas != null)
                if (validas.Count >= 2)
                    if (cbNotify.Checked)
                        MessageBox.Show("Tienes 2 o mas IP's conectadas, sugiero que apagues tu wireless o te desconectes del cable.");

            if(!this.Visible)
                Activa(true);
        }

        private void AgregaRed(System.Net.IPAddress netif)
        {
            if (validas == null)
                validas = new List<System.Net.IPAddress>();

            if (!validas.Contains(netif))
                validas.Add(netif);
        }

        private void btnToTray_Click(object sender, EventArgs e)
        {
            Activa(true);
            AnimateDown();
            this.Hide();
        }

        private void AnimateDown()
        {

            for (int i = 0; i < this.Height + 30; i++)
                this.Top++;
        }

        private void AnimateUp()
        {
            for (int i = 0; i < this.Height + 30; i++)
                this.Top--;
        }

        private void Activa(Boolean b)
        {
            tmrNotifica.Enabled = b;
            if (b)
                notifyIcon1.Text = "Sistema Activado";
            else
                notifyIcon1.Text = "Sistema Desactivado";
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            AnimateUp();
            Activa(false);
        }

        private void tmrNotifica_Tick(object sender, EventArgs e)
        {
            Scan();
        }

        private void tmrInicial_Tick(object sender, EventArgs e)
        {
            tmrInicial.Enabled = false;
            AnimateDown();
            this.Hide();
            Activa(true);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        Point ideal;

        private void Principal_Shown(object sender, EventArgs e)
        {
            Location = ideal;
        }

        private void Principal_LocationChanged(object sender, EventArgs e)
        {
            
        }

        private void Principal_DragEnter(object sender, DragEventArgs e)
        {
            this.Location = ideal;
        }
    }
}
