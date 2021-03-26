using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tv
{
    public partial class Form2 : Form
    {
        public string URL
        {
            get
            {
                return textBox1.Text;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string txt2 = textBox1.Text;
            try
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    //MessageBox.Show((string)iData.GetData(DataFormats.Text));
                    textBox1.Text = (string)iData.GetData(DataFormats.UnicodeText);
                }
                else
                {
                    //MessageBox.Show("目前剪贴板中数据不可转换为文本", "错误");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error");
            }
        }
    }
}
