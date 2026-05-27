using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Baitapfile
    {
        static void Main(string[] args)
        {
            string input = Input_Print();
            Chenchu(input);
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
        static int demchuoi(string arr)
        {
            int count = 0;
            foreach (char c in arr)
                if (char.IsLetterOrDigit(c))
                {
                    count++;
                }
            Console.WriteLine($"Do dai cua chuoi la: {count}");
            return count;
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
                        if (dadem == false) ; //kiểm tra xem đã đếm trước đó hay chưa 
                        {
                            count++;
                            dadem = true;
                        }
                    }
                }
                Console.WriteLine($"So luong chu la: {count}");

            }
        }
        //bai 6

        static void sosanhchuoi(string arr, string arr2)
        {
            bool dodai = false;
            bool kitu = false;
           
            if (arr.Length == arr2.Length)
            {
                dodai = true;
                for (int i = 0; i < Math.Min(arr.Length, arr2.Length); i++)
                {
                    if (arr[i] != arr2[i])
                    {
                        kitu = false;
                        break;
                    }
                    else kitu = true;
                }

            }
            else { dodai = false; kitu = false; }
            if (dodai && !kitu) { Console.WriteLine("Co chung do dai"); }
            if (!dodai) { Console.WriteLine("Khac do dai"); }

            if (dodai && kitu) { Console.WriteLine("Chuoi giong"); }
            
        }
        //-to count the number of alphabets, digits and special characters in a string.
        static (int alpha, int digit, int special) Count(string arr)
        {
            int alpha = 0; int digit = 0; int special = 0;
            foreach (char c in arr)
            {
                if (char.IsLetter(c)) alpha++;
                if (char.IsDigit(c)) digit++;
                else special++;
            }
            Console.WriteLine($"So luong chu la: {alpha}, so luong digit la {digit}, so luong khac {special}");
            return (alpha, digit, special);
        }
        //so sanh chu so
        static void Sosanh(string arr, string arr2)
        {
            if (Count(arr).alpha > Count(arr2).alpha)
            {
                Console.WriteLine("So chu cai cua day 1 hon day 2");
            }
            else Console.WriteLine("So chu cai day 2 hon day 1");

        }
        //bai8
        static (int nguyenam, int phuam) Demnguyen(string arr)
        {
            int nguyenam = 0;
            int phuam = 0;
            string chuoinguyenam = "ueoaiUEOAI";
            if (!string.IsNullOrEmpty(arr))
            {
                foreach (char c in arr)
                {
                    if (char.IsLetter(c))
                    {
                        if (chuoinguyenam.Contains(c)) { nguyenam++; }
                        else phuam++;
                    }

                }
                Console.WriteLine($"So nguyen am la: {nguyenam}, phu am la {phuam}");

            }
            else Console.WriteLine("La chuoi rong");
                return (nguyenam, phuam);
            }
        //bai9
        static bool Tontaisubstring(string arr, string substring)
        {
            bool kq = true;
            if (arr.Contains(substring)) { kq = true; Console.WriteLine("chuoi co ton tai"); }
            else
            {
                kq = false;
                Console.WriteLine("Ko tim thay");
            }
                return kq;
        }

        //bai10
         static void Timvitri1kitu(string arr, string substring)
        {
            int pos = -1;int count = 0;
            string ketqua = "";

            do
            {
                pos = arr.IndexOf(substring, pos + 1);
                if (pos != -1)
                {
                    count++;
                    ketqua += pos + " ";
                }
            }
            while (pos != -1);
            Console.WriteLine(ketqua + count);
           
           
        }
        //timf chu trong mot day
        static void Timvitri1chu(string arr, string substring)
        {
            string[] mangtu = arr.Split(new char[] { ' ', ',','.','!',';',':' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i =0;i<arr.Length; i++)
            {
                if (mangtu[i] == substring)
                {
                    Console.WriteLine("Chu xuat hien tai vi tri: "+ i+1);
                }
            }

        }
        //to check whether a character is an alphabet and not and if so, check for the case
        static void Checkdangchu(string arr, char kittu)
        {
            bool chucai = false;
            Console.WriteLine("Nhap vao ki tu ban muon check: ");
            kittu = char.Parse(Console.ReadLine());
            if (!arr.Contains(kittu))
            {
                Console.WriteLine("Khong tim thay ki tu muon check");
            }
            else
            { 
                if (char.IsLetter(kittu)) 
                { 
                    chucai = true;
                    Console.WriteLine("Day la chu cai");
                
                    if(char.IsUpper(kittu)) { Console.WriteLine("Day la chu hoa"); }
                    else { Console.WriteLine("Khong phai chu hoa"); }
                }
                else { Console.WriteLine("Khong phai chu cai"); }
            }
        }
        //to find the number of times a substring appears in a given string.
        static int Solanxuathien(string arr, string substring)
        {
            int count = 0;
            string[] tachchuoi = arr.Split(new char[] {' ', ',', '.', ';', '!', '*' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Contains(substring))
            {
                for (int i = 0; i < tachchuoi.Length; i++)
                {
                    if (tachchuoi[i] == substring)
                    {
                        count++;
                    }
                }
                Console.WriteLine("So lan xuat hien la " + count);
            }
            else { Console.WriteLine("Khong tim thay"); }
            return count;
        }
        static void Chenchu(string arr)
        {
            int vitri = 0;
            Console.Write("Muon chen truoc chu: ");
            string chomoc = Console.ReadLine();
            Console.Write("Chen chu gi ");
            string chuchen = Console.ReadLine();
            vitri = arr.IndexOf(chomoc);
            if (vitri != -1)
            {
                string kq = arr.Insert(vitri, chuchen + " ");
                Console.WriteLine(kq);
            }
            else { Console.WriteLine("Khong tim thay cho can chen"); }
        }


    }
}

