using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isik_inimene
{
    abstract class Isik
    {
        protected string nimi;
        protected int synniAasta;
        protected char sugu;

        
        public Isik(char sugu = 'x',string nimi="---",int synniAasta = 0)
        { this.nimi = nimi; this.synniAasta = synniAasta; this.sugu = sugu;}
        public Isik(Isik ob)
        { this.nimi = ob.nimi; this.synniAasta = ob.synniAasta; this.sugu = ob.sugu; }
        public virtual void print()
        {
            Console.WriteLine("{0,-10} {1} {2,4}", nimi, sugu, synniAasta);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            return vanus;
        }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);
    }
}
