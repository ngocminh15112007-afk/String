using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Lamlai
    {
        static void Main(string[] args)
        {
            string input = Taochuoi();
            Dodai(input);
            
            string[] ketqua = Tachchuoi(input);
            Tachchuoidao(ketqua);
        }
        //  -to input a string and print it.
        public static string Taochuoi()
        {
            Console.Write("Nhap mot dong chu: ");
            string input = Console.ReadLine();
            Console.WriteLine("Chuoi la "+input);
            return input;
        }
  
         //-to find the length of a string without using a library function.
        public static (int count, int countchu, int countkokhoang) Dodai(string arr)
        {
            int count = 0;
            int countchu = 0;
            int countkokhoang = 0;
            //do dai chu + ki tu
            count = arr.Length;
            Console.Write("Do dai cua chuoi la "+count);
            string[] mangtu = arr.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string c in mangtu)
            {
               
                countchu++;
            }
            Console.Write($"Chuoi co {countchu} chu ");
            string[] mangtu2 = arr.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            foreach(string i in mangtu2)
            {
                countkokhoang++;
            }
            Console.Write($"Chuoi co {countkokhoang} chu ");
            return (count, countchu, countkokhoang);

        }
//-to separate individual characters from a string.
public static string[] Tachchuoi(string arr)
        {
            string[] ketqua = new string[arr.Length];
            Console.WriteLine("Chuoi tach la: ");
            for (int i =0;i<arr.Length;i++)
            {
                ketqua[i] = arr[i].ToString(); 
                if (ketqua[i] != " ")
                {
                    Console.Write(ketqua[i] + " ");
                }
            }
           
            return ketqua;
        }
        //-to print individual characters of the string in reverse order.
        public static string[] Tachchuoidao(string[] arr)
        {
            string[] chuoidao = new string[arr.Length];
            Console.WriteLine("Chuoi dao tach la:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                chuoidao[i] = arr[i];
                if (chuoidao[i] != " ")
                    Console.Write(chuoidao[i] +" ");
            }
            return chuoidao;
        }
//-to count the total number of words in a string.
//-to compare two strings without using a string library functions.
//-to count the number of alphabets, digits and special characters in a string.
//-to count the number of vowels or consonants in a string.
//-to check whether a given substring is present in the given string.
//-to search for the position of a substring within a string.
//-to check whether a character is an alphabet and not and if so, check for the case.
//-to find the number of times a substring appears in a given string.
//to insert a substring before the first occurrence of a string.

    }
}
