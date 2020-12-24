using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_2020_01_test1_3A713135
{
    class gacya
    {
        int result = 0;
        Random card = new Random();
        public int Gacya(int gacya)
        {
            if (gacya > 0 && gacya < 4)
            {
                if (gacya == 1)
                {
                    result = 3;
                }
                else if (gacya == 2)
                {
                    result = 7;
                }
                else 
                {
                    result = 11;
                }
            }
            else if (gacya > 3 && gacya < 22)
            {
                if (gacya > 3 && gacya < 10)
                {
                    result = 2;
                }
                else if (gacya > 9 && gacya < 16)
                {
                    result = 6;
                }
                else
                {
                    result = 10;
                }
            }
            else if (gacya > 21 && gacya < 52)
            {
                if (gacya > 21 && gacya < 32)
                {
                    result = 1;
                }
                else if (gacya > 31 && gacya < 42)
                {
                    result = 5;
                }
                else
                {
                    result = 9;
                }
            }
            else
            {
                if (gacya > 51 && gacya < 67)
                {
                    result = 0;
                }
                else if (gacya > 66 && gacya < 82)
                {
                    result = 4;
                }
                else
                {
                    result = 8;
                }
            }
            return result;
        }
    }
}
