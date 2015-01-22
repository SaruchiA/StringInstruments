using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    class Program
    {       

        static void Main(string[] args)
        {
            StringInstrument instrument1 = new StringInstrument();
            instrument1.color = "red";
            instrument1.name = "guitar";
            instrument1.numOfStrings = 5;

            instrument1.material = StringInstrument.Material.wood;

            instrument1.manufacturer.mName = "Gibbson";
            instrument1.manufacturer.mEmail = "gb@gmail.com";
            instrument1.manufacturer.mPhone = 9899509234;
            

            StringInstrument instrument2 = new StringInstrument();
            instrument2.color = "blue";
            instrument2.name = "banjo";
            instrument2.numOfStrings = 3;
            instrument2.material = StringInstrument.Material.Metal ;

            instrument2.manufacturer.mName = "abc";
            instrument2.manufacturer.mEmail = "abc@yahoo.co.in";
            instrument2.manufacturer.mPhone = 7899509670;

            StringInstrument.printInfo(instrument1 );
            StringInstrument.printInfo(instrument2);
            Console.ReadKey();
        }
    }
}
