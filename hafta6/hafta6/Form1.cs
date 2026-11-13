using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hafta6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                checkedListBox1.Items.Add(textBox1.Text);

            }
            else {
                MessageBox.Show("geçerli bişi girin");
            
            }
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;

            checkedListBox1.Items.Add("Gömlek");
            checkedListBox1.Items.Add("Tişört");
            checkedListBox1.Items.Add("Sweat");
            checkedListBox1.Items.Add("Pantalon");

            label2.Text = "0 tl";

        }
        //bunu kullansaydık fiyat hesaplamasını 1 tane öncesinden yapıyordu
        /*
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }
        */

        //mouse up tıkladım tam bıraktıgım an çalıştır demek
        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++) {

                if (checkedListBox1.GetItemChecked(i))
                {
                    string urun =checkedListBox1.GetItemText(i);
                    if (urun == "Ceket") toplam += 1000;
                    else if (urun == "Gömlek") toplam += 500;
                    else if (urun == "Pantolon") toplam += 750;1
                    else if (urun == "Ayakkabı") toplam += 1200;
                    else toplam += 300;

                    label2.Text = "toplam" + toplam + "tuttu";
                }
            
            }

        }
    }
}