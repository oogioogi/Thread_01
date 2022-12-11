using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_01
{
    public partial class Form1 : Form
    {
        int positionX = 0;
        int positionY = 0;

        public Form1()
        {
            InitializeComponent();
            positionX = this.Location.X;
            positionY = this.Location.Y;
        }

        PlayerForm[] player = new PlayerForm[5];
        string[] names = new string[] {"심소군", "무안대군", "영안대군", "안성대군", "화평대군" };
        Random random= new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            positionX = this.Location.X + this.Size.Width;
            positionY = this.Location.Y;

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                player[i] = new PlayerForm(random.Next(200, 500), names[i]);
                player[i].Location = new Point(positionX, positionY + ((player[i].Size.Height + 1) * i));
                player[i].myDelegateEvent += Form1_myDelegateEvent;
                player[i].Show();
            }

            
        }

        private void Form1_myDelegateEvent(object sender)
        {
            try
            {
                var obj = sender as PlayerForm;
                this.Invoke(new Action(() => {
                    listBox1.Items.Add($"Form Text = {obj.Text}이 끝났습니다!");
                    obj.Close();
                }));
            }
            catch (Exception)
            {

                throw;
            }


 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 5)
            {
                numericUpDown1.Value = 5;
            }
        }
    }
}
