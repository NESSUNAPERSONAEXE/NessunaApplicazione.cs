using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NessunaApliccazione
{
    public partial class Twitch : Form
    {
        public Twitch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/alessioloret");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/alessioloret");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
