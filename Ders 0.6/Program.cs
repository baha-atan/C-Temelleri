using System;
using System.Collections.Generic;

namespace Ders_0._6
{
    class Program
    {
        //Koleksiyonlar 
        static void Main(string[] args)
        {
            list<string> isimler2 = new list<string> { "engin", "kerem", "murat", "halil" };
            console.writeline(isimler2[0]);
            console.writeline(isimler2[1]);
            console.writeline(isimler2[2]);
            console.writeline(isimler2[3]);
            isimler2.add("ilker");
            console.writeline(isimler2[4]);
            console.writeline(isimler2[0]);

        }
    }
}
