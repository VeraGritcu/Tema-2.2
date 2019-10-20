using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement an algorithm to determine if a string has all unique characters.
            //int[] array = new int[] { 12, 6, 32, 0, 8, 66, 10, 12 };
            //CheckDuplicates(array);
            /*----------------------------------------------------------------------------*/
            //Write code to remove duplicates from an unsorted linked list.
            //RemoveNodeFromLinkedList();
            /*----------------------------------------------------------------------------*/
            //Check if a word is a palindrome
            //PalindromCheck1();
            //PalindromCheck2();
            //PalinddromCheck3();
            /*-----------------------------------------------------------------------------*/
            //Given a string s consists of upper/lower-case alphabets and empty space characters ' ', 
            //return the length of last word in the string. If the last word does not exist, return 0.

            LastWordLengh();
            Console.ReadKey();


        }

        private static void LastWordLengh()
        {
            Console.WriteLine("Write a sentence!");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            Console.Write((words[words.Length - 1]).Length);
        }

        private static void PalinddromCheck3()
        {
            Console.WriteLine("Write a word");
            string input = Console.ReadLine();
            string reversed = string.Join("", input.Reverse());
            if (input == reversed)
            {
                Console.WriteLine("This is a palindrom");
            }
            else
            {
                Console.WriteLine("This is not a palindrom");
            }
        }

        private static void PalindromCheck2()
        {
            Console.WriteLine("Write a word");
            string word = Console.ReadLine();
            string[] wordArray = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                wordArray[i] = word[i].ToString();
            }

            int matches = 0;

            for (int j = wordArray.Length - 1, i = 0; (wordArray.Length / 2) <= j && j <= wordArray.Length - 1; j--, i++)
            {

                if (wordArray[i] == wordArray[j] && i != j)
                {
                    matches++;
                }
            }

            if (matches == wordArray.Length / 2)
            {
                Console.WriteLine("This is a palindrom");
            }
            else
            {
                Console.WriteLine("This is not a palindrom");
            }
        }

        private static void PalindromCheck1()
        {
            Console.WriteLine("Write a word");
            string word = Console.ReadLine();
            string[] wordArray = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                wordArray[i] = word[i].ToString();
            }

            int matches = 0;
            for (int i = 0; (wordArray.Length / 2) >= i && i >= 0; i++)
            {
                if (matches == wordArray.Length)
                {
                    break;
                }
                for (int j = wordArray.Length - 1; (wordArray.Length / 2) <= j && j <= wordArray.Length - 1; j--)
                {
                    if (wordArray[i] == wordArray[j] && i != j)
                    {
                        matches++;
                        i = i + 1;
                    }
                }
            }
            if (matches == wordArray.Length / 2)
            {
                Console.WriteLine("This is a palindrom");
            }
            else
            {
                Console.WriteLine("This is not a palindrom");
            }
        }

        private static void RemoveNodeFromLinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(10);
            LinkedListNode<int> node2 = new LinkedListNode<int>(40);
            LinkedListNode<int> node3 = new LinkedListNode<int>(20);
            LinkedListNode<int> node4 = new LinkedListNode<int>(30);
            lista.AddFirst(node1);
            lista.AddAfter(node1, node2);
            lista.AddAfter(node2, node3);
            lista.AddLast(node4);

            lista.Remove(20);
            foreach (var item in lista)
            {
                Console.Write($"{item}, ");
            }
        }

        private static void CheckDuplicates(int[] array)
        {
            bool uniqness = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (uniqness == false)
                {
                    break;
                }
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        uniqness = false;
                        break;
                    }

                }

            }
            if (uniqness == true)
            {
                Console.WriteLine("Your array contains no dulicates");
            }
            else
            {
                Console.WriteLine("Your array contains duplicates");
            }
        }
    }
}
