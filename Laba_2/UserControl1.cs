using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class UserControl1 : UserControl
    {
        Random rd = new Random();
        public UserControl1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = rd.Next(1,7); i < j; i++)
            {
                label_1.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }
            for (int i = 0, j = rd.Next(1, 7); i < j; i++)
            {
                label_2.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }

            for (int i = 0, j = rd.Next(1, 7); i < j; i++)
            {
                label_3.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }

            for (int i = 0, j = rd.Next(1, 7); i < j; i++)
            {
                label_4.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }

            for (int i = 0, j = rd.Next(1, 7); i < j; i++)
            {
                label_5.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }

            for (int i = 0, j = rd.Next(1, 7); i < j; i++)
            {
                label_6.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }
            for (int i = 0, j = rd.Next(1, 7); i < j; i++)
            {
                label_7.Text = rd.Next(10).ToString();
                await Task.Delay(150);
            }

            listBox_1.Items.Add(label_1.Text + label_2.Text + label_3.Text + label_4.Text + label_5.Text + label_6.Text + label_7.Text);
        }
    }
}
