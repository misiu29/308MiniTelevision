using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace tv
{
    public partial class Form3 : Form
    {
        private List<Data> originData;
        public string URL1
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string channelName
        {
            get
            {
                return ((ListboxItem)listBox1.SelectedItem).ItemText;
            }
        }
        string getJson;
        public Form3()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*
            Application.DoEvents();
            string url = "https://iptv-org.github.io/iptv/channels.json";
            string getJson = GetJson.Get(url);
            List<Data> jobInfoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(getJson);
            foreach (Data jobInfo in jobInfoList)
            {
                //Console.Write(jobInfo.name + "\t");
                //Console.Write(jobInfo.url + "\t");
                //listBox1.Items.Add(jobInfo.name);
                ListboxItem listItem = new ListboxItem(jobInfo.name, jobInfo.url);
                listBox1.Items.Add(listItem);
            }
            */
            //richTextBox1.Text = getJson;
            DownloadFile("https://iptv-org.github.io/iptv/channels.json", "Data/Download.json", progressBar1, label1);
            progressBar1.Visible = true;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = ((ListboxItem)listBox1.SelectedItem).ItemValue;
            DialogResult = DialogResult.OK;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getJson = GetJson.GetLocal();
            /*
            Application.DoEvents();
            string url = "https://iptv-org.github.io/iptv/channels.json";
            getJson = GetJson.Get(url);
            */
            /*
            List<Data> jobInfoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(getJson);
            foreach (Data jobInfo in jobInfoList)
            {
                //Console.Write(jobInfo.name + "\t");
                //Console.Write(jobInfo.url + "\t");
                //listBox1.Items.Add(jobInfo.name);
                ListboxItem listItem = new ListboxItem(jobInfo.name, jobInfo.url);
                listBox1.Items.Add(listItem);
            }
            */

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "正在加载，根据网络情况不同加载时长可能为2-5分钟左右";
            backgroundWorker1.RunWorkerAsync();
        }
        void ListAdd()
        {
            List<Data> jobInfoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(getJson);
            originData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(getJson);
            foreach (Data jobInfo in jobInfoList)
            {
                //Console.Write(jobInfo.name + "\t");
                //Console.Write(jobInfo.url + "\t");
                //listBox1.Items.Add(jobInfo.name);
                ListboxItem listItem = new ListboxItem(jobInfo.name, jobInfo.url);
                listBox1.Items.Add(listItem);
            }
            label1.Text = "加载完成";
            button1.Enabled = true;
            button2.Enabled = true;
            textBox2.Enabled = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListAdd();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((ListboxItem)listBox1.SelectedItem).ItemValue;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            Data data = new Data
            {
                name = ((ListboxItem)listBox1.SelectedItem).ItemText,
                url = ((ListboxItem)listBox1.SelectedItem).ItemValue,
            };
            string json = JsonConvert.SerializeObject(data);
            using (StreamWriter sw = new StreamWriter("Data/collection.json"))
            {
                sw.WriteLine(json);
            }
            */

            string fp = "Data/collection.misiu29";
            FileStream fs = new FileStream(fp, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(((ListboxItem)listBox1.SelectedItem).ItemText + "_" + ((ListboxItem)listBox1.SelectedItem).ItemValue + "\n");
            sw.Close();
            fs.Close();
            MessageBox.Show("收藏成功^");
        }

        public async Task DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog, System.Windows.Forms.Label label1)
        {
            await Task<string>.Run(() =>
            {
                float percent = 0;
                try
                {

                    System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                    System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                    this.Invoke(new Action(() =>
                    {
                        button1.Enabled = false;
                        button2.Enabled = false;
                        textBox2.Enabled = false;
                        long totalBytes = myrp.ContentLength;
                        if (prog != null)
                        {
                            prog.Maximum = (int)totalBytes;
                        }
                        System.IO.Stream st = myrp.GetResponseStream();
                        System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                        long totalDownloadedByte = 0;
                        byte[] by = new byte[1024];
                        int osize = st.Read(by, 0, (int)by.Length);
                        while (osize > 0)
                        {
                            totalDownloadedByte = osize + totalDownloadedByte;
                            System.Windows.Forms.Application.DoEvents();
                            so.Write(by, 0, osize);
                            if (prog != null)
                            {
                                prog.Value = (int)totalDownloadedByte;
                            }
                            osize = st.Read(by, 0, (int)by.Length);

                            percent = (float)totalDownloadedByte / (float)totalBytes * 100;

                            label1.Text = "频道数据下载进度" + percent.ToString() + "%";

                            System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                        }
                        so.Close();
                        st.Close();
                        File.Copy("Data/Download.json", "Data/channels.json", true);
                        listBox1.Items.Clear();
                        ListAdd();
                        File.Delete("Data/Download.json");
                        button2.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                    }));
                }
                catch (System.Exception)
                {
                    throw;
                }
            });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                listBox1.Items.Clear();
                ListAdd();
                return;
            }
            else 
            {
                List<Data> queryData = new List<Data>();
                string strQuery = textBox2.Text;
                Regex r = new Regex(Regex.Escape(strQuery), RegexOptions.IgnoreCase);
                if (originData.Count > 0)
                {
                    listBox1.BeginUpdate();
                    for (int i=0;i<originData.Count;i++)
                    {
                        Match m = r.Match(((Data)originData[i]).name);
                        if (m.Success)
                        {
                            queryData.Add(originData[i]);
                        }
                    }
                    listBox1.EndUpdate();
                }
                if (queryData.Count > 0)
                {
                    listBox1.Items.Clear();
                    listBox1.BeginUpdate();

                    foreach (Data jobInfo in queryData)
                    {
                        //Console.Write(jobInfo.name + "\t");
                        //Console.Write(jobInfo.url + "\t");
                        //listBox1.Items.Add(jobInfo.name);
                        ListboxItem listItem = new ListboxItem(jobInfo.name, jobInfo.url);
                        listBox1.Items.Add(listItem);
                    }

                    listBox1.EndUpdate();
                }
                else 
                {
                    listBox1.Items.Clear();

                }
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
