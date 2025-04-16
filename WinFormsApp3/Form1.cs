using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private ImageList horoscopeImageList = new ImageList();
        private AppDbContext db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();
            InitializeImages();
            listView1.SmallImageList = horoscopeImageList;
            this.Load += new System.EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();

            var people = db.Persons.ToList();
            foreach (var person in people)
            {
                var horoscope = Horoscopes.GetHoroscope(person.BirthDate.Day, person.BirthDate.Month);
                var vki = CalculateVKI(person.Weight, person.Height);

                var item = new ListViewItem
                {
                    Text = $"{person.Name} {person.Surname}",
                    ImageKey = horoscope.ToString()
                };

                item.SubItems.Add($"{person.BirthDate.Day}/{person.BirthDate.Month}/{person.BirthDate.Year}");
                item.SubItems.Add($"{person.Height} cm / {person.Weight} kg");
                item.SubItems.Add($"{vki:F2}");
                item.SubItems.Add(GetVkiComment(vki));
                item.SubItems.Add(horoscope.ToString());
                item.SubItems.Add(Horoscopes.HoroscopeInterpretation(horoscope));
                listView1.Items.Add(item);
            }

        }

        private void InitializeImages()
        {
            horoscopeImageList.ImageSize = new Size(32, 32);

            foreach (Horoscope horoscope in Enum.GetValues(typeof(Horoscope)))
            {
                string filePath = $"Resources/{horoscope}.png";
                   horoscopeImageList.Images.Add(horoscope.ToString(), GetHoroscopeImage(horoscope));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Ad ve soyad girmeniz zorunludur.");
                return;
            }

            string heightStr = textBoxHeight.Text;
            string weightStr = textBoxWeight.Text;

            if (string.IsNullOrEmpty(heightStr) || string.IsNullOrEmpty(weightStr))
            {
                MessageBox.Show("Boy ve kilo girmeniz zorunludur.");
                return;
            }

            if (!double.TryParse(heightStr, out double height) || !double.TryParse(weightStr, out double weight))
            {
                MessageBox.Show("Geçerli bir boy ve kilo deðeri girin.");
                return;
            }

            DateTime birthDate = dateTimePicker1.Value;
            double vki = CalculateVKI(weight, height);
            Horoscope horoscope = Horoscopes.GetHoroscope(birthDate.Day, birthDate.Month);
            string vkiComment = GetVkiComment(vki);

            var item = new ListViewItem
            {
                Text = $"{name} {surname}",
                ImageKey = horoscope.ToString()
            };

            var person = new Person
            {
                Name = name,
                Surname = surname,
                BirthDate = birthDate,
                Height = height,
                Weight = weight,
            };

            db.Persons.Add(person);
            db.SaveChanges();


            item.SubItems.Add($"{birthDate.Day}/{birthDate.Month}/{birthDate.Year}");
            item.SubItems.Add($"{height} cm / {weight} kg");
            item.SubItems.Add($"{vki:F2}");
            item.SubItems.Add(vkiComment);
            item.SubItems.Add(horoscope.ToString());
            item.SubItems.Add(Horoscopes.HoroscopeInterpretation(horoscope));

            listView1.Items.Add(item);
        }

        public double CalculateVKI(double weight, double height)
        {
            height /= 100;
            return weight / (height * height);
        }

        public string GetVkiComment(double vki)
        {
            if (vki < 18.5) return "Zayýf";
            if (vki < 24.9) return "Normal";
            if (vki < 29.9) return "Fazla Kilolu";
            return "Obez";
        }

        private Image GetHoroscopeImage(Horoscope horoscope)
        {


            switch (horoscope)
            {
                case Horoscope.Koc:
                    return ByteArrayToImage(Resources.res.koc);
                case Horoscope.Boga:
                    return ByteArrayToImage(Resources.res.boga);
                case Horoscope.Ikizler:
                    return ByteArrayToImage(Resources.res.ikizler);
                case Horoscope.Yengec:
                    return ByteArrayToImage(Resources.res.yengec);
                case Horoscope.Aslan:
                    return ByteArrayToImage(Resources.res.aslan);
                case Horoscope.Basak:
                    return ByteArrayToImage(Resources.res.basak);
                case Horoscope.Terazi:
                    return ByteArrayToImage(Resources.res.terazi);
                case Horoscope.Akrep:
                    return ByteArrayToImage(Resources.res.Akrep);
                case Horoscope.Yay:
                    return ByteArrayToImage(Resources.res.yay);
                case Horoscope.Oglak:
                    return ByteArrayToImage(Resources.res.oglak);
                case Horoscope.Kova:
                    return ByteArrayToImage(Resources.res.kova);
                case Horoscope.Balik:
                    return ByteArrayToImage(Resources.res.balik);
                default:
                    return ByteArrayToImage(Resources.res.koc);
            }
        }

        private Image ByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

    }
}
