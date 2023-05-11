using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace biraria
{
    internal class biraria
    {
        private string bira;
        private double cena;
        private int kolichestvo;
        private int id;
        private int dushi;
        

        public string Bira
        {
            get { return bira; }
            set { bira = value; }
        }
        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public int Kolichestvo
        {
            get { return kolichestvo; } 
            set {  kolichestvo = value; } 
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Dushi
        {
            get { return dushi; }
            set { dushi = value; }
        }
      public string izhod()
        {
            return $"избраната поръчка е:";
            return $"клиентски номер:{id}";
            return $"избрал бира:{bira}";
            return $"бройки:{kolichestvo}";
            return $"ед.цена:{cena}";
        }
          
    }
}
