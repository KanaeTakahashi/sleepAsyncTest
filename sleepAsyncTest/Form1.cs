using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sleepAsyncTest
{
    /// <summary>
    /// 非同期処理のテスト
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task sleepAsync()
        {
            await Task.Delay(3000);
            pictureBox1.Image = null;
            label2.Text = "sleepAsync";
        }
        private async void sleepAsync2()
        {
            await Task.Delay(3000);
            pictureBox1.Image = null;
            label2.Text = "sleepAsync";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "aa";
            pictureBox1.Image = System.Drawing.Image.FromFile(@"D:\aaa.jpg");

            //Task result = sleepAsync();
            sleepAsync2();

            //System.Threading.Thread.Sleep(3000);

            label2.Text = "BBBBBBBBBBB";
        }
    }
}
