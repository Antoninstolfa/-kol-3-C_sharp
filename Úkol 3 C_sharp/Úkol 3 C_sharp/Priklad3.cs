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
    public partial class Priklad3 : Form
    {
        public Priklad3()
        {
            InitializeComponent();
        }
private void Potvrdit_Click(object sender, EventArgs e)
        {
            double prumer, soucet = 0;
            int pocetS = 0, pocitadlo = 3;
            int cislo1 = 0, cislo2 = 0, cislo3 = 0;
            cislo1 = Convert.ToInt32(numericUpDown1.Value);
            cislo2 = Convert.ToInt32(numericUpDown2.Value);
            cislo3 = Convert.ToInt32(numericUpDown3.Value);
            if (cislo1 % 2 == 0)
            {
                pocetS++;
                pocitadlo--;
            }
            else soucet += cislo1;
            if (cislo2 % 2 == 0)
            {
                pocetS++;
                pocitadlo--;
            }
            else soucet += cislo2;
            if (cislo3 % 2 == 0)
            {
                pocetS++;
                pocitadlo--;
            }
            else soucet += cislo3;
            if (pocetS == 3)
            {
                MessageBox.Show("Pocet sudych cisel:"+ pocetS+ "\n"+"Nejsou hodnoty pro vypocet prumeru!");
            }
            else
            {
                prumer = soucet / pocitadlo;
                MessageBox.Show("Pocet sudych cisel:" + pocetS+"\nAritmeticky prumer lichych cisel:"+prumer);
            }
        }

        private void zpet_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
