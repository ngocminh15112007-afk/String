using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Lamlai
    {
       
        //  -to input a string and print it.
        public static string Taochuoi()
        {
            Console.Write("Nhap mot dong chu: ");
            string input = Console.ReadLine();
            Console.WriteLine("Chuoi la " + input);
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
            Console.Write("Do dai cua chuoi la " + count);
            string[] mangtu = arr.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string c in mangtu)
            {
                if (c.All(char.IsLetter))
                    countchu++;
            }
            Console.Write($"Chuoi co {countchu} chu ");
            string[] mangtu2 = arr.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in mangtu2)
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
            for (int i = 0; i < arr.Length; i++)
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
                    Console.Write(chuoidao[i] + " ");
            }
            return chuoidao;
        }
        //-to count the total number of words in a string.
        public static int Demchu(string arr)
        {
            string[] tachchuoi = arr.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < tachchuoi.Length; i++)
            {
                if (tachchuoi[i].All(char.IsLetter))
                { count++; }
            }
            Console.WriteLine($"Chuoi co {count} chu");
            return count;
        }
        //-to compare two strings without using a string library functions.
        static bool Compare(string[] arr, string[] arr2)
        {
            bool chungdodai = false;
            bool chungkitu = true;

            if (arr.Length == arr2.Length)
            {
                chungdodai = true;
                for (int i = 0; i < Math.Min(arr.Length, arr2.Length); i++)
                {
                    if (arr[i] != arr2[i])
                    {
                        chungkitu = false;
                        break;
                    }
                }
            }
            else { Console.WriteLine("Hai chuoi khac nhau"); }
            if (chungkitu) Console.WriteLine("Hai chuoi giong nhau");
            else Console.WriteLine("Chi chung do dai");
            return chungkitu;
        }

        //-to count the number of alphabets, digits and special characters in a string.
        static (int alpha, int digit, int special) Demkitu(string arr)
        {
            int alpha = 0;
            int digit = 0;
            int special = 0;
            foreach (char a in arr)
            {
                if (char.IsLetter(a)) alpha++;
                else if (char.IsDigit(a)) digit++;
                else if (!char.IsWhiteSpace(a)) special++;
            }
            return (alpha, digit, special);
        }


        //-to count the number of vowels or consonants in a string.
        static (int vowels, int consonants) Demnguyenam(string arr)
        {
            int vowels = 0;
            int consonants = 0;
            string nguyenam = "ueoaiUEOAI";
            foreach (char c in arr)
            {
                if (nguyenam.Contains(c)) { vowels++; }
                else if (char.IsLetter(c)) { consonants++; }
            }
            Console.WriteLine($"So luong nguyen am la {vowels}, phuam la {consonants}");
            return (vowels, consonants);
        }
        //-to check whether a given substring is present in the given string.
        static bool Xuathien(string[] arr, string substring)
        {
            bool xuathien = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == substring)
                {
                    xuathien = true;
                    Console.WriteLine("Co xuat hien");
                    break;
                }
                else Console.WriteLine("Khong co chuoi can tim");
            }
            return xuathien;
            //-to search for the position of a substring within a string.

            static int Vitri(string arr, string substring)
            {
                int pos = -1;
                int count = 0;
                string ketqua = "";
                
                do
                {
                    pos = arr.IndexOf(substring, pos + 1);
                    if (pos != -1)
                    {
                        ketqua += pos+1 + " ";
                        count++;
                    }
                }
                while (pos != -1);
                return pos;
            }

            //dem vi tri chu
            static (string vitri, int count) Demchu(string arr, string substring)
            {
                string vitri = "";
                int count = 0;
                string[] arr2 = arr.Split(new char[] { ' ', ',', '.', ';', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);
                Console.Write("Chu xuat hien tai vi tri: ");
                for (int i=0; i<arr2.Length; i++)
                {
                    if (arr2[i].ToLower() == substring.ToLower())
                    {
                       vitri += i+1 + " ";
                        count++;
                    }
                }
                Console.WriteLine($"{substring} xuat hien tai {vitri} {count} lan");
                Console.WriteLine();
                return (vitri, count);
            }
            //-to check whether a character is an alphabet and not and if so, check for the case.
            static (bool chucai, bool chuhoa) Chu(char c)
            {
                bool chucai = false;
                bool chuhoa = false;
                if (char.IsLetter(c))
                {
                    chucai = true;
                    if (char.IsUpper(c)) ;
                    chuhoa = true;
                }
                return (chucai,chuhoa);
            }
            
            //to insert a substring before the first occurrence of a string.
            static string Chenchu(string arr,string substring)
            {
                Console.WriteLine("Muon chen chu gi: ");
                string chuchen = Console.ReadLine();
                Console.WriteLine("Muon chen truoc chu: ");
                string chomoc = Console.ReadLine();
                string ketqua = "";
                int vitri = arr.IndexOf(chomoc);
                while (vitri!=-1)
                {
                    ketqua = arr.Insert(vitri, chuchen);         
                    int buocnhay = vitri + chuchen.Length + chomoc.Length;
                    vitri = arr.IndexOf(chomoc, buocnhay);
                }
                return ketqua;

            }

        }
    }
}
