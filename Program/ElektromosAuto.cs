using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        public int AkkumulatorSzint { get; set; }

        public override bool SzervizSzukseges
        {
            get
            {
                return KilometerOra >= 200000;
            }
        }

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            AkkumulatorSzint = Math.Clamp(akkumulatorSzint, 0, 100);
            UzemanyagSzint = 0;
        }

        public override void Szervizel(int dij)
        {

            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            AkkumulatorSzint = Math.Clamp(AkkumulatorSzint + 20, 0, 100);
            UzemanyagSzint = 0;
        }

    }
}
