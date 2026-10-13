using System;
using System.Drawing;
using System.Windows.Forms;

namespace GörselProgramlamaForm1
{
    
    [Flags]
    public enum PizzaMalzemeleri
    {
        Yok = 0,
        Sucuk = 1,      
        Kasar = 2,      
        Biber = 4,      
        Misir = 8,      
        Mantar = 16     
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen adınızı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            PizzaMalzemeleri secilenMalzemeler = PizzaMalzemeleri.Yok;

            
            if (SucukCheck.Checked) secilenMalzemeler |= PizzaMalzemeleri.Sucuk;
            if (KasarCheck.Checked) secilenMalzemeler |= PizzaMalzemeleri.Kasar;
            if (BiberCheck.Checked) secilenMalzemeler |= PizzaMalzemeleri.Biber;
            if (MisirCheck.Checked) secilenMalzemeler |= PizzaMalzemeleri.Misir;
            if (MantarCheck.Checked) secilenMalzemeler |= PizzaMalzemeleri.Mantar;

            string detay = secilenMalzemeler == PizzaMalzemeleri.Yok
                ? "Sade Pizza (Malzeme seçilmedi)"
                : secilenMalzemeler.ToString();

            string mesaj = $"Müşteri: {textBox1.Text}\nSipariş Detayı: {detay}";

            MessageBox.Show(mesaj, "Sipariş Özeti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}