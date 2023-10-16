using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FrmBasicThread
{
    public partial class _FrmBasicThread : Form
    {
        public _FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = "- Before starting Thread -";
            label1.Text = start;
            Console.WriteLine(start);

            Thread ThreadA, ThreadB;

            ThreadStart delThreadStart = new ThreadStart(MyThreadClass.Thread1);

            ThreadA = new Thread(delThreadStart);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(delThreadStart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            string end = "- End of Thread -";
            label1.Text = end;
            Console.WriteLine(end);
        }
    }
}
