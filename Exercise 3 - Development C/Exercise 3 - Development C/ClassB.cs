using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Development_C
{
    class ClassB : ParentA, interfaceClass 
    {
        
        static void Main(string[] args)
        {
            ParentA pa = new ParentA();
            ClassB cb = new ClassB();
            //use method compare strings from ParentA
            Console.WriteLine("when words lenght is the same: ....");
            pa.comparesLenghtString("thesame", "thesame");
            Console.WriteLine("when words lenght is different: .....");
            pa.comparesLenghtString("thesame", "not");
            Console.WriteLine("---------------------------------");

            //use method  compare lists from parentA
            Console.WriteLine("Compare list size");

            List<int> numeros = new List<int> { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            List<string> values = new List<string> { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " ", "Test" };
            pa.compareLengthList(numeros, values);
            Console.WriteLine("---------------------------------");

            //method form int
            cb.print();
            Console.WriteLine("---------------------------------");

            //pint list in asc/desc

            Console.WriteLine("--------asc-------");
            cb.ascDesc("asc", values);
            Console.WriteLine("--------desc-------");
            cb.ascDesc("desc", values);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------print list without space------");
            //print list without space element
            cb.skipSpace(values);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------Delete duplicates------");
            cb.removeDuplicates(numeros);
            Console.WriteLine("---------------------------------");
        }

        public void skipSpace(List<string> list)
        {

            IEnumerable<string> space = from a in list
                                        where  a != " "
                                        select a;
            foreach (var result in space) {
                Console.WriteLine(result);
            }
        }

        public void removeDuplicates(List<int> list) {
            List<int> duplicates = list.Distinct().ToList();

            foreach (var dup in duplicates) {
                Console.WriteLine(dup);
            }


        }

        public void print()
        {
            Console.WriteLine("Hello Interface");
        }

        public void ascDesc(string order, List<string> list) {
            list.Sort();

            if (order.Equals("asc"))
            {
                foreach (string value in list)
                {
                    Console.WriteLine(value);
                }
            }
            else if (order.Equals("desc"))
            {
                list.Reverse();
                foreach (string value in list)
                {
                    Console.WriteLine(value);
                }
            }
                
            
        }
    }
}
