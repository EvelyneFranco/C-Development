using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1_CDevelopment
{
    class Class2
    {
        //Return type: void - Body: Iterate trough a list and print the first 5 values - Parameters: List of integers (8 values)

        public void printFirst5(List<int> numbers) {
            List<int> get5 = numbers.GetRange(0, 5);
            for (int i=0;i<get5.Count;i++) {
                Console.WriteLine(get5[i]);
            }

            
        }

        //Return type: void - Body: Iterate trough an Array and print the smallest number - Parameters: Array of integers.
        public void smallest(List<int> numbers) {
            numbers.Sort();
            int small = numbers[0];
            bool found= false;
            
            for (int i=0; i<numbers.Count;i++) {
                if (small < numbers[i]) {
                    found = true;
                }
            }
            if (found.Equals(true)) {
                Console.WriteLine("smallest number is: {0}", small);
            }
        }

        //Return type: void - Body: Iterate trough a Dictionary and print the value based on the Key - Parameters: None.
        public void dictionary() {
            var dic = new Dictionary<int, string>();
            dic.Add(1, "Chichen itza");
            dic.Add(2,"Coliseo de roma");
            dic.Add(3, "Cristo redentor");
            dic.Add(4,"Muralla china");
            dic.Add(5,"Machu picchu");
            dic.Add(6, "Petra");
            dic.Add(7, "Taj Mahal");

            Console.WriteLine("las 7 maravillas son:");
            for (int i = 1; i <=dic.Count; i++) {
                Console.WriteLine(dic[i]);
            }
  

        }


    }
}
