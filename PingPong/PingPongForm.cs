// <copyright file="PingPongForm.cs" company="John Trimis">
// Copyright (c) 2011 John Trimis 
//
// MIT license:
// Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in 
// the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of 
// the Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS 
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR 
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER 
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN 
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copywrite>

namespace PingPong
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Net.NetworkInformation;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    ///     Main form (basically the whole application).
    ///     Continuously pings and displays the results in a grid
    /// </summary>
    public partial class PingPongForm : Form
    {
        public bool IsRunning = false;

        public PingPongForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     The Begin Button was clicked
        /// </summary>
        private void BtnBegin_Click(object sender, EventArgs e)
        {
            if(this.IsRunning)
            {   
                this.Stop();
            }   
            else
            {   
                this.Start();
            }   
        }

        /// <summary>
        ///     Start the timer which will start pinging
        /// </summary>
        private void Start()
        {
            this.btnBegin.Text = "Stop";
            this.txtRemoteHost.ReadOnly = true;
            this.IsRunning = true;
            this.tmrMain.Start();
            this.TmrMain_Tick(null, null);
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.stopToolStripMenuItem.Enabled = true;
            this.startToolStripMenuItem.Enabled = false;
        }

        private void InitializeGrid()
        {

        }

        /// <summary>
        ///     The timer tick event.  This is where the actualy pinging takes place
        /// </summary>
        void TmrMain_Tick(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            options.DontFragment = true;

            // 256 bytes of data
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
                    catch( Exception ex)
                    {
                        drResult["PingDateTime"] = DateTime.Now;
                        drResult["PingHost"] = thisHost;
                        drResult["PingStatus"] = "Error:" + ex.Message;

                    }

                    dtPing.Rows.InsertAt(drResult, 0);
                }
            }

        }

        /// <summary>
        ///     Stop the ping timer
        /// </summary>
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

        /// <summary>
        ///     The form is closing
        /// </summary>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.notifyIcon1.Visible = false;
            // Note: If you don't do this, then the icon will stay in the taskbar until a mouseover event happens.
        }

        /// <summary>
        ///     The start option was selected from the rightclick menu
        /// </summary>
        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        /// <summary>
        ///     The stop option was selected from the rightclick menu
        /// </summary>
        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Stop();
        }

        /// <summary>
        ///     The save option was selected from the rightclick menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
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

        /// <summary>
        ///     Minimize to taskbar
        /// </summary>
        private void HideMe()
        {
            this.ShowInTaskbar = false;

            this.Visible = false;
        }

        /// <summary>
        ///     Maximize from taskbar
        /// </summary>
        private void ShowMe()
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Focus();
        }

        /// <summary>
        ///     The Show Option was selected from the rightclick menu
        /// </summary>
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Focus();
        }

        /// <summary>
        ///     The Hide option was selected from the rightclick menu
        /// </summary>
        private void HideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HideMe();
        }

        /// <summary>
        ///     The NotifyIcon (in the taskbar) was doubleclicked.  We're going to treat this as if they 
        ///     right clicked and selected "show"
        /// </summary>
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.ShowMe();
        }
    }
}
