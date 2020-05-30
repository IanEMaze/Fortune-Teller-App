using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortune_Teller_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setting random number to zero before math is done
            int num = 0;

            //All possible futures
            string message1 = "You will purchase a new car soon....";
            string message2 = "You will recieve a raise this year...";
            string message3 = "You will meet a new friend soon...";
            string message4 = "You will purchase a new house soon...";
            string message5 = "Okay, nobody likes a show off...";
            string message6 = "You will recieve good news soon...";
            string message7 = "You will take an adventure soon...";
            string message8 = "You will start a new hobby soon...";

            //Array that holds all futures
            string[] messages = { message1, message2, message3, message4, message5, message6, message7, message8 };

            //Math time! (Random number between 0 and 8)
            Random rnd = new Random();
            num = rnd.Next(0, 7);

            //Display future after onclick
            MessageBox.Show(messages[num]);
        }
    }
}
