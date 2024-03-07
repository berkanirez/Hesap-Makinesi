namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizleme;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlabel.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }

        private void toplambutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void carpimbutton_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void bolumbutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            int ikinciSayi = Convert.ToInt32(ekranlabel.Text);

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case 'x':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
            }
            ekranlabel.Text = Convert.ToString(sonuc);
        }
    }
}
