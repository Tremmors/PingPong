using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmMain : Form
    {
        public bool IsRunning = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if(IsRunning)
            {   
                Stop();
            }   
            else
            {   
                Start();
            }   
        }

        private void Start()
        {
            this.btnBegin.Text = "Stop";
            this.txtRemoteHost.ReadOnly = true;
            this.IsRunning = true;
            this.tmrMain.Start();
            tmrMain_Tick(null, null);
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.stopToolStripMenuItem.Enabled = true;
            this.startToolStripMenuItem.Enabled = false;
        }
        private void InitializeGrid()
        {

        }
        void tmrMain_Tick(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF" +
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF" +
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF" +
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            foreach (string thisHost in this.txtRemoteHost.Lines)
            {
                if (!string.IsNullOrEmpty(thisHost))
                {
                    DataRow drResult = dtPing.NewRow();
                    try
                    {
                        PingReply reply = pingSender.Send(thisHost, timeout, buffer, options);
                        drResult["PingDateTime"] = DateTime.Now;
                        drResult["PingHost"] = thisHost;
                        drResult["PingStatus"] = reply.Status.ToString();
                        if (reply.Status == IPStatus.Success)
                        {
                            drResult["PingReplyTime"] = reply.RoundtripTime;
                        }
                        else
                        {
                            
                        }
                        if (reply.Options != null)
                            drResult["PingTTL"] = reply.Options.Ttl;
                    }
                    catch(Exception ex)
                    {
                        drResult["PingDateTime"] = DateTime.Now;
                        drResult["PingHost"] = thisHost;
                        drResult["PingStatus"] = "Error:"+ex.Message;

                    }

                    

                    dtPing.Rows.Add(drResult);
                }
            }

        }

        private void Stop()
        {
            this.btnBegin.Text = "Start";
            this.txtRemoteHost.ReadOnly = false;
            this.progressBar1.Style = ProgressBarStyle.Blocks;
            this.progressBar1.Value = this.progressBar1.Minimum;
            this.IsRunning = false;
            this.tmrMain.Stop();
            this.startToolStripMenuItem.Enabled = true;
            this.stopToolStripMenuItem.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    dsLog.WriteXml(this.saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Unable to write to file");
                }
            }
        }

        private void Hide()
        {
            this.ShowInTaskbar = false;

            this.Visible = false;
        }
        private void Show()
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Focus();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Focus();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon1.Visible = false;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }
    }
}
