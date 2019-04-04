using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2_DevelopmentC
{
    class Program
    {

        string variableInConstructor;
        private string palindromeWord;

        //constructor overloading
        public Program() {
            //Initialize the variable with the constructor
            variableInConstructor = "this variable is initialize in constructor";
        }

        //constructor overloading
        public Program(String message) {
            Console.WriteLine(message);
        }
        //method overloading


        public void printNumbers() {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = i;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        //method overloading
        public void printNumbers(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //set method
        public void setPalindrome() {
            this.palindromeWord= "ankYkna";
        }
        //get method
        public string getPalindome() {
            return this.palindromeWord;
        }

        //Create a method to verify if a string is a palindrome
        public string CheckForPalindrome() {

            string revert;
            char[] revertWord = palindromeWord.ToCharArray();
            Array.Reverse(revertWord);
            revert = new string(revertWord);

            if (palindromeWord.Equals(revert, StringComparison.OrdinalIgnoreCase))
            {
                return "is a Palindrome";
            }
            else {
                return " is not a Palindrome";
            }

        }

        //reate a method to print numbers in diagonal.

        public void DiagonalPrint(int limit) {
            StringBuilder espace = new StringBuilder();
            for (int i = 0; i <= limit; i++) {

                Console.WriteLine(espace +""+ i);
                espace.Append(" ");
                
            }
        }
        static void Main(string[] args)
        {
            
        Program p = new Program();


            //print constructor variable
            Console.WriteLine("-------------Constructor overloading------------");
            Console.WriteLine(p.variableInConstructor);
            Program p2 = new Program("message from Constructor overloading");


            Console.WriteLine("-------------Method overloading------------");
            //Method overloading
            Console.WriteLine("Method1");
            p.printNumbers();
            int[] numbers = { 7, 8, 9, 10, 11 };
            Console.WriteLine("Method2");
            p.printNumbers(numbers);

            Console.WriteLine("-------------palindrome------------");
            //set palindrome 
            p.setPalindrome();
            //check palindrome
            Console.WriteLine(p.CheckForPalindrome());


            Console.WriteLine("-------------Print Diagonal------------");
            //print diagonal
            p.DiagonalPrint(10);


        }
    }
}
