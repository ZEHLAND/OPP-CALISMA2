using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp20
{
    class Araba:ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;
        public int YIl
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
        public string MARKASI
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
