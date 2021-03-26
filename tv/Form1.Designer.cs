namespace tv
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.视频比例调整ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.播放速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快速ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.慢速ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.超快速ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.超慢速ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开本地文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开网络流ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线电视直播ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部电视台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的收藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.鸮电视使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // axPlayer1
            // 
            this.axPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axPlayer1.ContextMenuStrip = this.contextMenuStrip1;
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(2, 28);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(796, 443);
            this.axPlayer1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.视频比例调整ToolStripMenuItem,
            this.播放速度ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 视频比例调整ToolStripMenuItem
            // 
            this.视频比例调整ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.视频比例调整ToolStripMenuItem.Name = "视频比例调整ToolStripMenuItem";
            this.视频比例调整ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.视频比例调整ToolStripMenuItem.Text = "视频比例调整";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "16:9";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem3.Text = "4:3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 播放速度ToolStripMenuItem
            // 
            this.播放速度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.快速ToolStripMenuItem,
            this.正常ToolStripMenuItem,
            this.慢速ToolStripMenuItem,
            this.超快速ToolStripMenuItem,
            this.超慢速ToolStripMenuItem});
            this.播放速度ToolStripMenuItem.Name = "播放速度ToolStripMenuItem";
            this.播放速度ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.播放速度ToolStripMenuItem.Text = "播放速度";
            // 
            // 快速ToolStripMenuItem
            // 
            this.快速ToolStripMenuItem.Name = "快速ToolStripMenuItem";
            this.快速ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.快速ToolStripMenuItem.Text = "快速";
            this.快速ToolStripMenuItem.Click += new System.EventHandler(this.快速ToolStripMenuItem_Click);
            // 
            // 正常ToolStripMenuItem
            // 
            this.正常ToolStripMenuItem.Name = "正常ToolStripMenuItem";
            this.正常ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.正常ToolStripMenuItem.Text = "正常";
            this.正常ToolStripMenuItem.Click += new System.EventHandler(this.正常ToolStripMenuItem_Click);
            // 
            // 慢速ToolStripMenuItem
            // 
            this.慢速ToolStripMenuItem.Name = "慢速ToolStripMenuItem";
            this.慢速ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.慢速ToolStripMenuItem.Text = "慢速";
            this.慢速ToolStripMenuItem.Click += new System.EventHandler(this.慢速ToolStripMenuItem_Click);
            // 
            // 超快速ToolStripMenuItem
            // 
            this.超快速ToolStripMenuItem.Name = "超快速ToolStripMenuItem";
            this.超快速ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.超快速ToolStripMenuItem.Text = "超快速";
            this.超快速ToolStripMenuItem.Click += new System.EventHandler(this.超快速ToolStripMenuItem_Click);
            // 
            // 超慢速ToolStripMenuItem
            // 
            this.超慢速ToolStripMenuItem.Name = "超慢速ToolStripMenuItem";
            this.超慢速ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.超慢速ToolStripMenuItem.Text = "超慢速";
            this.超慢速ToolStripMenuItem.Click += new System.EventHandler(this.超慢速ToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(2, 477);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(796, 23);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.在线电视直播ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开本地文件ToolStripMenuItem,
            this.打开网络流ToolStripMenuItem});
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 打开本地文件ToolStripMenuItem
            // 
            this.打开本地文件ToolStripMenuItem.Name = "打开本地文件ToolStripMenuItem";
            this.打开本地文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开本地文件ToolStripMenuItem.Text = "打开本地文件";
            this.打开本地文件ToolStripMenuItem.Click += new System.EventHandler(this.打开本地文件ToolStripMenuItem_Click);
            // 
            // 打开网络流ToolStripMenuItem
            // 
            this.打开网络流ToolStripMenuItem.Name = "打开网络流ToolStripMenuItem";
            this.打开网络流ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开网络流ToolStripMenuItem.Text = "打开网络流";
            this.打开网络流ToolStripMenuItem.Click += new System.EventHandler(this.打开网络流ToolStripMenuItem_Click);
            // 
            // 在线电视直播ToolStripMenuItem
            // 
            this.在线电视直播ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部电视台ToolStripMenuItem,
            this.我的收藏ToolStripMenuItem});
            this.在线电视直播ToolStripMenuItem.Name = "在线电视直播ToolStripMenuItem";
            this.在线电视直播ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.在线电视直播ToolStripMenuItem.Text = "在线电视直播";
            this.在线电视直播ToolStripMenuItem.Click += new System.EventHandler(this.在线电视直播ToolStripMenuItem_Click);
            // 
            // 全部电视台ToolStripMenuItem
            // 
            this.全部电视台ToolStripMenuItem.Name = "全部电视台ToolStripMenuItem";
            this.全部电视台ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.全部电视台ToolStripMenuItem.Text = "全部电视台";
            this.全部电视台ToolStripMenuItem.Click += new System.EventHandler(this.全部电视台ToolStripMenuItem_Click);
            // 
            // 我的收藏ToolStripMenuItem
            // 
            this.我的收藏ToolStripMenuItem.Name = "我的收藏ToolStripMenuItem";
            this.我的收藏ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.我的收藏ToolStripMenuItem.Text = "我的收藏";
            this.我的收藏ToolStripMenuItem.Click += new System.EventHandler(this.我的收藏ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.鸮电视使用说明ToolStripMenuItem,
            this.使用说明ToolStripMenuItem,
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(305, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(637, 498);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 23);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(400, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // 鸮电视使用说明ToolStripMenuItem
            // 
            this.鸮电视使用说明ToolStripMenuItem.Name = "鸮电视使用说明ToolStripMenuItem";
            this.鸮电视使用说明ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.鸮电视使用说明ToolStripMenuItem.Text = "下载更新";
            this.鸮电视使用说明ToolStripMenuItem.Click += new System.EventHandler(this.鸮电视使用说明ToolStripMenuItem_Click);
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.axPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "308鸮电视";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAPlayer3Lib.AxPlayer axPlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 打开本地文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开网络流ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 在线电视直播ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 全部电视台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的收藏ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 视频比例调整ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 播放速度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快速ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 慢速ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 超快速ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 超慢速ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 鸮电视使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
    }
}

