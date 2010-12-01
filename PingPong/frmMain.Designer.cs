namespace PingPong
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblRemoteHost = new System.Windows.Forms.Label();
            this.txtRemoteHost = new System.Windows.Forms.TextBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dsLog = new System.Data.DataSet();
            this.dtPing = new System.Data.DataTable();
            this.PingDateTime = new System.Data.DataColumn();
            this.PingHost = new System.Data.DataColumn();
            this.PingStatus = new System.Data.DataColumn();
            this.PingReplyTime = new System.Data.DataColumn();
            this.PingTTL = new System.Data.DataColumn();
            this.gridLog = new System.Windows.Forms.DataGridView();
            this.pingDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingHostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingReplyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingTTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
            this.mnuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBegin.Location = new System.Drawing.Point(510, 2);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(83, 23);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblRemoteHost
            // 
            this.lblRemoteHost.AutoSize = true;
            this.lblRemoteHost.Location = new System.Drawing.Point(4, 7);
            this.lblRemoteHost.Name = "lblRemoteHost";
            this.lblRemoteHost.Size = new System.Drawing.Size(77, 13);
            this.lblRemoteHost.TabIndex = 2;
            this.lblRemoteHost.Text = "Remote Hosts:";
            // 
            // txtRemoteHost
            // 
            this.txtRemoteHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemoteHost.Location = new System.Drawing.Point(82, 4);
            this.txtRemoteHost.Multiline = true;
            this.txtRemoteHost.Name = "txtRemoteHost";
            this.txtRemoteHost.Size = new System.Drawing.Size(422, 57);
            this.txtRemoteHost.TabIndex = 0;
            this.txtRemoteHost.Text = "127.0.0.1";
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 367);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 11);
            this.progressBar1.TabIndex = 4;
            // 
            // dsLog
            // 
            this.dsLog.DataSetName = "PingResponse";
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPing});
            // 
            // dtPing
            // 
            this.dtPing.Columns.AddRange(new System.Data.DataColumn[] {
            this.PingDateTime,
            this.PingHost,
            this.PingStatus,
            this.PingReplyTime,
            this.PingTTL});
            this.dtPing.TableName = "dtPing";
            // 
            // PingDateTime
            // 
            this.PingDateTime.Caption = "DateTime";
            this.PingDateTime.ColumnName = "PingDateTime";
            this.PingDateTime.DataType = typeof(System.DateTime);
            // 
            // PingHost
            // 
            this.PingHost.Caption = "Host";
            this.PingHost.ColumnName = "PingHost";
            // 
            // PingStatus
            // 
            this.PingStatus.Caption = "Status";
            this.PingStatus.ColumnName = "PingStatus";
            // 
            // PingReplyTime
            // 
            this.PingReplyTime.Caption = "ReplyTime (ms)";
            this.PingReplyTime.ColumnName = "PingReplyTime";
            this.PingReplyTime.DataType = typeof(uint);
            // 
            // PingTTL
            // 
            this.PingTTL.Caption = "TTL";
            this.PingTTL.ColumnName = "PingTTL";
            this.PingTTL.DataType = typeof(uint);
            // 
            // gridLog
            // 
            this.gridLog.AllowUserToAddRows = false;
            this.gridLog.AllowUserToDeleteRows = false;
            this.gridLog.AllowUserToOrderColumns = true;
            this.gridLog.AllowUserToResizeRows = false;
            this.gridLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLog.AutoGenerateColumns = false;
            this.gridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pingDateTimeDataGridViewTextBoxColumn,
            this.pingHostDataGridViewTextBoxColumn,
            this.pingStatusDataGridViewTextBoxColumn,
            this.pingReplyTimeDataGridViewTextBoxColumn,
            this.pingTTLDataGridViewTextBoxColumn});
            this.gridLog.DataMember = "dtPing";
            this.gridLog.DataSource = this.dsLog;
            this.gridLog.Location = new System.Drawing.Point(3, 67);
            this.gridLog.Name = "gridLog";
            this.gridLog.ReadOnly = true;
            this.gridLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridLog.Size = new System.Drawing.Size(590, 296);
            this.gridLog.TabIndex = 5;
            // 
            // pingDateTimeDataGridViewTextBoxColumn
            // 
            this.pingDateTimeDataGridViewTextBoxColumn.DataPropertyName = "PingDateTime";
            this.pingDateTimeDataGridViewTextBoxColumn.HeaderText = "PingDateTime";
            this.pingDateTimeDataGridViewTextBoxColumn.Name = "pingDateTimeDataGridViewTextBoxColumn";
            this.pingDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pingDateTimeDataGridViewTextBoxColumn.Width = 99;
            // 
            // pingHostDataGridViewTextBoxColumn
            // 
            this.pingHostDataGridViewTextBoxColumn.DataPropertyName = "PingHost";
            this.pingHostDataGridViewTextBoxColumn.HeaderText = "PingHost";
            this.pingHostDataGridViewTextBoxColumn.Name = "pingHostDataGridViewTextBoxColumn";
            this.pingHostDataGridViewTextBoxColumn.ReadOnly = true;
            this.pingHostDataGridViewTextBoxColumn.Width = 75;
            // 
            // pingStatusDataGridViewTextBoxColumn
            // 
            this.pingStatusDataGridViewTextBoxColumn.DataPropertyName = "PingStatus";
            this.pingStatusDataGridViewTextBoxColumn.HeaderText = "PingStatus";
            this.pingStatusDataGridViewTextBoxColumn.Name = "pingStatusDataGridViewTextBoxColumn";
            this.pingStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.pingStatusDataGridViewTextBoxColumn.Width = 83;
            // 
            // pingReplyTimeDataGridViewTextBoxColumn
            // 
            this.pingReplyTimeDataGridViewTextBoxColumn.DataPropertyName = "PingReplyTime";
            this.pingReplyTimeDataGridViewTextBoxColumn.HeaderText = "PingReplyTime";
            this.pingReplyTimeDataGridViewTextBoxColumn.Name = "pingReplyTimeDataGridViewTextBoxColumn";
            this.pingReplyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pingReplyTimeDataGridViewTextBoxColumn.Width = 103;
            // 
            // pingTTLDataGridViewTextBoxColumn
            // 
            this.pingTTLDataGridViewTextBoxColumn.DataPropertyName = "PingTTL";
            this.pingTTLDataGridViewTextBoxColumn.HeaderText = "PingTTL";
            this.pingTTLDataGridViewTextBoxColumn.Name = "pingTTLDataGridViewTextBoxColumn";
            this.pingTTLDataGridViewTextBoxColumn.ReadOnly = true;
            this.pingTTLDataGridViewTextBoxColumn.Width = 73;
            // 
            // mnuRightClick
            // 
            this.mnuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.mnuRightClick.Name = "mnuRightClick";
            this.mnuRightClick.Size = new System.Drawing.Size(104, 126);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.mnuRightClick;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 381);
            this.Controls.Add(this.gridLog);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtRemoteHost);
            this.Controls.Add(this.lblRemoteHost);
            this.Controls.Add(this.btnBegin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "PingPong";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).EndInit();
            this.mnuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblRemoteHost;
        private System.Windows.Forms.TextBox txtRemoteHost;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Data.DataSet dsLog;
        private System.Data.DataTable dtPing;
        private System.Data.DataColumn PingDateTime;
        private System.Data.DataColumn PingHost;
        private System.Data.DataColumn PingStatus;
        private System.Data.DataColumn PingReplyTime;
        private System.Data.DataColumn PingTTL;
        private System.Windows.Forms.DataGridView gridLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingHostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingReplyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingTTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip mnuRightClick;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

