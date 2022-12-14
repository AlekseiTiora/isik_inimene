using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isik_inimene
{
    internal class Opilane : Isik
    {
        public Opilane(string nimi, int synniAasta, sugu Sugu, string kooliNimi, string klass, string specialization) : base(nimi, synniAasta, Sugu, kooliNimi, klass, specialization) { }

        public Opilane(Opilane student)
        {
            this.nimi = student.nimi;
            this.synniAasta = student.synniAasta;
            this.Sugu = student.Sugu;
            this.kooliNimi = student.kooliNimi;
            this.klass = student.klass;
            this.specialization = student.specialization;
        }
        public override void print_Haal()
        {
            throw new NotImplementedException();
        }

        public override void print_Info()
        {
            Console.WriteLine($"\nÕpilane:\n  \nNimi: {nimi} Vanus: {arvutaVanus()} \nSugu: {Sugu}\nKooli nimi: {kooliNimi} \nKlass: {klass} \nSpetsialiseerumine: {specialization}");
        }

        public void muudaKooli(string newKooli)
        {
            this.kooliNimi = newKooli;
        }
        public void muudaSugu(sugu uusSugu)
        {
            Sugu = uusSugu;
        }


        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }

        public void muudaAasta(int uusAasta) { synniAasta = uusAasta; }


    }
}