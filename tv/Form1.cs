using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAPlayer3Lib;

namespace tv
{
    public partial class Form1 : Form
    {
        string refresh;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //axPlayer1.Open(textBox1.Text.ToString());
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        string TimeToString(TimeSpan span)
        {
            return span.Hours.ToString("00") + ":" +
            span.Minutes.ToString("00") + ":" +
            span.Seconds.ToString("00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeToString(TimeSpan.FromMilliseconds(axPlayer1.GetPosition()));
            trackBar1.Value = axPlayer1.GetPosition() <= 0 ? 0 : axPlayer1.GetPosition();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axPlayer1.SetPosition(trackBar1.Value);
            label1.Text = TimeToString(TimeSpan.FromMilliseconds(trackBar1.Value));
        }
        void axPlayer1_OnOpenSucceeded(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
            label2.Text = TimeToString(TimeSpan.FromMilliseconds(axPlayer1.GetDuration()));
            trackBar1.Enabled = true;
            trackBar1.Maximum = axPlayer1.GetDuration();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axPlayer1.OnOpenSucceeded += new EventHandler(axPlayer1_OnOpenSucceeded);
            axPlayer1.OnStateChanged += new _IPlayerEvents_OnStateChangedEventHandler(axPlayer1_OnStateChanged);
            axPlayer1.OnBuffer += new _IPlayerEvents_OnBufferEventHandler(axPlayer1_OnBuffer);
            axPlayer1.SetCustomLogo(Properties.Resources.logo.GetHbitmap().ToInt32());
            axPlayer1.OnMessage += new _IPlayerEvents_OnMessageEventHandler(axPlayer1_OnMessage);
            trackBar2.Value = 10;
        }

        private void 打开本地文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "mp4|*.mp4|avi|*.avi|rm|*.rm|rmvb|*.rmvb|flv|*.flv|xr|*.xr|所有文件|*.*";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axPlayer1.Open(ofd.FileName);
                }
            }
            this.Text = "308鸮电视";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (axPlayer1.GetState() == 5)  //播放-暂停
            {
                axPlayer1.Pause();
            }
            if (axPlayer1.GetState() == 3)  //暂停-播放
            {
                axPlayer1.Play();
            }
        }
        void axPlayer1_OnStateChanged(object sender, _IPlayerEvents_OnStateChangedEvent e)
        {
            if (e.nNewState == 0)  //就绪
            {
                //初始化
                trackBar1.Maximum = 100;
                trackBar1.Value = 0;
                trackBar1.Enabled = false;
                label1.Text = "00:00:00";
                label2.Text = "00:00:00";
                timer1.Stop();
            }
            if (e.nNewState == 1)  //正在打开
            {
                button1.Enabled = false;
            }
            if (e.nNewState == 5 || e.nNewState == 4)  //播放
            {
                button2.Enabled = true;
                button1.Enabled = true;
                button1.Text = "暂停";
                
            }
            if (e.nNewState == 3 || e.nNewState == 2)  //暂停
            {
                button2.Enabled = true;
                button1.Enabled = true;
                button1.Text = "播放";
            }
            if (e.nNewState == 6)  //停止
            {
                button2.Enabled = false;
                button1.Enabled = false;
                this.Text = "308鸮电视";
            }
        }

        private void 打开网络流ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 f2 = new Form2())
            {
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    axPlayer1.Open(f2.URL);
                    refresh = f2.URL;
                    this.Text = "308鸮电视" + "        正在播放网络流";
                }
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            axPlayer1.SetVolume(trackBar2.Value * 10);
        }
        void axPlayer1_OnBuffer(object sender, _IPlayerEvents_OnBufferEvent e)
        {
            if (e.nPercent != 100)
            {
                label3.Visible = true;
                label3.Text = "正在缓冲...(" + e.nPercent + "%)";
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void 在线电视直播ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axPlayer1.Open(refresh);
        }

        private void 全部电视台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form3 f3 = new Form3())
            {
                if (f3.ShowDialog() == DialogResult.OK)
                {
                    axPlayer1.Open(f3.URL1);
                    refresh = f3.URL1;
                    this.Text = "308鸮电视" + "        正在观看:" + f3.channelName;
                }
            }
        }

        private void 我的收藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form4 f4 = new Form4())
            {
                if (f4.ShowDialog() == DialogResult.OK)
                {
                    axPlayer1.Open(f4.URL2);
                    refresh = f4.URL2;
                    this.Text = "308鸮电视" + "        正在观看:" + f4.channelName;
                }
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = "载入速度:"+axPlayer1.GetConfig(41)+"kb/s";
        }

        void axPlayer1_OnMessage(object sender, _IPlayerEvents_OnMessageEvent e)
        {
            //throw new NotImplementedException();
            if (e.nMessage == 517)
            {
                contextMenuStrip1.Show(axPlayer1, axPlayer1.PointToClient(Cursor.Position));
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(204, "16;9");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(204, "4;3");
        }

        private void 快速ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(104, "150");
        }

        private void 正常ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(104, "100");
        }

        private void 慢速ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(104, "50");
        }

        private void 超快速ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(104, "300");
        }

        private void 超慢速ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axPlayer1.SetConfig(104, "10");
        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            axPlayer1.Open(path);
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢使用^\n308鸮电视Beta1.3    misiu29\n此程序使用以下组件与开源项目:\nAPlayer    xunlei.com All Right Reserved\nIPTV    iptv-org", "我是啥b");
        }

        private void 鸮电视使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("因为我是懒逼，所以这里什么都没有~", "我是啥b");
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("因为我是懒逼，所以这里什么都没有~", "我是啥b");
        }
    }
}
