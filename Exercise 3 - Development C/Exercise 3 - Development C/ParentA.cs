using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Development_C
{
    class ParentA
    {
        public void comparesLenghtString(string word1, string word2) {
            try
            {
                if (word1.Length == word2.Length)
                {
                    Console.WriteLine("Words lenght is the same");
                }
                else {
                    Console.WriteLine("Words Lenht is different");
                }
            }
            catch (NullReferenceException e) {
                Console.WriteLine(e.Message);
            }
        }//method compare string

        public void compareLengthList(List<int> list1, List<string> list2)
        {
            
            try {
                if (list1.Count() == list2.Count())
                { //to acces to size list is with count...size is not displayed in menu options, addin size shows an error
                    Console.WriteLine("list size is the same");
                }
                else {
                    Console.WriteLine("List size is different");
                }
            }
            catch (NullReferenceException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
