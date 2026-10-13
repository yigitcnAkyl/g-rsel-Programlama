using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselprogramlama_3hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onaylaButon_Click(object sender, EventArgs e)
        {
            int toplamKredi = 0;

            if (gorselProgramlama.Checked) {

                toplamKredi = toplamKredi + 4;


            }


            if (yalinProgramlama.Checked)
            {
                toplamKredi += 3;
            }

            if (fonksiyonelProgramlama.Checked)
            {
                toplamKredi += 4;
                    
                    }

            if (ingilizce.Checked)
            {

                toplamKredi += 2;

            }


            //MessageBox.Show("Toplam Seçili Kredi:"+toplamKredi);

            label3.Text = "Toplam Seçili Kredi" + toplamKredi;

        }
    }
}
