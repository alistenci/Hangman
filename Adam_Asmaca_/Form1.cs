using Adam_Asmaca_.Properties;
using System.Resources;

namespace Adam_Asmaca_
{
    public partial class Form1 : Form
    {
        #region Diziler
        string[] cities = new string[]
        {
            "Londra" , "Ýstanbul" , "Berlin"
        };
        string[] fruits = new string[]
        {
            "Apple", "Raspberry", "watermelon"
        };
        string[] countries = new string[]
        {
            "Germany", "England", "Switzerland"
        };
        #endregion
        string[] secilenDizi;
        Random rnd = new Random();
        string secilenKelime = "";
        char basilanTus;
        char[] karakter = new char[0];
        int kontrol = 0;
        int hak = 6;
        string secilenKategori;
        int saniye = 3;
        char[] tusKontrol = new char[0];
        public Form1()
        {
            Random rnd = new Random();
            int secilenIndex = rnd.Next(0, 3);

            if (secilenIndex == 0)
            {
                secilenDizi = cities;
                secilenKategori = "CLUE: City";
            }
            else if (secilenIndex == 1)
            {
                secilenDizi = fruits;
                secilenKategori = "CLUE: Fruit";
            }
            else
            {
                secilenDizi = countries;
                secilenKategori = "CLUE: Country";
            }
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblHak.Text = "Your Remaining Right: " + hak;
            lblSaniye.Visible = false;
            lblBilgi.Text = "Hangman";
            secilenKelime = secilenDizi[rnd.Next(0, secilenDizi.Length)]; // rasgele kelime seçtik
            karakter = Enumerable.Repeat('_', secilenKelime.Length).ToArray(); // karakter dizisini secilenKelimenin uzunluðu kadar '_' ile doldurduk.
            label2.Text = string.Join(" ", karakter); // karakter dizisinin elemanlarýný araya bir boþluk " " koyarak string ifade olarak birleþtirdik
            label1.Text = secilenKategori;
            for (int i = 0; i < karakter.Length; i++)
            {
                label2.Text += '_';
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') // Boþluk tuþuna basýlýrsa iþlem yapma
            {
                return;
            }
            basilanTus = char.ToLower(e.KeyChar);
            if (tusKontrol.Contains(basilanTus))
            {
                MessageBox.Show("You have already chosen this letter");
                return;
            }
            tusKontrol = karakter.Append(basilanTus).ToArray(); // bastýðým her tuþu oluþturduðum char dizisine aktardým.
            if (secilenKelime.ToLower().Contains(basilanTus))

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (char.ToLower(secilenKelime[i]) == basilanTus)
                    {
                        karakter[i] = secilenKelime[i];
                    }
                }

            else
            {
                kontrol++;
                hak--;
                lblHak.Text = "Your Remaining Right: " + hak;
                if (hak == 0)
                {
                    lblHak.Text = "You have no rights anymore";
                    lblSaniye.Visible = true;
                    timer1.Start();

                }
                ResimGoster();
            }
            label3.Text += basilanTus.ToString() + ", ";
            label2.Text = string.Join(" ", karakter);
            if (!(label2.Text.Contains("_")))
            {
                //MessageBox.Show("Tebrikler Kazandýnýz. Yeniden Baþlatýlýyor...");
                lblSaniye.Visible = true;
                timer1.Start();
            }
        }
        #region Metod
        void ResimGoster()
        {
            if (kontrol == 1)
            {
                pictureBox1.Image = Resources._1;
            }
            else if (kontrol == 2)
            {
                pictureBox1.Image = Resources._2;

            }
            else if (kontrol == 3)
            {
                pictureBox1.Image = Resources._3;

            }
            else if (kontrol == 4)
            {
                pictureBox1.Image = Resources._4;

            }
            else if (kontrol == 5)
            {
                pictureBox1.Image = Resources._5;

            }
            else
            {
                pictureBox1.Image = Resources._6;
                MessageBox.Show("You Lost, Correct Word: " + secilenKelime);
            }
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = saniye - 1;
            lblSaniye.Text = "Congratulations, you won. The app will restart " + saniye.ToString() + " after seconds";
            if (saniye == 0)
            {
                Application.Restart();
            }
        }


    }
}