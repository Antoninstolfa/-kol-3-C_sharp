using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_3_C_sharp
{
    public partial class Priklad4 : Form
    {
        public Priklad4()
        {
            InitializeComponent();
        }
        
        private void vypocet_Click(object sender, EventArgs e)
        {
            int cislo1 = 0, cislo2 = 0, cislo3 = 0, cislo4 = 0;
            int pomocna = 0;
            bool chyba = false;
            //try
            //{
                chyba = false;
                cislo1 = Convert.ToInt32(textBox1.Text);
                cislo2 = Convert.ToInt32(textBox2.Text);
                cislo3 = Convert.ToInt32(textBox3.Text);
                cislo4 = Convert.ToInt32(textBox4.Text);
           // }
            //catch(Exception)
            //{
                //chyba = true;
                //MessageBox.Show("Error!");
            //}
            double vysledek;
            if (chyba == false)
            {
                if (soucet.Checked)
                {
                    vysledek = cislo1 + cislo2 + cislo3 + cislo4;
                    MessageBox.Show("Vysledek:" + vysledek);
                }
                if (soucin.Checked)
                {
                    vysledek = cislo1 * cislo2 * cislo3 * cislo4;
                    MessageBox.Show("Vysledek:" + vysledek);
                }
                if (prumer.Checked)
                {
                    pomocna = cislo1 + cislo2 + cislo3 + cislo4;
                    vysledek = Convert.ToDouble(pomocna) / 4;
                    MessageBox.Show("Vysledek:" + vysledek);
                }
                if (!soucin.Checked && !soucet.Checked && !prumer.Checked)
                {
                    MessageBox.Show("Vyberte jakou operaci chcete provest.");
                }
            }
        }
        private void zpet_Click(object sender, EventArgs e)
        {
            Close();
        }

    }   
}
