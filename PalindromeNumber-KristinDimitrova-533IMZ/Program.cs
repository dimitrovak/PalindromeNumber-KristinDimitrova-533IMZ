using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber_KristinDimitrova_533IMZ
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());
            string num = n.ToString();
            string reversedNum = reverseNum(num);
            int sumNum = sumOfNums(num,reversedNum);
            string sum = sumOfNums(num, reversedNum).ToString();
            string reversedSum = reverseNum(sum);
            
            int result = n;

            while(result<1000000)
            {
                result = play(result);
                if (IsPalindrome(result.ToString()))
                {
                    Console.WriteLine(n + " is not special. It can produce a palindrome.");
                    break;
                }
                else
                {
                    Console.WriteLine(n + " is special. It cannot produce a palindrome.");
                    break;
                }
            }
            
       

        }
        static int play(int number)
        {
            string numberToString = number.ToString();
            string reversedNumber = reverseNum(numberToString);
            int summed = sumOfNums(numberToString, reversedNumber);
            return summed;
            
        }
        static int sumOfNums(string num,string reverseNum)
        {
            int parsedNum = Int32.Parse(num);
            int parsedReversedNum = Int32.Parse(reverseNum);
            return parsedNum + parsedReversedNum;
        }
        static string reverseNum(string num)
        {
            string reverseNum = "";
            int length = num.Length - 1;
            while (length >= 0)
            {
                reverseNum = reverseNum + num[length];
                length--;
            }
            return reverseNum;
        }

        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        
    }
    }

