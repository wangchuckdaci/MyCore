using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void MyAdd(long m);

        private void button1_Click(object sender, EventArgs e)
        {

            Task.Factory.StartNew(() => AddNum());


            //AddNum();
        }


        private async void AddNum()
        {
            //label1.Text = "";
            var dt1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");
            long m = 0;
            MyAdd p = new MyAdd(Add);
            this.Invoke((MethodInvoker)delegate { label2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"); });

            while (true)
            {
                m = m + 1;
                if (m % 1800 == 0)
                {
                    this.Invoke((MethodInvoker)delegate { label2.Text = label2.Text + ";" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"); });
                }
                //p(m);
                this.Invoke((MethodInvoker)delegate { label1.Text = m.ToString(); });
                Thread.Sleep(100);
            }
        }

        private void Add(long m)
        {
            label1.Text = m.ToString();
            label1.Refresh();
        }



    }
}
