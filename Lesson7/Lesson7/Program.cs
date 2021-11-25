using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
           ACoder str = new();
           Console.WriteLine ($"шифрование с помощью класса ACoder { str.Encode("абв")}");
           Console.WriteLine($"дешифрование с помощью класса ACoder {str.Decod(str.Encode("абв"))}");
           BCoder str1 = new ();
           Console.WriteLine($"шифрование с помощью класса BCoder {str1.Encode("абвг")}");
           Console.WriteLine($"дешифрование с помощью класса BCoder {str1.Decod(str1.Encode("абвг"))}"); 
        }
    }
}
//1