using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form
    {
        private int suankiOyuncu;
        private bool oyunBasladi;
        private PictureBox[] kutular;

        public Form1()
        {
            InitializeComponent();
            suankiOyuncu = 0;
            oyunBasladi = false;

            kutular = new PictureBox[] { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };

            foreach (var pb in kutular)
            {
                pb.Click += pb_Click;
            }
        }

        void oyunuBaslat()
        {
            lblKazan.Text = "";
            lblSs1.Visible = suankiOyuncu == 0;
            lblSs2.Visible = suankiOyuncu == 1;
            oyunBasladi = true;
        }

        void oyunuBitir()
        {
            lblSs1.Visible = false;
            lblSs2.Visible = false;
            oyunBasladi = false;
        }

        void SiradakiOyuncu()
        {
            lblSs1.Visible = suankiOyuncu == 0;
            lblSs2.Visible = suankiOyuncu == 1;
        }

        void oyna(PictureBox tiklananKutu)
        {
            if (!oyunBasladi || tiklananKutu.Image != null)
                return;

            tiklananKutu.Image = suankiOyuncu == 0 ? Properties.Resources.ticktacktoeX1 : Properties.Resources.ticktacktoeO1;

            if (OyunBittiMi())
            {
                lblKazan.Text = suankiOyuncu == 0 ? "Player 1 Won" : "Player 2 Won";
                oyunuBitir();
            }
            else
            {
                suankiOyuncu = (suankiOyuncu + 1) % 2;
                SiradakiOyuncu();
            }
        }

        bool OyunBittiMi()
        {
            int[][] kazanmaKombinasyonlari = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 }
            };

            foreach (var kombinasyon in kazanmaKombinasyonlari)
            {
                if (kutular[kombinasyon[0]].Image != null &&
                    kutular[kombinasyon[0]].Image == kutular[kombinasyon[1]].Image &&
                    kutular[kombinasyon[1]].Image == kutular[kombinasyon[2]].Image)
                {
                    return true;
                }
            }

            return false;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox tiklananKutu = sender as PictureBox;
            oyna(tiklananKutu);
        }

        private void btnBaslat_Click_1(object sender, EventArgs e)
        {
            foreach (var pb in kutular)
            {
                pb.Image = null;
            }

            suankiOyuncu = 0;
            oyunuBaslat();





            
        }
    }
}
