using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectPort_Click(object sender, EventArgs e)
        {
            String selectPort = this.comPorts.Items[this.comPorts.SelectedIndex].ToString();
            Console.WriteLine(selectPort+" CONN");
            this.textout.Text = selectPort+" CONN";
        }

        private void led_btn_on_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            this.textout.Text = "LED_01 ON SUCCESS";
        }

        private void led_btn_off_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            this.textout.Text = "LED_01 OFF SUCCESS";
        }

        private void led_btn_on_2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            this.textout.Text = "LED_02 ON SUCCESS";
        }

        private void led_btn_off_2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            this.textout.Text = "LED_02 OFF SUCCESS";
        }


    }
}
