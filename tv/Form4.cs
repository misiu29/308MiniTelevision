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
using System.IO;

namespace tv
{
    public partial class Form4 : Form
    {
        public string URL2
        {
            get
            {
                return ((ListboxItem)listBox1.SelectedItem).ItemValue;
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
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
            FileStream fs = new FileStream("Data/collection.misiu29", FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader reader = new StreamReader(fs,Encoding.UTF8);
            string line = null;
            while ((line = reader.ReadLine()) != null) //每次读取一行
            {
                string[] sArray = line.Split('_');
                ListboxItem listItem = new ListboxItem(sArray[0], sArray[1]);
                listBox1.Items.Add(listItem);
                //Console.WriteLine(line);
            }
            reader.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //getJson = GetJson.GetLocal1();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //ListAdd();
        }
        void ListAdd()
        {
            List<Data> jobInfoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Data>>(getJson);
            foreach (Data jobInfo in jobInfoList)
            {
                //Console.Write(jobInfo.name + "\t");
                //Console.Write(jobInfo.url + "\t");
                //listBox1.Items.Add(jobInfo.name);
                ListboxItem listItem = new ListboxItem(jobInfo.name, jobInfo.url);
                listBox1.Items.Add(listItem);
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
