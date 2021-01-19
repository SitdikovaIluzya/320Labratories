using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gankina.praktika_3
{
    class Threading
    {
        int[] array1;
        int[] array2;
        public int[] Array1 { get => array1; set => array1 = value; }
        public int[] Array2 { get => array2; set => array2 = value; }

        public Threading2(int[] array1, int[] array2)
        {
            this.Array1 = array1;
            this.Array2 = array1;
        }

        public void Generator()
        {
            Random rnd = new Random();

        }

    }
}
