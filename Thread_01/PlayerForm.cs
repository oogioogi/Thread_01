using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_01
{
    public partial class PlayerForm : Form
    {
        public delegate void myDelegate(object sender);
        public event myDelegate myDelegateEvent;

        public Thread thread;
        private int _random;
        private string _name;
        private bool escape = false;

        public PlayerForm(int random, string name)
        {
            _random = random;
            _name = name;
            InitializeComponent();
            threadProcess();
        }

        private void threadProcess()
        {
            lableName.Text = _name;
            this.Text = _name;  
            thread = new Thread(() => runnig(_random));
            thread.Start();
        }

        private void runnig(int random)
        {
            int i = 0;

            try
            {
                 while (i < 100 && !escape)
                 {
                     i++;

                     if (this.InvokeRequired)
                     {
                         this.Invoke(new Action(() =>
                         {
                             progressBar1.Value = i;
                             lableStatus.Text = $"진행 상황 표시: {i}%";
                         }));
                     }
                     Thread.Sleep(random);
                 }
                finish();
            }
            catch (ThreadInterruptedException e)
            {
                MessageBox.Show(e.Message);
                
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        public void ThreadAbort()
        {
            if (thread.IsAlive)
            {
                thread.Abort();
            }
        }

        public void ThreadJoin()
        {
            if (thread.IsAlive)
            {
                thread.Join(3000);
            }
        }

        public void ThreadInterrupt()
        {
            if (thread.IsAlive)
            {
                thread.Interrupt();
            }
        }

        private void btnGiveup_Click(object sender, EventArgs e)
        {
            finish();
        }

        private void finish()
        {
            escape = true;
            myDelegateEvent(this);
            //ThreadAbort();
            //ThreadJoin();
            ThreadInterrupt();
        }
    }
}
