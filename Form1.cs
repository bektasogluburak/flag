using System.Drawing.Drawing2D;

namespace flag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Gray,
                                                                       Color.Black,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        public List<String> ulkeler = new List<string>()
                    {
                        "Afghanistan",
                        "Albania",
                        "Algeria",
                        "Andorra",
                        "Angola",
                        "Antigua",
                        "Argentina",
                        "Armenia",
                        "Australia",
                        "Austria",
                        "Azerbaijan",
                        "Bahamas",
                        "Bahrain",
                        "Bangladesh",
                        "Barbados",
                        "Belarus",
                        "Belgium",
                        "Belize",
                        "Benin",
                        "Bhutan",
                        "Bolivia",
                        "Bosnia-Herzegovina",
                        "Botswana",
                        "Brazil",
                        "Brunei",
                        "Bulgaria",
                        "Burkina-Faso",
                        "Burundi",
                        "Cabo-Verde",
                        "Cambodia",
                        "Cameroon",
                        "Canada",
                        "Central-African-Republic",
                        "Chad",
                        "Chile",
                        "China",
                        "Colombia",
                        "Comoros",
                        "Congo-Democratic-Republic-of",
                        "Congo",
                        "Costa-Rica",
                        "Cote-d-Ivoire",
                        "Croatia",
                        "Cuba",
                        "Cyprus",
                        "Czech-Republic",
                        "Denmark",
                        "Djibouti",
                        "Dominica",
                        "Dominican-Republic",
                        "Ecuador",
                        "Egypt",
                        "El-Salvador",
                        "Equatorial-Guinea",
                        "Eritrea",
                        "Estonia",
                        "Eswatini",
                        "Ethiopia",
                        "Fiji",
                        "Finland",
                        "France",
                        "Gabon",
                        "Gambia",
                        "Georgia",
                        "Germany",
                        "Ghana",
                        "Greece",
                        "Grenada",
                        "Guatemala",
                        "Guinea-Bissau",
                        "Guinea",
                        "Guyana",
                        "Haiti",
                        "Honduras",
                        "Hungary",
                        "Iceland",
                        "India",
                        "Indonesia",
                        "Iran",
                        "Iraq",
                        "Ireland",
                        "Israel",
                        "Italy",
                        "Jamaica",
                        "Japan",
                        "Jordan",
                        "Kazakhstan",
                        "Kenya",
                        "Kiribati",
                        "Korea-North",
                        "Korea-South",
                        "Kosovo",
                        "Kuwait",
                        "Kyrgyzstan",
                        "Laos",
                        "Latvia",
                        "Lebanon",
                        "Lesotho",
                        "Liberia",
                        "Libya",
                        "Liechtenstein",
                        "Lithuania",
                        "Luxembourg",
                        "Madagascar",
                        "Malawi",
                        "Malaysia",
                        "Maldives",
                        "Mali",
                        "Malta",
                        "Marshall-Islands",
                        "Mauritania",
                        "Mauritius",
                        "Mexico",
                        "Micronesia",
                        "Moldova",
                        "Monaco",
                        "Mongolia",
                        "Montenegro",
                        "Morocco",
                        "Mozambique",
                        "Myanmar",
                        "Namibia",
                        "Nauru",
                        "Nepal",
                        "Netherlands",
                        "New-Zealand",
                        "Nicaragua",
                        "Niger",
                        "Nigeria",
                        "North-Macedonia",
                        "Norway",
                        "Oman",
                        "Pakistan",
                        "Palau",
                        "Palestine",
                        "Panama",
                        "Papua-New-Guinea (1)",
                        "Papua-New-Guinea",
                        "Paraguay",
                        "Peru",
                        "Philippines",
                        "Poland",
                        "Portugal",
                        "Qatar",
                        "Romania",
                        "Russia",
                        "Rwanda",
                        "Samoa",
                        "San-Marino",
                        "Sao-Tome-and-Principe",
                        "Saudi-Arabia",
                        "Senegal",
                        "Serbia",
                        "Seychelles",
                        "Sierra-Leone",
                        "Singapore",
                        "Slovakia",
                        "Slovenia",
                        "Solomon-Islands",
                        "Somalia",
                        "South-Africa",
                        "South-Sudan",
                        "Spain",
                        "Sri-Lanka",
                        "St-Kitts-Nevis",
                        "St-Lucia",
                        "St-Vincent-the-Grenadines",
                        "Sudan",
                        "Suriname",
                        "Sweden",
                        "Switzerland",
                        "Syria",
                        "Taiwan",
                        "Tajikistan",
                        "Tanzania",
                        "Thailand",
                        "Timor-Leste",
                        "Togo",
                        "Tonga",
                        "Trinidad-and-Tobago",
                        "Tunisia",
                        "Turkiye",
                        "Turkmenistan",
                        "Tuvalu",
                        "Uganda",
                        "Ukraine",
                        "United-Arab-Emirates",
                        "United-Kingdom",
                        "United-States-of-America",
                        "Uruguay",
                        "Uzbekistan",
                        "Vanuatu",
                        "Vatican-City",
                        "Venezuela",
                        "Vietnam",
                        "Yemen",
                        "Zambia",
                        "Zimbabwe"
                    };
        public string dogruSecim = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, ulkeler.Count);
            //label1.Text = sayi.ToString();
            dogruSecim = ulkeler[sayi];


            //buraya label deðil picturebox a jpg eklenecek
            var enviroment = System.Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.Parent.FullName;
            pictureBox1.Image = new Bitmap(projectDirectory + @"\bayraklar\flag-of-" + dogruSecim + ".png");

            //label1.Text = dogruSecim;
            ulkeler.RemoveAt(sayi);
            int dogruButonRandom = rnd.Next(0, 4);

            string option2= ulkeler[rnd.Next(0, ulkeler.Count)];
            string option3 = option2, option4 = option2, option5=option2;
            while (option2==option3)
            {
                option3= ulkeler[rnd.Next(0, ulkeler.Count)];
            }

            while (option2 == option4)
            {
                option4 = ulkeler[rnd.Next(0, ulkeler.Count)];
            }

            while (option2 == option5)
            {
                option5 = ulkeler[rnd.Next(0, ulkeler.Count)];
            }

            if (dogruButonRandom == 0)
                button1.Text = dogruSecim;
            else
                button1.Text = option2;


            if (dogruButonRandom == 1)
                button2.Text = dogruSecim;
            else
                button2.Text = option3;


            if (dogruButonRandom == 2)
                button3.Text = dogruSecim;
            else
                button3.Text = option4;


            if (dogruButonRandom == 3)
                button4.Text = dogruSecim;
            else
                button4.Text = option5;

            if(dogruSayisi+yanlisSayisi==10)
            {
                string mesaj = "Doðru Sayýsý= " + dogruSayisi + " Yanlýþ Sayýsý= " + yanlisSayisi;
                MessageBox.Show(mesaj, "Yarýþma Bitti");
                yarismaSifirla();
            }

        }
        public  void yarismaSifirla()
        {
            ulkeler.Clear();
            ulkeler=new List<string>{
                        "Afghanistan",
                        "Albania",
                        "Algeria",
                        "Andorra",
                        "Angola",
                        "Antigua",
                        "Argentina",
                        "Armenia",
                        "Australia",
                        "Austria",
                        "Azerbaijan",
                        "Bahamas",
                        "Bahrain",
                        "Bangladesh",
                        "Barbados",
                        "Belarus",
                        "Belgium",
                        "Belize",
                        "Benin",
                        "Bhutan",
                        "Bolivia",
                        "Bosnia-Herzegovina",
                        "Botswana",
                        "Brazil",
                        "Brunei",
                        "Bulgaria",
                        "Burkina-Faso",
                        "Burundi",
                        "Cabo-Verde",
                        "Cambodia",
                        "Cameroon",
                        "Canada",
                        "Central-African-Republic",
                        "Chad",
                        "Chile",
                        "China",
                        "Colombia",
                        "Comoros",
                        "Congo-Democratic-Republic-of",
                        "Congo",
                        "Costa-Rica",
                        "Cote-d-Ivoire",
                        "Croatia",
                        "Cuba",
                        "Cyprus",
                        "Czech-Republic",
                        "Denmark",
                        "Djibouti",
                        "Dominica",
                        "Dominican-Republic",
                        "Ecuador",
                        "Egypt",
                        "El-Salvador",
                        "Equatorial-Guinea",
                        "Eritrea",
                        "Estonia",
                        "Eswatini",
                        "Ethiopia",
                        "Fiji",
                        "Finland",
                        "France",
                        "Gabon",
                        "Gambia",
                        "Georgia",
                        "Germany",
                        "Ghana",
                        "Greece",
                        "Grenada",
                        "Guatemala",
                        "Guinea-Bissau",
                        "Guinea",
                        "Guyana",
                        "Haiti",
                        "Honduras",
                        "Hungary",
                        "Iceland",
                        "India",
                        "Indonesia",
                        "Iran",
                        "Iraq",
                        "Ireland",
                        "Israel",
                        "Italy",
                        "Jamaica",
                        "Japan",
                        "Jordan",
                        "Kazakhstan",
                        "Kenya",
                        "Kiribati",
                        "Korea-North",
                        "Korea-South",
                        "Kosovo",
                        "Kuwait",
                        "Kyrgyzstan",
                        "Laos",
                        "Latvia",
                        "Lebanon",
                        "Lesotho",
                        "Liberia",
                        "Libya",
                        "Liechtenstein",
                        "Lithuania",
                        "Luxembourg",
                        "Madagascar",
                        "Malawi",
                        "Malaysia",
                        "Maldives",
                        "Mali",
                        "Malta",
                        "Marshall-Islands",
                        "Mauritania",
                        "Mauritius",
                        "Mexico",
                        "Micronesia",
                        "Moldova",
                        "Monaco",
                        "Mongolia",
                        "Montenegro",
                        "Morocco",
                        "Mozambique",
                        "Myanmar",
                        "Namibia",
                        "Nauru",
                        "Nepal",
                        "Netherlands",
                        "New-Zealand",
                        "Nicaragua",
                        "Niger",
                        "Nigeria",
                        "North-Macedonia",
                        "Norway",
                        "Oman",
                        "Pakistan",
                        "Palau",
                        "Palestine",
                        "Panama",
                        "Papua-New-Guinea (1)",
                        "Papua-New-Guinea",
                        "Paraguay",
                        "Peru",
                        "Philippines",
                        "Poland",
                        "Portugal",
                        "Qatar",
                        "Romania",
                        "Russia",
                        "Rwanda",
                        "Samoa",
                        "San-Marino",
                        "Sao-Tome-and-Principe",
                        "Saudi-Arabia",
                        "Senegal",
                        "Serbia",
                        "Seychelles",
                        "Sierra-Leone",
                        "Singapore",
                        "Slovakia",
                        "Slovenia",
                        "Solomon-Islands",
                        "Somalia",
                        "South-Africa",
                        "South-Sudan",
                        "Spain",
                        "Sri-Lanka",
                        "St-Kitts-Nevis",
                        "St-Lucia",
                        "St-Vincent-the-Grenadines",
                        "Sudan",
                        "Suriname",
                        "Sweden",
                        "Switzerland",
                        "Syria",
                        "Taiwan",
                        "Tajikistan",
                        "Tanzania",
                        "Thailand",
                        "Timor-Leste",
                        "Togo",
                        "Tonga",
                        "Trinidad-and-Tobago",
                        "Tunisia",
                        "Turkiye",
                        "Turkmenistan",
                        "Tuvalu",
                        "Uganda",
                        "Ukraine",
                        "United-Arab-Emirates",
                        "United-Kingdom",
                        "United-States-of-America",
                        "Uruguay",
                        "Uzbekistan",
                        "Vanuatu",
                        "Vatican-City",
                        "Venezuela",
                        "Vietnam",
                        "Yemen",
                        "Zambia",
                        "Zimbabwe"
                    };
            dogruSayisi=0;
            yanlisSayisi=0;
            //dogruSecim = "";
        }
        public int dogruSayisi=0, yanlisSayisi=0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dogruSecim == button1.Text)
            {
                MessageBox.Show("Doðru Cevap", "Tebrikler");
                dogruSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Yanlýþ", "Üzgünüz");
                yanlisSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dogruSecim == button2.Text)
            {
                MessageBox.Show("Doðru Cevap", "Tebrikler");
                dogruSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Yanlýþ", "Üzgünüz");
                yanlisSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dogruSecim == button3.Text)
            {
                MessageBox.Show("Doðru Cevap", "Tebrikler");
                dogruSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Yanlýþ", "Üzgünüz");
                yanlisSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dogruSecim == button4.Text)
            {
                MessageBox.Show("Doðru Cevap", "Tebrikler");
                dogruSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Yanlýþ", "Üzgünüz");
                yanlisSayisi++;
                Form1_Load(this, EventArgs.Empty);
            }
        }
    }
}