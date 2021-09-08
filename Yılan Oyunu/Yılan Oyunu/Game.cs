using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılan_Oyunu
{
    public partial class Game : Form
    {
        private int yilanparcasiarasimesafe = 2;
        private Label yilankafasi;
        private int yilanparcasisayisi;
        private int yilanboyut = 20;
        private int yemboyut = 20;
        private Random random;
        private Label yem;
        private hareketyonu yon;
        public Game()
        {
            InitializeComponent();
            random = new Random();
        }

        private void yenidenbaslat()
        {
            lblpuan.Text = "0";
            lblsüre1.Text = "0";
            sifirla();
        }
        public void sifirla()
        {
            Pnl.Controls.Clear();
            yilanparcasisayisi = 0;
            yemolustur();
            YeminYeriniDegistir();
            YilanYerlestir();
            yon = hareketyonu.Saga;
            timerYılanHareket.Enabled = true;
            timersaat.Enabled = true;
        }
        public Label YilanParcasiOlustur(int locationX,int locationY)
        {
            yilanparcasisayisi++;
            Label lbl = new Label()
            {
                Name = "YilanParca" + yilanparcasisayisi,
                BackColor = Color.Green,
                Width = yilanboyut,
                Height = yilanboyut,
                Location =new Point(locationX,locationY)
            };
            this.Pnl.Controls.Add(lbl);
            return lbl;
        }

        private void YilanYerlestir()
        {
            yilankafasi = YilanParcasiOlustur(0, 0);
            yilankafasi.Text = ":";
            yilankafasi.TextAlign = ContentAlignment.MiddleCenter;
            yilankafasi.ForeColor = Color.White;
            var LocationX = (Pnl.Width / 2) - (yilankafasi.Width / 2);
            var LocationY = (Pnl.Height / 2) - (yilankafasi.Height / 2);
            yilankafasi.Location = new Point(LocationX, LocationY);
        }

        private void yemolustur()
        {
            Label lbl = new Label()
            {
                Name = "Yem" ,
                BackColor = Color.White,
                Width = yemboyut,
                Height = yemboyut,
            };
            yem = lbl;
            this.Pnl.Controls.Add(lbl);
        }

        private void YeminYeriniDegistir()
        {
            var locationX = 0;
            var locationY = 0;
            bool durum;
            do
            {
                durum = false;
                locationX = random.Next(0, Pnl.Width - yemboyut);
                locationY = random.Next(0, Pnl.Height - yemboyut);
                var rect1 = new Rectangle(new Point(locationX, locationY), yem.Size);
                foreach (Control control in Controls)
                {
                    if (control is Label && control.Name.Contains("YilanParca"))
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);
                        if (rect1.IntersectsWith(rect2))
                        {
                            durum = true;
                            break;
                        }
                    }
                }
            } while (durum);
            yem.Location = new Point(locationX, locationY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifirla();
        }
        private enum hareketyonu
        {
            Yukari,
            Asagi,
            Sola,
            Saga
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var keycode = e.KeyCode;
            if (yon == hareketyonu.Sola && keycode ==Keys.D
                || yon == hareketyonu.Saga && keycode == Keys.A
                || yon == hareketyonu.Yukari && keycode == Keys.S
                || yon == hareketyonu.Asagi && keycode == Keys.W)
            {
                return;
            }
            switch (keycode)
            {
                case Keys.W:
                    yon = hareketyonu.Yukari;
                    break;
                case Keys.S:
                    yon = hareketyonu.Asagi;
                    break;
                case Keys.A:
                    yon = hareketyonu.Sola;
                    break;
                case Keys.D:
                    yon = hareketyonu.Saga;
                    break;
                case Keys.P:
                    timersaat.Enabled = false;
                    timerYılanHareket.Enabled = false;
                    break;
                case Keys.C:
                    timersaat.Enabled = true;
                    timerYılanHareket.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void timerYılanHareket_Tick(object sender, EventArgs e)
        {
            yilankafasinitakipet();
            yilaniyurut();
            oyunbittimi();
            yilanyemiyedimi();

        }

        private void yilaniyurut()
        {
            var LocationX = yilankafasi.Location.X;
            var LocationY = yilankafasi.Location.Y;

            switch (yon)
            {
                case hareketyonu.Yukari:
                    yilankafasi.Location = new Point(LocationX, LocationY - (yilankafasi.Width + yilanparcasiarasimesafe));
                    break;
                case hareketyonu.Asagi:
                    yilankafasi.Location = new Point(LocationX, LocationY + (yilankafasi.Width + yilanparcasiarasimesafe));
                    break;
                case hareketyonu.Sola:
                    yilankafasi.Location = new Point(LocationX - (yilankafasi.Width + yilanparcasiarasimesafe), LocationY);
                    break;
                case hareketyonu.Saga:
                    yilankafasi.Location = new Point(LocationX + (yilankafasi.Width + yilanparcasiarasimesafe), LocationY);
                    break;
                default:
                    break;
            }
        }

        private void oyunbittimi()
        {
            bool oyunbittimi = false;
            var rect1 = new Rectangle(yilankafasi.Location, yilankafasi.Size);
            foreach (Control control in Pnl.Controls)
            {
                if (control is Label && control.Name.Contains("YilanParca") && control.Name != yilankafasi.Name)
                {
                    var rect2 = new Rectangle(control.Location, control.Size);
                    if (rect1.IntersectsWith(rect2))
                    {
                        oyunbittimi = true;
                        break;
                    }
                }
            }
            if (oyunbittimi)
            {
                timerYılanHareket.Enabled = false;
                timersaat.Enabled = false;
                DialogResult sonuc = MessageBox.Show("Puanınız: " + lblpuan.Text, "Oyun Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (sonuc == DialogResult.OK)
                {
                    yenidenbaslat();
                }
            }
        }

        private void yilanyemiyedimi()
        {
            var rect1 = new Rectangle(yilankafasi.Location, yilankafasi.Size);
            var rect2 = new Rectangle(yem.Location, yem.Size);
            if (rect1.IntersectsWith(rect2))
            {
                lblpuan.Text = (Convert.ToInt32(lblpuan.Text) + 10).ToString();
                YeminYeriniDegistir();
                YilanParcasiOlustur(-yilanboyut, -yilanboyut);
            }
        }

        private void yilankafasinitakipet()
        {
            if (yilanparcasisayisi <= 1) return;

            for (int i = yilanparcasisayisi; i > 1; i--)
            {
                var sonrakiparca = (Label)Pnl.Controls[i];
                var oncekiparca = (Label)Pnl.Controls[i-1];
                sonrakiparca.Location = oncekiparca.Location;
            }
        }

        private void timersaat_Tick(object sender, EventArgs e)
        {
            lblsüre1.Text = (Convert.ToInt32(lblsüre1.Text) + 1).ToString();
        }
    }
}
