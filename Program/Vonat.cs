using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Vonat : Jarmu
    {
        int vagonokSzama;

        public Vonat(
            string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany)
            : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            VagonokSzama = vagonokSzama;
        }

        public int VagonokSzama
        {
            get { return vagonokSzama; }
            set
            {
                if (value < 0)
                {
                    vagonokSzama = 0;
                }
                else if (value > 100)
                {
                    vagonokSzama = 100;
                }
                else
                {
                    vagonokSzama = value;
                }
            }

            
        }

        

        public override void Szervizel(int dij)
        {
            
            base.Szervizel(dij);
        }

        public virtual void VagonokSzamaCsokkentese(int csokkentes)
        {
            if (csokkentes < 0)
            {
                throw new ArgumentException("A csökkentés nem lehet negatív.");
            }
            VagonokSzama = Math.Max(0, VagonokSzama - csokkentes);
        }

    }
}
