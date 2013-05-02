using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Selbig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            Scan();
        }

        List<System.Net.IPAddress> validas;

        private void Scan()
        {
            lbNetworks.Items.Clear();

            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netif.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    netif.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    lbNetworks.Items.Add("------------------------" + netif.Name);

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
            this.Hide();
            Activa(true);
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
            Activa(false);
        }

        private void tmrNotifica_Tick(object sender, EventArgs e)
        {
            Scan();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            Activa(true);
        }
    }
}
