using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        public string Rendszam { get;  set; }
        public int Kor { get; set; }
        public int KilometerOra { get; set; }
        public int UzemanyagSzint { get; set; }

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = string.IsNullOrWhiteSpace(rendszam) ? "ISMERETLEN" : rendszam; //? operator eldonti igaz / hamis docs bol

            Kor = Math.Max(0, kor);
            KilometerOra = Math.Max(0, kilometerOra);
            UzemanyagSzint = Math.Clamp(uzemanyagSzint, 0, 100); // docs bol van ketto ertek koze szorit egy szamot
        }

        public virtual bool SzervizSzukseges
        {
            get
            {
                return KilometerOra >= 200000;
            }
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            UzemanyagSzint -= 10;
        }

    }
}
