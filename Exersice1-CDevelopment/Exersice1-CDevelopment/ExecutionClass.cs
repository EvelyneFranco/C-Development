using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1_CDevelopment
{
    class ExecutionClass
    {
        static void Main(string[] args) {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();

            //Return type: String - Body: Comparison between 2 words - Parameters : 2 strings.
            Console.WriteLine(c1.comparation("igual","igual"));


            Console.WriteLine("----------------------------------------");
            //Return type: Bool - Body: Verify the biggest number in a list - Parameters: List/Array of integers.
            List<int> numeros = new List<int> { 33, 54, 85, 65, 34};
            Console.WriteLine(c1.biggestNumber(numeros));
            Console.WriteLine("----------------------------------------");
            //Return type: void - Body: Sort a list by asc and desc order - Parameters: List/Array of strings.
            List<string> lista = new List<string> { "hello", "computer", "mouse", "screen" };
            c1.printAscAndDesc(lista);
            Console.WriteLine("----------------------------------------");
            ///Return type: int - body: Count the length of a string - Parameters: String.
            Console.WriteLine(c1.lenghtCount("hola"));
            Console.WriteLine("----------------------------------------");


            //Return type: void - Body: Iterate trough a list and print the first 5 values - Parameters: List of integers (8 values)
            List<int> list8values = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            c2.printFirst5(list8values);
            Console.WriteLine("----------------------------------------");


            //Return type: void -Body: Iterate trough an Array and print the smallest number - Parameters: Array of integers.
            c2.smallest(numeros);
            Console.WriteLine("----------------------------------------");


            //Return type: void - Body: Iterate trough a Dictionary and print the value based on the Key - Parameters: None.
            c2.dictionary();
        }
    }
}
