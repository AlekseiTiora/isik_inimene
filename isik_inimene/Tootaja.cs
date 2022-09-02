using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isik_inimene
{
    internal class Tootaja
    {
        protected string nimi;
        protected int synniAasta;
        protected char sugu;

        public Tootaja(char sugu = 'x', string nimi = "---", int synniAasta = 0)
        { this.nimi = nimi; this.synniAasta = synniAasta; this.sugu = sugu; }
        public Tootaja(Isik ob)
        { this.nimi = ob.nimi; this.synniAasta = ob.synniAasta; this.sugu = ob.sugu; }
    }
}
