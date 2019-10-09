using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Team_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rndTop = new Random();
            string[] topChampions = { "Garen", "Jax", "Nasus" };
            int topIndex = rndTop.Next(topChampions.Length);
            if (topIndex == 0)
            {
                Image image = Properties.Resources.garen;
                top.Image = image;
                topLane.Text = "Garen";
            }
            else if (topIndex == 1)
            {
                Image image = Properties.Resources.jax;
                top.Image = image;
                topLane.Text = "Jax";
            }
            else if (topIndex == 2)
            {
                Image image = Properties.Resources.nasus;
                top.Image = image;
                topLane.Text = "Nasus";
            }

            Random rndMid = new Random();
            string[] midChampions = { "Diana", "Lux", "Malzahar" };
            int midIndex = rndMid.Next(midChampions.Length);
            if (midIndex == 0)
            {
                Image image = Properties.Resources.diana;
                mid.Image = image;
                midLane.Text = "Diana";
            }
            else if (midIndex == 1)
            {
                Image image = Properties.Resources.lux;
                mid.Image = image;
                midLane.Text = "Lux";
            }
            else if (midIndex == 2)
            {
                Image image = Properties.Resources.malzahar;
                mid.Image = image;
                midLane.Text = "Malzahar";
            }

            Random rndJungle = new Random();
            string[] jungleChampions = { "Lee sin", "Nocturne", "Vi" };
            int jungleIndex = rndJungle.Next(jungleChampions.Length);
            if (jungleIndex == 0)
            {
                Image image = Properties.Resources.lee_sin;
                jungle.Image = image;
                jungler.Text = "Lee sin";
            }
            else if (jungleIndex == 1)
            {
                Image image = Properties.Resources.nocturne;
                jungle.Image = image;
                jungler.Text = "Nocturne";
            }
            else if (jungleIndex == 2)
            {
                Image image = Properties.Resources.vi;
                jungle.Image = image;
                jungler.Text = "Vi";
            }

            Random rndAdc = new Random();
            string[] adcChampions = { "Caitlyn", "Jhin", "Jinx" };
            int adcIndex = rndAdc.Next(adcChampions.Length);
            if (adcIndex == 0)
            {
                Image image = Properties.Resources.caitlyn;
                adc.Image = image;
                carry.Text = "Caitlyn";
            }
            else if (adcIndex == 1)
            {
                Image image = Properties.Resources.jhin;
                adc.Image = image;
                carry.Text = "Jhin";
            }
            else if (adcIndex == 2)
            {
                Image image = Properties.Resources.jinx;
                adc.Image = image;
                carry.Text = "Jinx";
            }

            Random rndSupp = new Random();
            string[] suppChampions = { "Blitzcrank", "Pyke", "Soraka" };
            int suppIndex = rndSupp.Next(suppChampions.Length);
            if (suppIndex == 0)
            {
                Image image = Properties.Resources.blitzcrank;
                supp.Image = image;
                support.Text = "Blitzcrank";
            }
            else if (suppIndex == 1)
            {
                Image image = Properties.Resources.pyke;
                supp.Image = image;
                support.Text = "Pyke";
            }
            else if (suppIndex == 2)
            {
                Image image = Properties.Resources.soraka;
                supp.Image = image;
                support.Text = "Soraka";
            }
        }

        private void TopLane_Click(object sender, EventArgs e)
        {
            if (topLane.Text == "Garen")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/86");
            }
            else if (topLane.Text == "Jax")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/24");
            }
            else if (topLane.Text == "Nasus")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/75");
            }
        }

        private void Jungler_Click(object sender, EventArgs e)
        {
            if (jungler.Text == "Lee sin")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/64");
            }
            else if (jungler.Text == "Vi")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/254");
            }
            else if (jungler.Text == "Nocturne")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/56");
            }
        }

        private void MidLane_Click(object sender, EventArgs e)
        {
            if (midLane.Text == "Diana")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/131");
            }
            else if (midLane.Text == "Lux")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/99");
            }
            else if (midLane.Text == "Malzahar")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/90");
            }
        }

        private void Carry_Click(object sender, EventArgs e)
        {
            if (carry.Text == "Caitlyn")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/51");
            }
            else if (carry.Text == "Jinx")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/222");
            }
            else if (carry.Text == "Jhin")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/202");
            }
        }

        private void Support_Click(object sender, EventArgs e)
        {
            if (support.Text == "Soraka")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/16");
            }
            else if (support.Text == "Pyke")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/555");
            }
            else if (support.Text == "Blitzcrank")
            {
                System.Diagnostics.Process.Start("https://www.probuilds.net/champions/details/53");
            }
        }
    }
}
