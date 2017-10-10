using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_プロパティ
{
    class Aroma
    {
        public double drop;
        public double itteki
        {
            get { return drop; }
            set
            {
                drop = value;
            }
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Aroma aroma = new Aroma();
            aroma.itteki = 0.05;
            Console.WriteLine("一滴あたり" + aroma.itteki + "mlです。");
        }
    }
}
