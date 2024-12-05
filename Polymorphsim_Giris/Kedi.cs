using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim_Giris
{
    public class Kedi : Hayvan
    {
        public Kedi(string isim) : base(isim)
        {

        }

        public override void konus()
        {
            Console.WriteLine(getIsim() + " miyavlıyor..");
        }
    }
}
