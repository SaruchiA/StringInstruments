using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    class StringInstrument
    {
        #region data members
       public enum Material
        {
            wood,
            Plastic,
            Metal
        };
        public String name { get; set; }
        public int numOfStrings;
        public String color;
        public Material material { get; set; }
        public char[] strings = { 'E', 'A', 'D', 'G' };
        public Manufacturer manufacturer = new Manufacturer();
         #endregion

        #region member functions
        public char[] play(char[] strings)
        {
            return strings;
        }
        public char[] stopPlay(char[] strings)
        {
            return strings;
        }

        public static void printInfo(StringInstrument i)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Name:"+ i.name );
            Console.WriteLine("Color:" + i. color );
            Console.WriteLine("Number of strings:" + i. numOfStrings );
            Console.WriteLine("Material:" + i. material );
            Console.WriteLine("Manufacturer Name:" + i. manufacturer .mName );
            Console.WriteLine("Manufacturer Phone:" + i. manufacturer.mPhone );
            Console.WriteLine("Manufacturer Email:" + i. manufacturer.mEmail );

        }
        #endregion

    }
}
