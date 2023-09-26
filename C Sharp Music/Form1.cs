using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace C_Sharp_Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer player = new SoundPlayer("https://cdn.discordapp.com/attachments/839537395438583808/1156332568627646646/y2mate.is_-_Bars_Akarsu_Islak_Islak-2jSMXR71d6c-192k-1695761493.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            button1.Visible = true;
            button2.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fastuptime");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
