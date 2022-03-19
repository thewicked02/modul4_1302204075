using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_1302204075
{
    public class penjumlahan<T>
    {
        private T data;
        public static Double JumlahTigaAngka(T a1, T a2, T a3)
        {
            Double A1 = Convert.ToDouble(a1);
            Double A2 = Convert.ToDouble(a2);
            Double A3 = Convert.ToDouble(a3);

            Double hasil = A1 + A2 + A3;

            return hasil;
        }
    }
}