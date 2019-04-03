using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1_CDevelopment
{
    class Class1
    {

        //Return type: String - Body: Comparison between 2 words - Parameters : 2 strings.
        public string comparation(string word1, string word2) {
            try
            {
                if (word1.Equals(word2))
                {
                    return "words contains same text";
                }
                else {
                    string cadena = word1 +" "+ word2;
                    return cadena;
                }
            }
            catch (NullReferenceException e) {
                
                return e.Message;
            }
        }

        //Return type: Bool - Body: Verify the biggest number in a list - Parameters: List/Array of integers.
        //lo cambie a Int type para que el metodo me regrese el numero mas grande en lugar de un true o un false
        public int biggestNumber(List<int> numbers) {
            bool found;
            numbers.Sort();
            int biggest = numbers[numbers.Count -1];
            for(int i=0; i<numbers.Count - 1; i++) {
                if (biggest == numbers[i]) {
                    found = true;
                }
            }
            

            return biggest;

        }

        //Return type: void - Body: Sort a list by asc and desc order - Parameters: List/Array of strings.
        public void printAscAndDesc(List<string> lista) {
            lista.Sort();

            Console.WriteLine("Asc");
            for (int i=0;i<lista.Count;i++) {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("Desc");
            for (int i = lista.Count - 1; i >=0 ; i--)
            {
                Console.WriteLine(lista[i]);
            }

        }

        //Return type: int - body: Count the length of a string - Parameters: String.

        public int lenghtCount(string cadena) {
            int size = cadena.Length;
            char[] chars = new char[size];
            chars = cadena.ToCharArray();
            int cont = 0;
            for (int i = 0; i < size; i++) {
                cont++;
            }

            if (size == cont) {
                return size;
            }
            else {
                return 0;
            }
        }
      
    }
}
