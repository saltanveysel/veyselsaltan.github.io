using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    class Kontrol
    {
        public bool TrimKontrol(string txt1,string txt2)
        {
            if (txt1.Trim() != "" && txt2.Trim() != "")
            {
                return true;
            }
            return false;
        }
    }
}
