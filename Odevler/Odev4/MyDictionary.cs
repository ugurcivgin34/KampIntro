using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    class MyDictionary<t1, t2>
    {
        t1[] dizi1;
        t2[] dizi2;

        t1[] dizi1_yedek;
        t2[] dizi2_yedek;

        public MyDictionary()
        {
            dizi1 = new t1[0];
            dizi2 = new t2[0];

        }

        public void Add(t1 item1, t2 item2)
        {
            dizi1_yedek = dizi1;
            dizi2_yedek = dizi2;

            dizi1 = new t1[dizi1.Length + 1];
            dizi2 = new t2[dizi2.Length + 1];

            for (int i = 0; i < dizi1_yedek.Length; i++)
            {
                dizi1[i] = dizi1_yedek[i];
            }

            for (int i = 0; i < dizi2_yedek.Length; i++)
            {
                dizi2[i] = dizi2_yedek[i];
            }

            dizi1[dizi1.Length - 1] = item1;
            dizi2[dizi2.Length - 1] = item2;
        }


        public int Count
        {
            get { return dizi1.Length; }
        }

        public t2[] Values
        {
            get { return dizi2; }
        }

        public t1[] Keys
        {
            get { return dizi1; }
        }

    }
}
