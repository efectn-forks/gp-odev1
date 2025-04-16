using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Horoscope
{
    Koc,
    Boga,
    Ikizler,
    Yengec,
    Aslan,
    Basak,
    Terazi,
    Akrep,
    Yay,
    Oglak,
    Kova,
    Balik,
    Bilinmiyor
}

namespace WinFormsApp3
{
    class Horoscopes
    {
        public static Horoscope GetHoroscope(int day, int month)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return Horoscope.Koc;
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return Horoscope.Boga;
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 21))
                return Horoscope.Ikizler;
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                return Horoscope.Yengec;
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return Horoscope.Aslan;
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return Horoscope.Basak;
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 23))
                return Horoscope.Terazi;
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 21))
                return Horoscope.Akrep;
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return Horoscope.Yay;
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return Horoscope.Oglak;
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return Horoscope.Kova;
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return Horoscope.Balik;

            return Horoscope.Bilinmiyor;
        }

        public static string HoroscopeInterpretation(Horoscope horoscope)
        {
            switch (horoscope)
            {
                case Horoscope.Koc:
                    return "Lider ruhlusun ve cesursun.";
                case Horoscope.Boga:
                    return "Sabırlı ve kararlısın.";
                case Horoscope.Ikizler:
                    return "Zeki ve iletişim yeteneğin yüksek.";
                case Horoscope.Yengec:
                    return "Duygusal ve koruyucusun.";
                case Horoscope.Aslan:
                    return "Kendine güvenen ve lider ruhlusun.";
                case Horoscope.Basak:
                    return "Titiz ve analiz yeteneğin kuvvetli.";
                case Horoscope.Terazi:
                    return "Adaletli ve dengelisin.";
                case Horoscope.Akrep:
                    return "Tutkulu ve sezgilerin kuvvetli.";
                case Horoscope.Yay:
                    return "Macera sever ve özgür ruhlusun.";
                case Horoscope.Oglak:
                    return "Disiplinli ve çalışkansın.";
                case Horoscope.Kova:
                    return "Yenilikçi ve özgünsün.";
                case Horoscope.Balik:
                    return "Hayalperest ve sezgisel gücün yüksek.";
                default:
                    return "Burç yorumuna ulaşılamadı.";
            }
        }


    }
}
