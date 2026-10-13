using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formapphafta3v._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onaylaButon_Click(object sender, EventArgs e)
        {
            float toplamTutar = 0;
            int indirimOranı;

            if (ogrenciRadio.Checked) { 
            
            indirimOranı = 4;
            }
            else if (kamuRadio.Checked) {
                indirimOranı = 5;
            }

            else
            {

                indirimOranı = 1;
            }
            



            if (pizzaCheck.Checked) {
                toplamTutar += 300;
            }

            if (hamburgerCheck.Checked)
            {
                toplamTutar += 300;
            }

            if (makarnaCheck.Checked)
            {
                toplamTutar += 150;
            }
            if (salgamCheck.Checked)
            {
                toplamTutar += 60;
            }
            if (kebapCheck.Checked)
            {
                toplamTutar += 450;
            }

            if (ayranCheck.Checked)
            {
                toplamTutar += 50;
            }
            if (kolaCheck.Checked)
            {
                toplamTutar += 75;
            }
            if (fantaCheck.Checked)
            {
                toplamTutar += 75;
            }

            float indirimTutarı;
            indirimTutarı = toplamTutar / indirimOranı;

            toplamTutar = toplamTutar - indirimTutarı;

            label1.Text = toplamTutar.ToString();

        }
    }
}
