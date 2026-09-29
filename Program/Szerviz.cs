using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek;

        public Szerviz()
        {
            jarmuvek = new List<Jarmu>();
        }

        public void JarmuFelvetele(Jarmu jarmu)
        {
            if (jarmu == null)
                throw new ArgumentNullException(nameof(jarmu));
            jarmuvek.Add(jarmu);
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                if (jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }
            }
        }

        public void InformaciokListazasa()
        {
            foreach (Jarmu jarmu in jarmuvek)
            {
                Console.WriteLine($"Rendszam: {jarmu.Rendszam}" + $"Kor: {jarmu.Kor}" + $"Kilometerora: {jarmu.KilometerOra}" + $"Uzemanyagszint: {jarmu.UzemanyagSzint}"
                );
            }
        }
    }
}
