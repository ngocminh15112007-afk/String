namespace ConsoleApp1
{
    internal class Baitapfile
    {
        static void Main(string[] args)
        {
            string input = Input_Print();
            daochuoi(input);
        }
        //bai1
        static string Input_Print()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Chuoi vua nhap la: {input}");
            return input;
        }
        //bai2
        static void demchuoi(string arr)
        {
            int count = 0;
            foreach (char c in arr)
                if (char.IsLetterOrDigit(c))
                {
                    count++;
                }
            Console.WriteLine($"Do dai cua chuoi la: {count}");
        }
        //bai3
        static void tachchuoi(string arr)
        {
            foreach (char c in arr)
            {
                if (c != ' ')
                {
                    Console.Write(c + " ");
                }
            }
        }
        //bai4
        static void daochuoi(string arr)
        {
            char[] chuoidao = new char[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                chuoidao[j] = arr[i];
                j++;
            }
            string ketquaDao = new string(chuoidao);
            Console.Write(ketquaDao);
            Console.WriteLine("Tach chuoi dao: ");
            tachchuoi(ketquaDao);
        }

        //bai5
        static void demtu(string arr)
        {
            bool dadem = true;
            string vachngan = " /t/n'.;:?!,";
            int count = 0;
            if (!string.IsNullOrEmpty(arr))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    char c = arr[i];
                    if (vachngan.Contains(c))
                    {
                        dadem = false;
                    }
                    else
                    {
                        if (dadem == false); //kiểm tra xem đã đếm trước đó hay chưa 
                        {
                            count++;
                            dadem = true;
                        }
                    }
                }

            }
        }

    }
}
