using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Review
    {
        static void Main(string[] args)
        {
            Bai9();
        }


        //Viết chương trình nhập 2 hệ số a và b của phương trình ax+b = 0. Kết quả Xlà số thực định dạng luôn luôn có 5 số lẻ phía sau.Ví dụ: X = 5.12300
        static void Giaiphuongtrinh()
        {
            double a; double b;
            Console.Write("Nhap so a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Nhap sai so");
                Console.WriteLine("Nhap so a: ");
            }
            Console.Write("Nhap so b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Nhap sai so");
                Console.WriteLine("Nhap lai: ");
            }
            if (a == 0)
            {
                if (b == 0)
                { Console.WriteLine("Vo so nguyem"); }
                else { Console.WriteLine("Vo nghiem"); }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem la " + Math.Round(x, 5));
            }

        }
        // Nhập số lượng lon nhớt khách hàng mua.Cứ 3 lon nhớt thì được thưởng 1 cái nón,
        //số lon còn dư thì cứ 1 lon được thưởng 2 cây viết, một lon nhớt giá 27000 đ.In ra
        //số tiền khách phải trả và số quà được thưởng
        static void Banhang()
        {
            int soluong;
            Console.Write("Nhap so luong lon nhot khach hang mua:");
            while (!int.TryParse(Console.ReadLine(), out soluong) || soluong < 0)
            {
                Console.WriteLine("So nhap khong hop le, hay nhap lai: ");
            }
            int thuongnon;
            int thuongviet;
            thuongnon = soluong / 3;
            thuongviet = soluong % 3 * 2;
            int giatien = soluong * 27000;
            Console.WriteLine($"Khach phai tra {giatien} va duoc thuong {thuongnon} non, {thuongviet} viet! ");
        }
        //        Viết chương trình nhập vào chiều dài 2 cạnh của 1 hình chữ nhật, sau đó vẽ hình
        //chữ nhật này trên màn hình tạo bằng các dấu *
        static void Hinhchunhat()
        {
            int chieudai;
            int chieurong;
            Console.Write("Nhap vao chieu dai: ");
            while (!int.TryParse(Console.ReadLine(), out chieudai) || chieudai < 0)
            { Console.WriteLine("Chieu dai ko dung dinh dang, hay nhap lai: "); }
            Console.Write("Nhap vao chieu rong: ");
            while (!int.TryParse(Console.ReadLine(), out chieurong) || chieurong < 0 || chieurong > chieudai)
            { Console.WriteLine("Chieu rong ko dung dinh dang, hay nhap lai: "); }
            for (int i = 0; i < chieurong; i++)
            {
                for (int j = 0; j < chieudai; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        // Chương trình đoán số: Người chơi sẽ đoán 1 số trong phạm vi từ 0 đến
        //100,chương trình kiểm tra kết quả và xuất các thông báo hướng dẫn(1 điểm) :
        // * Số bạn đoán lớn hơn
        // * Số bạn đóan nhỏ hơn
        //*Bạn đoán đúng
        //Số lần đoán tối đa : 7 lần
        static void Doanso()
        {
            Random random = new Random();
            int sobimat = random.Next(1, 100);
            int sodoan;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Lan doan thu {i}");
                if (i == 7) { Console.WriteLine("Ban da het luot doan"); break; }

                else
                {
                    Console.WriteLine("Nhap vao so doan: ");
                    while (!int.TryParse(Console.ReadLine(), out sodoan))
                    {
                        Console.WriteLine("Nhap sai roi nhap lai di");
                        Console.WriteLine("Nhap vao so doan: ");
                    }
                    if (sodoan == sobimat)
                    {
                        Console.WriteLine($"Doan trung o lan doan thu {i}");
                        break;
                    }
                    else if (sodoan > sobimat)
                    {
                        Console.WriteLine("So doan lon hon so bi mat");
                    }
                    else
                    {
                        Console.WriteLine("So doan nho hon so bi mat");
                    }

                }
            }
        }
        //        Nhập vào 1 dãy các số nguyên.In ra 1 số kết quả sau: số lượng số âm, tổng số số
        //âm, số lượng số dương, tổng số dương trong mảng (1 điểm):
        static void Day()
        {
            Console.Write("Nhap vao mot day so nguyen: ");
            string arr = Console.ReadLine();
            string[] day = arr.Split(' ');
            int[] number = new int[day.Length];
            int countsoam = 0;
            int countsoduong = 0;
            int tongsoam = 0;
            int tongsoduong = 0;
            for (int i = 0; i < day.Length; i++)
            {
                number[i] = int.Parse(day[i]);
                if (number[i] < 0)
                {
                  
                        countsoam++;
                        tongsoam += number[i];
                    
                }
                else if (number[i] > 0)
                {
                   
                        countsoduong++;
                        tongsoduong += number[i];
                    
                }
                

            }
            Console.WriteLine($"Day co {countsoam} co tong la {tongsoam}");
            Console.WriteLine($"Day co {countsoduong} co tong la {tongsoduong}");

        }
//        Nhập 1 chuỗi ký tự S.Cho biết trong S có bao nhiêu ký tự hoa, ký tự thường và ký số. Ví
//dụ S= 'AbCd12Def345Ik6' có 4 ký tự hoa, 5 ký tự thường và 6 ký số
static void Bai7()
        {
            Console.WriteLine("Nhap vao day mot chuoi S: ");
            string arr = Console.ReadLine();
            string[] arr2 = arr.Split(' ');
            char[] chuoi = new char[arr2.Length];
            int countchuhoa = 0;
            int countchuthuong = 0;
            int countso = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                chuoi[i] = char.Parse(arr2[i]);
                if (char.IsLetter(chuoi[i]))
                {
                    if (char.IsUpper(chuoi[i]))
                    {
                        countchuhoa++;
                    }
                    else countchuthuong++;
                }
                else if (char.IsDigit(chuoi[i]))
                    countso++;
            }
            Console.WriteLine($"Ham co {countchuhoa} chu hoa, {countchuthuong} chu thuong va {countso} so");
        }
        static (double a, double b) Daosothuc(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
            return (a, b);
        }
        static void Bai9()
        {
            Console.WriteLine("Dien vao so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Dien vao so b: ");
            double b = double.Parse(Console.ReadLine());
            Daosothuc(ref a,ref  b);
            Console.WriteLine($"Sau khi dao a la {a} b la {}");




        }

    }
}



